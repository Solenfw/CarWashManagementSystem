using CarWashManagement.Core;
using CarWashManagement.Core.Database.SqlHandlers;
using CarWashManagement.Core.Managers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Text;
using Excel = Microsoft.Office.Interop.Excel;


namespace CarWashManagement.UI
{
    public enum ReportMode { Monthly, Yearly }

    // Form to generate report based on the inputted month-year.
    public partial class ReportForm : BaseForm
    {
        private ReportMode currentReportMode = ReportMode.Monthly; // Default report mode.

        private readonly TransactionManager transactionManager;
        private readonly ExpenseManager expenseManager;
        private List<Transaction> lastMonthlyTransactions = new List<Transaction>();
        private int lastMonthlyYear;
        private int lastMonthlyMonth;
        private bool hasMonthlyReport;
        private List<Transaction> lastYearlyTransactions = new List<Transaction>();
        private int lastYearlyYear;
        private bool hasYearlyReport;

        public ReportForm()
        {
            transactionManager = new TransactionManager(new TransactionSqlHandler(), new AuditSqlHandler());
            expenseManager = new ExpenseManager(new ExpenseSqlHandler(), new AuditSqlHandler());

            InitializeComponent();
        }

        // Event handler when the monthly toggle button is clicked.
        private void btnMonthlyToggle_Click(object sender, EventArgs e)
        {
            currentReportMode = ReportMode.Monthly;
            lblSelectMonth.Text = "Chọn Tháng:";
            dtpReportDate.CustomFormat = "MMMM yyyy";

            btnMonthlyToggle.BackColor = Color.FromArgb(41, 128, 185);
            btnMonthlyToggle.ForeColor = Color.White;
            btnYearlyToggle.BackColor = Color.White;
            btnYearlyToggle.ForeColor = Color.FromArgb(41, 128, 185);

            // Clear all textboxes in the report panel.
            foreach (Control ctrl in pnlReport.Controls)
            {
                if (ctrl is TextBox txt) { txt.Clear(); }
            }
            // Clear entry list.
            lsvMonthlyEntries.Items.Clear();
            lsvMonthlyEntries.Groups.Clear();
        }

        // Event handler when the yearly toggle button is clicked.
        private void btnYearlyToggle_Click(object sender, EventArgs e)
        {
            currentReportMode = ReportMode.Yearly;
            lblSelectMonth.Text = "Chọn Năm:";
            dtpReportDate.CustomFormat = "yyyy";

            btnYearlyToggle.BackColor = Color.FromArgb(41, 128, 185);
            btnYearlyToggle.ForeColor = Color.White;
            btnMonthlyToggle.BackColor = Color.White;
            btnMonthlyToggle.ForeColor = Color.FromArgb(41, 128, 185);

            // Clear all textboxes in the report panel.
            foreach (Control ctrl in pnlReport.Controls)
            {
                if (ctrl is TextBox txt) { txt.Clear(); }
            }
            // Clear entry list.
            lsvMonthlyEntries.Items.Clear();
            lsvMonthlyEntries.Groups.Clear();
        }

        // Event handler when the Generate Button is clicked.
        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            // Run the correct report based on the report mode.
            if (currentReportMode == ReportMode.Monthly)
            {
                GenerateMonthlyReport();
            }
            else
            {
                GenerateYearlyReport();
            }
        }

