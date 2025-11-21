using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace CarWashManagement.UI
{
    partial class ChartForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lblSelectPeriod = new System.Windows.Forms.Label();
            this.dtpChartDate = new System.Windows.Forms.DateTimePicker();
            this.btnGenerateCharts = new System.Windows.Forms.Button();
            this.btnMonthlyMode = new System.Windows.Forms.Button();
            this.btnYearlyMode = new System.Windows.Forms.Button();
            this.chartRevenue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartWashes = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblRevenueChart = new System.Windows.Forms.Label();
            this.lblWashesChart = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartRevenue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartWashes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSelectPeriod
            // 
            this.lblSelectPeriod.AutoSize = true;
            this.lblSelectPeriod.Location = new System.Drawing.Point(24, 20);
            this.lblSelectPeriod.Name = "lblSelectPeriod";
            this.lblSelectPeriod.Size = new System.Drawing.Size(90, 15);
            this.lblSelectPeriod.TabIndex = 0;
            this.lblSelectPeriod.Text = "Chọn thời điểm:";
            // 
            // dtpChartDate
            // 
            this.dtpChartDate.CustomFormat = "MMMM yyyy";
            this.dtpChartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpChartDate.Location = new System.Drawing.Point(130, 16);
            this.dtpChartDate.Name = "dtpChartDate";
            this.dtpChartDate.Size = new System.Drawing.Size(180, 23);
            this.dtpChartDate.TabIndex = 1;
            // 
            // btnGenerateCharts
            // 
            this.btnGenerateCharts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnGenerateCharts.FlatAppearance.BorderSize = 0;
            this.btnGenerateCharts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateCharts.ForeColor = System.Drawing.Color.White;
            this.btnGenerateCharts.Location = new System.Drawing.Point(325, 12);
            this.btnGenerateCharts.Name = "btnGenerateCharts";
            this.btnGenerateCharts.Size = new System.Drawing.Size(90, 30);
            this.btnGenerateCharts.TabIndex = 2;
            this.btnGenerateCharts.Text = "Tải biểu đồ";
            this.btnGenerateCharts.UseVisualStyleBackColor = false;
            this.btnGenerateCharts.Click += new System.EventHandler(this.btnGenerateCharts_Click);
            // 
            // btnMonthlyMode
            // 
            this.btnMonthlyMode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnMonthlyMode.FlatAppearance.BorderSize = 0;
            this.btnMonthlyMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMonthlyMode.ForeColor = System.Drawing.Color.White;
            this.btnMonthlyMode.Location = new System.Drawing.Point(450, 12);
            this.btnMonthlyMode.Name = "btnMonthlyMode";
            this.btnMonthlyMode.Size = new System.Drawing.Size(90, 30);
            this.btnMonthlyMode.TabIndex = 3;
            this.btnMonthlyMode.Text = "Theo tháng";
            this.btnMonthlyMode.UseVisualStyleBackColor = false;
            this.btnMonthlyMode.Click += new System.EventHandler(this.btnMonthlyMode_Click);
            // 
            // btnYearlyMode
            // 
            this.btnYearlyMode.BackColor = System.Drawing.Color.White;
            this.btnYearlyMode.FlatAppearance.BorderSize = 0;
            this.btnYearlyMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYearlyMode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnYearlyMode.Location = new System.Drawing.Point(546, 12);
            this.btnYearlyMode.Name = "btnYearlyMode";
            this.btnYearlyMode.Size = new System.Drawing.Size(90, 30);
            this.btnYearlyMode.TabIndex = 4;
            this.btnYearlyMode.Text = "Theo năm";
            this.btnYearlyMode.UseVisualStyleBackColor = false;
            this.btnYearlyMode.Click += new System.EventHandler(this.btnYearlyMode_Click);
            // 
            // chartRevenue
            // 
            chartArea1.AxisX.Interval = 1D;
            chartArea1.Name = "ChartArea1";
            this.chartRevenue.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartRevenue.Legends.Add(legend1);
            this.chartRevenue.Location = new System.Drawing.Point(24, 90);
            this.chartRevenue.Name = "chartRevenue";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            series1.Legend = "Legend1";
            series1.Name = "Revenue";
            this.chartRevenue.Series.Add(series1);
            this.chartRevenue.Size = new System.Drawing.Size(612, 250);
            this.chartRevenue.TabIndex = 5;
            this.chartRevenue.Text = "chart1";
            this.chartRevenue.Titles.Add("RevenueTitle");
            // 
            // chartWashes
            // 
            chartArea2.AxisX.Interval = 1D;
            chartArea2.Name = "ChartArea1";
            this.chartWashes.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartWashes.Legends.Add(legend2);
            this.chartWashes.Location = new System.Drawing.Point(24, 392);
            this.chartWashes.Name = "chartWashes";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            series2.Legend = "Legend1";
            series2.Name = "Washes";
            this.chartWashes.Series.Add(series2);
            this.chartWashes.Size = new System.Drawing.Size(612, 250);
            this.chartWashes.TabIndex = 6;
            this.chartWashes.Text = "chart2";
            this.chartWashes.Titles.Add("WashesTitle");
            // 
            // lblRevenueChart
            // 
            this.lblRevenueChart.AutoSize = true;
            this.lblRevenueChart.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblRevenueChart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblRevenueChart.Location = new System.Drawing.Point(24, 62);
            this.lblRevenueChart.Name = "lblRevenueChart";
            this.lblRevenueChart.Size = new System.Drawing.Size(164, 20);
            this.lblRevenueChart.TabIndex = 7;
            this.lblRevenueChart.Text = "Biểu đồ doanh thu";
            // 
            // lblWashesChart
            // 
            this.lblWashesChart.AutoSize = true;
            this.lblWashesChart.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblWashesChart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblWashesChart.Location = new System.Drawing.Point(24, 364);
            this.lblWashesChart.Name = "lblWashesChart";
            this.lblWashesChart.Size = new System.Drawing.Size(194, 20);
            this.lblWashesChart.TabIndex = 8;
            this.lblWashesChart.Text = "Biểu đồ số xe được rửa";
            // 
            // ChartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 664);
            this.Controls.Add(this.lblWashesChart);
            this.Controls.Add(this.lblRevenueChart);
            this.Controls.Add(this.chartWashes);
            this.Controls.Add(this.chartRevenue);
            this.Controls.Add(this.btnYearlyMode);
            this.Controls.Add(this.btnMonthlyMode);
            this.Controls.Add(this.btnGenerateCharts);
            this.Controls.Add(this.dtpChartDate);
            this.Controls.Add(this.lblSelectPeriod);
            this.Name = "ChartForm";
            this.Text = "Biểu đồ doanh thu và số xe";
            ((System.ComponentModel.ISupportInitialize)(this.chartRevenue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartWashes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblSelectPeriod;
        private DateTimePicker dtpChartDate;
        private Button btnGenerateCharts;
        private Button btnMonthlyMode;
        private Button btnYearlyMode;
        private Chart chartRevenue;
        private Chart chartWashes;
        private Label lblRevenueChart;
        private Label lblWashesChart;
    }
}

