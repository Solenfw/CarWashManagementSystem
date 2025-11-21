using CarWashManagement.Core;
using CarWashManagement.Core.Database.SqlHandlers;
using CarWashManagement.Core.Managers;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace CarWashManagement.UI
{
    public enum ChartMode
    {
        Monthly,
        Yearly
    }

    public partial class ChartForm : BaseForm
    {
        private readonly TransactionManager transactionManager;
        private ChartMode currentMode = ChartMode.Monthly;

        public ChartForm()
        {
            transactionManager = new TransactionManager(new TransactionSqlHandler(), new AuditSqlHandler());
            InitializeComponent();
            UpdateModeButtons();
            btnGenerateCharts_Click(this, EventArgs.Empty);
        }

        private void btnMonthlyMode_Click(object sender, EventArgs e)
        {
            currentMode = ChartMode.Monthly;
            dtpChartDate.CustomFormat = "MMMM yyyy";
            UpdateModeButtons();
        }

        private void btnYearlyMode_Click(object sender, EventArgs e)
        {
            currentMode = ChartMode.Yearly;
            dtpChartDate.CustomFormat = "yyyy";
            UpdateModeButtons();
        }

        private void btnGenerateCharts_Click(object sender, EventArgs e)
        {
            try
            {
                if (currentMode == ChartMode.Monthly)
                {
                    GenerateMonthlyCharts();
                }
                else
                {
                    GenerateYearlyCharts();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Không thể tải dữ liệu biểu đồ: {ex.Message}", "Chart Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateModeButtons()
        {
            bool isMonthly = currentMode == ChartMode.Monthly;

            btnMonthlyMode.BackColor = isMonthly ? System.Drawing.Color.FromArgb(41, 128, 185) : System.Drawing.Color.White;
            btnMonthlyMode.ForeColor = isMonthly ? System.Drawing.Color.White : System.Drawing.Color.FromArgb(41, 128, 185);

            btnYearlyMode.BackColor = !isMonthly ? System.Drawing.Color.FromArgb(41, 128, 185) : System.Drawing.Color.White;
            btnYearlyMode.ForeColor = !isMonthly ? System.Drawing.Color.White : System.Drawing.Color.FromArgb(41, 128, 185);
        }

        private void GenerateMonthlyCharts()
        {
            DateTime selectedDate = dtpChartDate.Value;
            int year = selectedDate.Year;
            int month = selectedDate.Month;

            List<Transaction> transactions = transactionManager.GetTransactionsForMonth(year, month);

            var revenueByDay = transactions
                .GroupBy(txn => txn.Timestamp.Date)
                .OrderBy(group => group.Key)
                .Select(group => new
                {
                    Day = group.Key,
                    Revenue = group.Sum(txn => txn.TotalAmount),
                    Washes = group.Count()
                })
                .ToList();

            UpdateRevenueChart(revenueByDay.Select(d => new ChartPoint
            {
                Label = d.Day.ToString("dd"),
                Value = (double)d.Revenue
            }), $"Doanh thu theo ngày - {selectedDate:MMMM yyyy}");

            UpdateWashesChart(revenueByDay.Select(d => new ChartPoint
            {
                Label = d.Day.ToString("dd"),
                Value = d.Washes
            }), $"Số xe rửa theo ngày - {selectedDate:MMMM yyyy}");

            if (!revenueByDay.Any())
            {
                MessageBox.Show("Không có dữ liệu giao dịch trong tháng này.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void GenerateYearlyCharts()
        {
            int year = dtpChartDate.Value.Year;

            List<Transaction> transactions = transactionManager.GetTransactionsForYear(year);

            var revenueByMonth = transactions
                .GroupBy(txn => txn.Timestamp.Month)
                .OrderBy(group => group.Key)
                .Select(group => new
                {
                    Month = group.Key,
                    Revenue = group.Sum(txn => txn.TotalAmount),
                    Washes = group.Count()
                })
                .ToList();

            UpdateRevenueChart(revenueByMonth.Select(m => new ChartPoint
            {
                Label = CultureInfo.CurrentCulture.DateTimeFormat.GetAbbreviatedMonthName(m.Month),
                Value = (double)m.Revenue
            }), $"Doanh thu theo tháng - {year}");

            UpdateWashesChart(revenueByMonth.Select(m => new ChartPoint
            {
                Label = CultureInfo.CurrentCulture.DateTimeFormat.GetAbbreviatedMonthName(m.Month),
                Value = m.Washes
            }), $"Số xe rửa theo tháng - {year}");

            if (!revenueByMonth.Any())
            {
                MessageBox.Show("Không có dữ liệu giao dịch trong năm này.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void UpdateRevenueChart(IEnumerable<ChartPoint> dataPoints, string title)
        {
            chartRevenue.Series["Revenue"].Points.Clear();
            chartRevenue.Titles[0].Text = title;

            foreach (ChartPoint point in dataPoints)
            {
                chartRevenue.Series["Revenue"].Points.AddXY(point.Label, point.Value);
            }
        }

        private void UpdateWashesChart(IEnumerable<ChartPoint> dataPoints, string title)
        {
            chartWashes.Series["Washes"].Points.Clear();
            chartWashes.Titles[0].Text = title;

            foreach (ChartPoint point in dataPoints)
            {
                chartWashes.Series["Washes"].Points.AddXY(point.Label, point.Value);
            }
        }

        private class ChartPoint
        {
            public string Label { get; set; }
            public double Value { get; set; }
        }
    }
}