        // Method to generate a monthly financial/statistic report.
        private void GenerateMonthlyReport()
        {
            DateTime selectedDate = dtpReportDate.Value;
            int year = selectedDate.Year;
            int month = selectedDate.Month;

            // Get all transactions for the month.
            List<Transaction> transactions = transactionManager.GetTransactionsForMonth(year, month);

            // Get all expenses for the month.
            List<Expense> expenses = expenseManager.GetExpensesForMonth(year, month);

            lastMonthlyTransactions = transactions;
            lastMonthlyYear = year;
            lastMonthlyMonth = month;
            hasMonthlyReport = true;

            // Calculations.
            decimal totalRevenue = transactions.Sum(txn => txn.TotalAmount);
            decimal totalOwnerShare = transactions.Sum(txn => txn.OwnerShare);
            decimal totalEmployeeShare = transactions.Sum(txn => txn.EmployeeShare);
            int totalWashes = transactions.Count();

            decimal totalExpenses = expenses.Sum(exp => exp.Amount);
            decimal netProfit = totalOwnerShare - totalExpenses;

            // Get Most Washed Vehicle.
            string mostWashed = "N/A";
            if (transactions.Any())
            {
                mostWashed = transactions
                    .GroupBy(txn => txn.VehicleType)
                    .OrderByDescending(g => g.Count())
                    .Select(g => g.Key)
                    .FirstOrDefault() ?? "N/A";
            }

            // Get Most Availed service.
            var allServices = transactions.SelectMany(txn => txn.AdditionalServices);
            string mostService = "N/A";
            if (transactions.Any())
            {
                mostService = allServices
                    .GroupBy(s => s.Name)
                    .OrderByDescending(g => g.Count())
                    .Select(g => g.Key)
                    .FirstOrDefault() ?? "N/A";
            }

            // Highest Revenue Day
            string highestDay = "N/A (0.00)";
            if (transactions.Any())
            {
                var dailyRevenue = transactions
                    .GroupBy(txn => txn.Timestamp.Date)
                    .Select(g => new { Date = g.Key, Total = g.Sum(txn => txn.TotalAmount) })
                    .OrderByDescending(d => d.Total)
                    .FirstOrDefault();

                if (dailyRevenue != null)
                {
                    highestDay = $"{dailyRevenue.Date:MMMM dd} ({dailyRevenue.Total:N2})";
                }
            }

            txtReportTotalRevenue.Text = totalRevenue.ToString("C", CultureInfo.GetCultureInfo("en-US"));
            txtReportOwnerShare.Text = totalOwnerShare.ToString("C", CultureInfo.GetCultureInfo("en-US"));
            txtReportEmpShare.Text = totalEmployeeShare.ToString("C", CultureInfo.GetCultureInfo("en-US"));
            txtReportTotalWashes.Text = totalWashes.ToString();
            txtReportMostWashed.Text = mostWashed;
            txtReportMostService.Text = mostService;
            lblReportHighestDay.Text = "Highest Revenue Day:";
            txtReportHighestDay.Text = highestDay;
            txtReportTotalExpenses.Text = totalExpenses.ToString("C", CultureInfo.GetCultureInfo("en-US"));

            var us = (CultureInfo)CultureInfo.GetCultureInfo("en-US").Clone();
            us.NumberFormat.CurrencyNegativePattern = 1; // -$n
            txtReportNetProfit.Text = netProfit.ToString("C", us);

            lblEntries.Enabled = true;
            lsvMonthlyEntries.Enabled = true;
            lsvMonthlyEntries.Items.Clear();
            lsvMonthlyEntries.Groups.Clear();

            // Group all transactions by date.
            var groupedByDay = transactions
                .OrderBy(txn => txn.Timestamp)
                .GroupBy(txn => txn.Timestamp.Date);

            foreach (var dayGroup in groupedByDay)
            {
                // Create a group for the day.
                string groupHeader = dayGroup.Key.ToString("MMMM dd, yyyy");
                ListViewGroup group = new ListViewGroup(groupHeader);
                lsvMonthlyEntries.Groups.Add(group);

                // Add each transaction from that day to the group.
                foreach (Transaction txn in dayGroup)
                {
                    ListViewItem row = new ListViewItem(txn.Timestamp.ToString("HH:mm"));
                    row.SubItems.Add(txn.VehicleType);
                    row.SubItems.Add(txn.EmployeeName);
                    row.SubItems.Add(txn.OwnerShare.ToString("C", CultureInfo.GetCultureInfo("en-US")));
                    row.SubItems.Add(txn.EmployeeShare.ToString("C", CultureInfo.GetCultureInfo("en-US")));
                    row.SubItems.Add(txn.IsPaid ? "Paid" : "Unpaid");
                    row.Group = group; // Assign the item to the day's group.

                    lsvMonthlyEntries.Items.Add(row);
                }
            }
        }

        // Method to generate yearly financial/statistic report.
        private void GenerateYearlyReport()
        {
            int year = dtpReportDate.Value.Year;

            List<Transaction> transactions = transactionManager.GetTransactionsForYear(year);
            List<Expense> expenses = expenseManager.GetExpensesForYear(year);

            lastYearlyTransactions = transactions;
            lastYearlyYear = year;
            hasYearlyReport = true;

            // Calculations.
            decimal totalRevenue = transactions.Sum(txn => txn.TotalAmount);
            decimal totalOwnerShare = transactions.Sum(txn => txn.OwnerShare);
            decimal totalEmployeeShare = transactions.Sum(txn => txn.EmployeeShare);
            int totalWashes = transactions.Count();

            decimal totalExpenses = expenses.Sum(exp => exp.Amount);
            decimal netProfit = totalOwnerShare - totalExpenses;

            // Get Most Washed Vehicle.
            string mostWashed = "N/A";
            if (transactions.Any())
            {
                mostWashed = transactions
                    .GroupBy(txn => txn.VehicleType)
                    .OrderByDescending(g => g.Count())
                    .Select(g => g.Key)
                    .FirstOrDefault() ?? "N/A";
            }

            // Get Most Availed service.
            var allServices = transactions.SelectMany(txn => txn.AdditionalServices);
            string mostService = "N/A";
            if (transactions.Any())
            {
                mostService = allServices
                    .GroupBy(s => s.Name)
                    .OrderByDescending(g => g.Count())
                    .Select(g => g.Key)
                    .FirstOrDefault() ?? "N/A";
            }

            // Highest Revenue Day
            string highestMonth = "N/A (0.00)";
            if (transactions.Any())
            {
                var monthlyRevenue = transactions
                    .GroupBy(txn => txn.Timestamp.Month)
                    .Select(g => new {
                        Month = g.Key,
                        Total = g.Sum(txn => txn.TotalAmount)
                    })
                    .OrderByDescending(m => m.Total)
                    .FirstOrDefault();

                if (monthlyRevenue != null)
                {
                    // Convert month number to month name.
                    string monthName = new DateTime(year, monthlyRevenue.Month, 1).ToString("MMMM");
                    highestMonth = $"{monthName} ({monthlyRevenue.Total:N2})";
                }
            }

            txtReportTotalRevenue.Text = totalRevenue.ToString("C", CultureInfo.GetCultureInfo("en-US"));
            txtReportOwnerShare.Text = totalOwnerShare.ToString("C", CultureInfo.GetCultureInfo("en-US"));
            txtReportEmpShare.Text = totalEmployeeShare.ToString("C", CultureInfo.GetCultureInfo("en-US"));
            txtReportTotalWashes.Text = totalWashes.ToString();
            txtReportMostWashed.Text = mostWashed;
            txtReportMostService.Text = mostService;
            lblReportHighestDay.Text = "Highest Revenue Month:";
            txtReportHighestDay.Text = highestMonth;
            txtReportTotalExpenses.Text = totalExpenses.ToString("C", CultureInfo.GetCultureInfo("en-US"));
            txtReportNetProfit.Text = netProfit.ToString("C", CultureInfo.GetCultureInfo("en-US"));

            lblEntries.Enabled = false;
            lsvMonthlyEntries.Enabled = false;
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            if (currentReportMode == ReportMode.Monthly)
            {
                if (!hasMonthlyReport)
                {
                    MessageBox.Show("Vui lòng tạo báo cáo tháng trước khi xuất.", "Chưa có dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                ExportMonthlyReportToExcel();
            }
            else
            {
                if (!hasYearlyReport)
                {
                    MessageBox.Show("Vui lòng tạo báo cáo năm trước khi xuất.", "Chưa có dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                ExportYearlyReportToExcel();
            }
        }
        private void ExportMonthlyReportToExcel()
        {
            Excel.Application exApp = new Excel.Application();
            Excel.Workbook exBook = exApp.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
            Excel.Worksheet exSheet = (Excel.Worksheet)exBook.Worksheets[1];
            Excel.Range head = (Excel.Range)exSheet.Cells[1, 1];

            // ===== TITLE =====
            head.Range["B2"].Font.Size = 24;
            head.Range["B2"].Font.Name = "Times New Roman";
            head.Range["B2"].Font.Bold = true;
            head.Range["B2"].Font.Color = Color.Blue;
            head.Range["B2"].Value2 = $"BÁO CÁO THÁNG {lastMonthlyMonth}/{lastMonthlyYear}";

            // ===== SUMMARY HEADER =====
            head.Range["A4:B4"].Font.Size = 13;
            head.Range["A4:B4"].Font.Bold = true;

            exSheet.Cells[4, 1] = "Tóm tắt";
            exSheet.Cells[4, 2] = "Giá trị";

            int row = 5;

            exSheet.Cells[row, 1] = "Tổng doanh thu:"; exSheet.Cells[row++, 2] = txtReportTotalRevenue.Text;
            exSheet.Cells[row, 1] = "Công ty nhận:"; exSheet.Cells[row++, 2] = txtReportOwnerShare.Text;
            exSheet.Cells[row, 1] = "Nhân viên nhận:"; exSheet.Cells[row++, 2] = txtReportEmpShare.Text;
            exSheet.Cells[row, 1] = "Tổng lượt rửa:"; exSheet.Cells[row++, 2] = txtReportTotalWashes.Text;
            exSheet.Cells[row, 1] = "Xe phổ biến nhất:"; exSheet.Cells[row++, 2] = txtReportMostWashed.Text;
            exSheet.Cells[row, 1] = "Dịch vụ phổ biến nhất:"; exSheet.Cells[row++, 2] = txtReportMostService.Text;
            exSheet.Cells[row, 1] = lblReportHighestDay.Text; exSheet.Cells[row++, 2] = txtReportHighestDay.Text;
            exSheet.Cells[row, 1] = "Tổng chi phí:"; exSheet.Cells[row++, 2] = txtReportTotalExpenses.Text;
            exSheet.Cells[row, 1] = "Lợi nhuận ròng:"; exSheet.Cells[row++, 2] = txtReportNetProfit.Text;

            row += 2;

            // ===== LISTVIEW HEADER =====
            exSheet.Cells[row, 1] = "Time";
            exSheet.Cells[row, 2] = "Vehicle";
            exSheet.Cells[row, 3] = "Employee";
            exSheet.Cells[row, 4] = "Owner Share";
            exSheet.Cells[row, 5] = "Employee Share";
            exSheet.Cells[row, 6] = "Paid";
            row++;

            // ===== EXPORT LISTVIEW ROWS =====
            foreach (ListViewItem item in lsvMonthlyEntries.Items)
            {
                for (int col = 0; col < item.SubItems.Count; col++)
                {
                    exSheet.Cells[row, col + 1] = item.SubItems[col].Text;
                }
                row++;
            }

            exSheet.Columns.AutoFit();
            exSheet.Name = "MonthlyReport";

            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "Excel File (*.xlsx)|*.xlsx";
            dlg.FileName = $"MonthlyReport_{lastMonthlyYear}_{lastMonthlyMonth}.xlsx";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                exBook.SaveAs(dlg.FileName);
                MessageBox.Show("Đã xuất báo cáo tháng thành công!",
       "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            exApp.Quit();
        }

     
        private void ExportYearlyReportToExcel()
        {
            Excel.Application exApp = new Excel.Application();
            Excel.Workbook exBook = exApp.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
            Excel.Worksheet exSheet = (Excel.Worksheet)exBook.Worksheets[1];
            Excel.Range head = (Excel.Range)exSheet.Cells[1, 1];

            // ===== TITLE =====
            head.Range["B2"].Font.Size = 24;
            head.Range["B2"].Font.Name = "Times New Roman";
            head.Range["B2"].Font.Bold = true;
            head.Range["B2"].Font.Color = Color.Blue;
            head.Range["B2"].Value2 = $"BÁO CÁO NĂM {lastYearlyYear}";

            head.Range["A4:B4"].Font.Size = 13;
            head.Range["A4:B4"].Font.Bold = true;

            exSheet.Cells[4, 1] = "Tóm tắt";
            exSheet.Cells[4, 2] = "Giá trị";

            int row = 5;

            exSheet.Cells[row, 1] = "Tổng doanh thu:"; exSheet.Cells[row++, 2] = txtReportTotalRevenue.Text;
            exSheet.Cells[row, 1] = "Công ty nhận:"; exSheet.Cells[row++, 2] = txtReportOwnerShare.Text;
            exSheet.Cells[row, 1] = "Nhân viên nhận:"; exSheet.Cells[row++, 2] = txtReportEmpShare.Text;
            exSheet.Cells[row, 1] = "Tổng lượt rửa:"; exSheet.Cells[row++, 2] = txtReportTotalWashes.Text;
            exSheet.Cells[row, 1] = "Xe phổ biến nhất:"; exSheet.Cells[row++, 2] = txtReportMostWashed.Text;
            exSheet.Cells[row, 1] = "Dịch vụ phổ biến nhất:"; exSheet.Cells[row++, 2] = txtReportMostService.Text;
            exSheet.Cells[row, 1] = lblReportHighestDay.Text; exSheet.Cells[row++, 2] = txtReportHighestDay.Text;
            exSheet.Cells[row, 1] = "Tổng chi phí:"; exSheet.Cells[row++, 2] = txtReportTotalExpenses.Text;
            exSheet.Cells[row, 1] = "Lợi nhuận ròng:"; exSheet.Cells[row++, 2] = txtReportNetProfit.Text;

            row += 2;

            // ===== MONTH BREAKDOWN HEADER =====
            exSheet.Cells[row, 1] = "Month";
            exSheet.Cells[row, 2] = "Revenue";
            exSheet.Cells[row, 3] = "Owner Share";
            exSheet.Cells[row, 4] = "Employee Share";
            exSheet.Cells[row, 5] = "Washes";
            row++;

            var breakdown = lastYearlyTransactions
                .GroupBy(txn => txn.Timestamp.Month)
                .OrderBy(g => g.Key)
                .Select(g => new
                {
                    Month = g.Key,
                    Rev = g.Sum(txn => txn.TotalAmount),
                    Own = g.Sum(txn => txn.OwnerShare),
                    Emp = g.Sum(txn => txn.EmployeeShare),
                    Wash = g.Count()
                });

            foreach (var m in breakdown)
            {
                string monthName = new DateTime(lastYearlyYear, m.Month, 1).ToString("MMMM");

                exSheet.Cells[row, 1] = monthName;
                exSheet.Cells[row, 2] = m.Rev.ToString("N2");
                exSheet.Cells[row, 3] = m.Own.ToString("N2");
                exSheet.Cells[row, 4] = m.Emp.ToString("N2");
                exSheet.Cells[row, 5] = m.Wash.ToString();
                row++;
            }

            exSheet.Columns.AutoFit();
            exSheet.Name = "YearlyReport";

            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "Excel File (*.xlsx)|*.xlsx";
            dlg.FileName = $"YearlyReport_{lastYearlyYear}.xlsx";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                exBook.SaveAs(dlg.FileName);
                MessageBox.Show("Đã xuất báo cáo năm thành công!",
       "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            exApp.Quit();
        }


        private void AppendListViewToCsv(ListView listView, StringBuilder builder)
        {
            var headers = listView.Columns.Cast<ColumnHeader>()
                .Select(col => EscapeCsv(col.Text));

            builder.AppendLine(string.Join(",", headers));

            foreach (ListViewItem item in listView.Items)
            {
                List<string> cells = new List<string>
                {
                    EscapeCsv(item.Text)
                };

                foreach (ListViewItem.ListViewSubItem subItem in item.SubItems.Cast<ListViewItem.ListViewSubItem>().Skip(1))
                {
                    cells.Add(EscapeCsv(subItem.Text));
                }

                builder.AppendLine(string.Join(",", cells));
            }
        }

        private void AppendKeyValueRow(StringBuilder builder, string key, string value)
        {
            builder.AppendLine($"{EscapeCsv(key)},{EscapeCsv(value)}");
        }

        private string EscapeCsv(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return string.Empty;
            }

            if (value.Contains("\"") || value.Contains(",") || value.Contains("\n"))
            {
                return $"\"{value.Replace("\"", "\"\"")}\"";
            }

            return value;
        }
    }
}