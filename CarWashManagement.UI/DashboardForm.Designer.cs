using System.Drawing;
using System.Windows.Forms;

namespace CarWashManagement.UI
{
    partial class DashboardForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            this.headerPanel = new System.Windows.Forms.Panel();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.logoutButton = new System.Windows.Forms.Button();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.adminMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageVehiclesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageServicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageExpensesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monthlyYearlyReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewChartsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.washEntryPanel = new System.Windows.Forms.Panel();
            this.btnAddTransaction = new System.Windows.Forms.Button();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.cmbDiscount = new System.Windows.Forms.ComboBox();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.chkWashStatus = new System.Windows.Forms.CheckBox();
            this.chkIsPaid = new System.Windows.Forms.CheckBox();
            this.txtServiceEmpShare = new System.Windows.Forms.TextBox();
            this.lblServiceEmpShare = new System.Windows.Forms.Label();
            this.txtServiceOwnerShare = new System.Windows.Forms.TextBox();
            this.lblServiceOwnerShare = new System.Windows.Forms.Label();
            this.txtTotalServiceFee = new System.Windows.Forms.TextBox();
            this.lblTotalServiceFee = new System.Windows.Forms.Label();
            this.servicePanel = new System.Windows.Forms.Panel();
            this.lblAdditionalServices = new System.Windows.Forms.Label();
            this.txtEmployeeShare = new System.Windows.Forms.TextBox();
            this.lblEmployeeShare = new System.Windows.Forms.Label();
            this.txtOwnerShare = new System.Windows.Forms.TextBox();
            this.lblOwnerShare = new System.Windows.Forms.Label();
            this.txtBaseFee = new System.Windows.Forms.TextBox();
            this.lblBaseFee = new System.Windows.Forms.Label();
            this.cmbVehicleType = new System.Windows.Forms.ComboBox();
            this.lblVehicleType = new System.Windows.Forms.Label();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.btnExportToday = new System.Windows.Forms.Button();
            this.todaysEntriesPanel = new System.Windows.Forms.Panel();
            this.lsvTodayEntries = new System.Windows.Forms.ListView();
            this.columnTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnVehicle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnEmployee = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPaid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnWashStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lsvContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.togglePaidStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toggleWashStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dailySummaryPanel = new System.Windows.Forms.Panel();
            this.txtSummaryMostWashedVehicle = new System.Windows.Forms.TextBox();
            this.lblSummaryMostWashedVehicle = new System.Windows.Forms.Label();
            this.txtSummaryTotalWashes = new System.Windows.Forms.TextBox();
            this.lblSummaryTotalWashes = new System.Windows.Forms.Label();
            this.txtSummaryTotalEmpShare = new System.Windows.Forms.TextBox();
            this.lblSummaryTotalEmpShare = new System.Windows.Forms.Label();
            this.txtSummaryTotalOwnerShare = new System.Windows.Forms.TextBox();
            this.lblSummaryTotalOwnerShare = new System.Windows.Forms.Label();
            this.txtSummaryTotalRevenue = new System.Windows.Forms.TextBox();
            this.lblSummaryTotalRevenue = new System.Windows.Forms.Label();
            this.lblDailySummary = new System.Windows.Forms.Label();
            this.txtEmployeeToSearch = new System.Windows.Forms.RichTextBox();
            this.cmbVehicleToSearch = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMinPriceToSearch = new System.Windows.Forms.TextBox();
            this.txtMaxPriceToSearch = new System.Windows.Forms.TextBox();
            this.cmbPaidStatus = new System.Windows.Forms.ComboBox();
            this.cmbWashStatus = new System.Windows.Forms.ComboBox();
            this.dateToSearch = new System.Windows.Forms.DateTimePicker();
            this.btnFilter = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pchVehicles = new LiveCharts.WinForms.PieChart();
            this.label8 = new System.Windows.Forms.Label();
            this.headerPanel.SuspendLayout();
            this.mainMenu.SuspendLayout();
            this.washEntryPanel.SuspendLayout();
            this.todaysEntriesPanel.SuspendLayout();
            this.lsvContextMenu.SuspendLayout();
            this.dailySummaryPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.headerPanel.Controls.Add(this.welcomeLabel);
            this.headerPanel.Controls.Add(this.logoutButton);
            this.headerPanel.Controls.Add(this.mainMenu);
            this.headerPanel.Controls.Add(this.btnChangePassword);
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(1466, 48);
            this.headerPanel.TabIndex = 0;
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.BackColor = System.Drawing.Color.White;
            this.welcomeLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.welcomeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.welcomeLabel.Location = new System.Drawing.Point(13, 12);
            this.welcomeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(51, 20);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "label1";
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.Color.White;
            this.logoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.logoutButton.Location = new System.Drawing.Point(1367, 6);
            this.logoutButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(75, 35);
            this.logoutButton.TabIndex = 2;
            this.logoutButton.Text = "Đăng Xuất";
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // mainMenu
            // 
            this.mainMenu.BackColor = System.Drawing.Color.White;
            this.mainMenu.Dock = System.Windows.Forms.DockStyle.None;
            this.mainMenu.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.mainMenu.ForeColor = System.Drawing.Color.White;
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(373, 12);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.mainMenu.Size = new System.Drawing.Size(202, 24);
            this.mainMenu.TabIndex = 3;
            this.mainMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mainMenu_ItemClicked);
            // 
            // adminMenuItem
            // 
            this.adminMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.adminMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageUsersToolStripMenuItem,
            this.manageVehiclesToolStripMenuItem,
            this.manageServicesToolStripMenuItem,
            this.manageExpensesToolStripMenuItem,
            this.monthlyYearlyReportToolStripMenuItem,
            this.viewChartsToolStripMenuItem});
            this.adminMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.adminMenuItem.Name = "adminMenuItem";
            this.adminMenuItem.Size = new System.Drawing.Size(58, 24);
            this.adminMenuItem.Text = "Menu";
            this.adminMenuItem.Visible = false;
            // 
            // manageUsersToolStripMenuItem
            // 
            this.manageUsersToolStripMenuItem.Name = "manageUsersToolStripMenuItem";
            this.manageUsersToolStripMenuItem.Size = new System.Drawing.Size(215, 24);
            this.manageUsersToolStripMenuItem.Text = "Quản lý Nhân Viên";
            this.manageUsersToolStripMenuItem.Click += new System.EventHandler(this.ManageUsers_Click);
            // 
            // manageVehiclesToolStripMenuItem
            // 
            this.manageVehiclesToolStripMenuItem.Name = "manageVehiclesToolStripMenuItem";
            this.manageVehiclesToolStripMenuItem.Size = new System.Drawing.Size(215, 24);
            this.manageVehiclesToolStripMenuItem.Text = "Quản lý Phương Tiện";
            this.manageVehiclesToolStripMenuItem.Click += new System.EventHandler(this.ManageVehicles_Click);
            // 
            // manageServicesToolStripMenuItem
            // 
            this.manageServicesToolStripMenuItem.Name = "manageServicesToolStripMenuItem";
            this.manageServicesToolStripMenuItem.Size = new System.Drawing.Size(215, 24);
            this.manageServicesToolStripMenuItem.Text = "Quản lý Dịch Vụ";
            this.manageServicesToolStripMenuItem.Click += new System.EventHandler(this.ManageServices_Click);
            // 
            // manageExpensesToolStripMenuItem
            // 
            this.manageExpensesToolStripMenuItem.Name = "manageExpensesToolStripMenuItem";
            this.manageExpensesToolStripMenuItem.Size = new System.Drawing.Size(215, 24);
            this.manageExpensesToolStripMenuItem.Text = "Quản lý Chi Phí";
            this.manageExpensesToolStripMenuItem.Click += new System.EventHandler(this.ManageExpenses_Click);
            // 
            // monthlyYearlyReportToolStripMenuItem
            // 
            this.monthlyYearlyReportToolStripMenuItem.Name = "monthlyYearlyReportToolStripMenuItem";
            this.monthlyYearlyReportToolStripMenuItem.Size = new System.Drawing.Size(215, 24);
            this.monthlyYearlyReportToolStripMenuItem.Text = "Báo cáo Tháng/Năm";
            this.monthlyYearlyReportToolStripMenuItem.Click += new System.EventHandler(this.ShowMonthlyReport_Click);
            // 
            // viewChartsToolStripMenuItem
            // 
            this.viewChartsToolStripMenuItem.Name = "viewChartsToolStripMenuItem";
            this.viewChartsToolStripMenuItem.Size = new System.Drawing.Size(215, 24);
            this.viewChartsToolStripMenuItem.Text = "Biểu đồ";
            this.viewChartsToolStripMenuItem.Click += new System.EventHandler(this.ShowCharts_Click);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.BackColor = System.Drawing.Color.White;
            this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnChangePassword.Location = new System.Drawing.Point(1261, 6);
            this.btnChangePassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(88, 35);
            this.btnChangePassword.TabIndex = 1;
            this.btnChangePassword.Text = "Đổi mật khẩu";
            this.btnChangePassword.UseVisualStyleBackColor = false;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // washEntryPanel
            // 
            this.washEntryPanel.BackColor = System.Drawing.Color.White;
            this.washEntryPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.washEntryPanel.Controls.Add(this.btnAddTransaction);
            this.washEntryPanel.Controls.Add(this.txtTotalAmount);
            this.washEntryPanel.Controls.Add(this.lblTotalAmount);
            this.washEntryPanel.Controls.Add(this.cmbDiscount);
            this.washEntryPanel.Controls.Add(this.lblDiscount);
            this.washEntryPanel.Controls.Add(this.chkWashStatus);
            this.washEntryPanel.Controls.Add(this.chkIsPaid);
            this.washEntryPanel.Controls.Add(this.txtServiceEmpShare);
            this.washEntryPanel.Controls.Add(this.lblServiceEmpShare);
            this.washEntryPanel.Controls.Add(this.txtServiceOwnerShare);
            this.washEntryPanel.Controls.Add(this.lblServiceOwnerShare);
            this.washEntryPanel.Controls.Add(this.txtTotalServiceFee);
            this.washEntryPanel.Controls.Add(this.lblTotalServiceFee);
            this.washEntryPanel.Controls.Add(this.servicePanel);
            this.washEntryPanel.Controls.Add(this.lblAdditionalServices);
            this.washEntryPanel.Controls.Add(this.txtEmployeeShare);
            this.washEntryPanel.Controls.Add(this.lblEmployeeShare);
            this.washEntryPanel.Controls.Add(this.txtOwnerShare);
            this.washEntryPanel.Controls.Add(this.lblOwnerShare);
            this.washEntryPanel.Controls.Add(this.txtBaseFee);
            this.washEntryPanel.Controls.Add(this.lblBaseFee);
            this.washEntryPanel.Controls.Add(this.cmbVehicleType);
            this.washEntryPanel.Controls.Add(this.lblVehicleType);
            this.washEntryPanel.Controls.Add(this.txtEmployeeName);
            this.washEntryPanel.Controls.Add(this.lblEmployee);
            this.washEntryPanel.Location = new System.Drawing.Point(12, 70);
            this.washEntryPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.washEntryPanel.Name = "washEntryPanel";
            this.washEntryPanel.Size = new System.Drawing.Size(350, 679);
            this.washEntryPanel.TabIndex = 1;
            // 
            // btnAddTransaction
            // 
            this.btnAddTransaction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnAddTransaction.FlatAppearance.BorderSize = 0;
            this.btnAddTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTransaction.ForeColor = System.Drawing.Color.White;
            this.btnAddTransaction.Location = new System.Drawing.Point(12, 635);
            this.btnAddTransaction.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAddTransaction.Name = "btnAddTransaction";
            this.btnAddTransaction.Size = new System.Drawing.Size(315, 35);
            this.btnAddTransaction.TabIndex = 23;
            this.btnAddTransaction.Text = "Lập phiếu";
            this.btnAddTransaction.UseVisualStyleBackColor = false;
            this.btnAddTransaction.Click += new System.EventHandler(this.btnAddTransaction_Click);
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.BackColor = System.Drawing.Color.White;
            this.txtTotalAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtTotalAmount.Location = new System.Drawing.Point(140, 591);
            this.txtTotalAmount.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.ReadOnly = true;
            this.txtTotalAmount.Size = new System.Drawing.Size(186, 20);
            this.txtTotalAmount.TabIndex = 22;
            this.txtTotalAmount.Text = "0.00";
            this.txtTotalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotalAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblTotalAmount.Location = new System.Drawing.Point(8, 590);
            this.lblTotalAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(94, 19);
            this.lblTotalAmount.TabIndex = 21;
            this.lblTotalAmount.Text = "Chi phí tổng:";
            // 
            // cmbDiscount
            // 
            this.cmbDiscount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDiscount.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbDiscount.FormattingEnabled = true;
            this.cmbDiscount.Items.AddRange(new object[] {
            "N/A",
            "20%",
            "30%",
            "50%"});
            this.cmbDiscount.Location = new System.Drawing.Point(257, 519);
            this.cmbDiscount.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbDiscount.Name = "cmbDiscount";
            this.cmbDiscount.Size = new System.Drawing.Size(69, 23);
            this.cmbDiscount.TabIndex = 20;
            this.cmbDiscount.SelectedIndexChanged += new System.EventHandler(this.cmbDiscount_SelectedIndexChanged);
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Location = new System.Drawing.Point(187, 523);
            this.lblDiscount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(57, 15);
            this.lblDiscount.TabIndex = 19;
            this.lblDiscount.Text = "Discount:";
            // 
            // chkWashStatus
            // 
            this.chkWashStatus.AutoSize = true;
            this.chkWashStatus.Location = new System.Drawing.Point(12, 554);
            this.chkWashStatus.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkWashStatus.Name = "chkWashStatus";
            this.chkWashStatus.Size = new System.Drawing.Size(89, 19);
            this.chkWashStatus.TabIndex = 18;
            this.chkWashStatus.Text = "Hoàn thành";
            this.chkWashStatus.UseVisualStyleBackColor = true;
            // 
            // chkIsPaid
            // 
            this.chkIsPaid.AutoSize = true;
            this.chkIsPaid.Location = new System.Drawing.Point(12, 523);
            this.chkIsPaid.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkIsPaid.Name = "chkIsPaid";
            this.chkIsPaid.Size = new System.Drawing.Size(57, 19);
            this.chkIsPaid.TabIndex = 17;
            this.chkIsPaid.Text = "Đã trả";
            this.chkIsPaid.UseVisualStyleBackColor = true;
            // 
            // txtServiceEmpShare
            // 
            this.txtServiceEmpShare.BackColor = System.Drawing.Color.White;
            this.txtServiceEmpShare.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtServiceEmpShare.Location = new System.Drawing.Point(222, 485);
            this.txtServiceEmpShare.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtServiceEmpShare.Name = "txtServiceEmpShare";
            this.txtServiceEmpShare.ReadOnly = true;
            this.txtServiceEmpShare.Size = new System.Drawing.Size(93, 23);
            this.txtServiceEmpShare.TabIndex = 16;
            this.txtServiceEmpShare.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblServiceEmpShare
            // 
            this.lblServiceEmpShare.AutoSize = true;
            this.lblServiceEmpShare.Location = new System.Drawing.Point(222, 462);
            this.lblServiceEmpShare.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblServiceEmpShare.Name = "lblServiceEmpShare";
            this.lblServiceEmpShare.Size = new System.Drawing.Size(94, 15);
            this.lblServiceEmpShare.TabIndex = 15;
            this.lblServiceEmpShare.Text = "Nhân viên nhận:";
            // 
            // txtServiceOwnerShare
            // 
            this.txtServiceOwnerShare.BackColor = System.Drawing.Color.White;
            this.txtServiceOwnerShare.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtServiceOwnerShare.Location = new System.Drawing.Point(117, 485);
            this.txtServiceOwnerShare.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtServiceOwnerShare.Name = "txtServiceOwnerShare";
            this.txtServiceOwnerShare.ReadOnly = true;
            this.txtServiceOwnerShare.Size = new System.Drawing.Size(93, 23);
            this.txtServiceOwnerShare.TabIndex = 14;
            this.txtServiceOwnerShare.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblServiceOwnerShare
            // 
            this.lblServiceOwnerShare.AutoSize = true;
            this.lblServiceOwnerShare.Location = new System.Drawing.Point(117, 462);
            this.lblServiceOwnerShare.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblServiceOwnerShare.Name = "lblServiceOwnerShare";
            this.lblServiceOwnerShare.Size = new System.Drawing.Size(82, 15);
            this.lblServiceOwnerShare.TabIndex = 13;
            this.lblServiceOwnerShare.Text = "Công ty nhận:";
            // 
            // txtTotalServiceFee
            // 
            this.txtTotalServiceFee.BackColor = System.Drawing.Color.White;
            this.txtTotalServiceFee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalServiceFee.Location = new System.Drawing.Point(12, 485);
            this.txtTotalServiceFee.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTotalServiceFee.Name = "txtTotalServiceFee";
            this.txtTotalServiceFee.ReadOnly = true;
            this.txtTotalServiceFee.Size = new System.Drawing.Size(93, 23);
            this.txtTotalServiceFee.TabIndex = 12;
            this.txtTotalServiceFee.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTotalServiceFee
            // 
            this.lblTotalServiceFee.AutoSize = true;
            this.lblTotalServiceFee.Location = new System.Drawing.Point(12, 462);
            this.lblTotalServiceFee.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalServiceFee.Name = "lblTotalServiceFee";
            this.lblTotalServiceFee.Size = new System.Drawing.Size(69, 15);
            this.lblTotalServiceFee.TabIndex = 11;
            this.lblTotalServiceFee.Text = "Phí dịch vụ:";
            // 
            // servicePanel
            // 
            this.servicePanel.AutoScroll = true;
            this.servicePanel.Location = new System.Drawing.Point(12, 174);
            this.servicePanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.servicePanel.Name = "servicePanel";
            this.servicePanel.Size = new System.Drawing.Size(327, 282);
            this.servicePanel.TabIndex = 10;
            // 
            // lblAdditionalServices
            // 
            this.lblAdditionalServices.AutoSize = true;
            this.lblAdditionalServices.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblAdditionalServices.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblAdditionalServices.Location = new System.Drawing.Point(8, 151);
            this.lblAdditionalServices.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdditionalServices.Name = "lblAdditionalServices";
            this.lblAdditionalServices.Size = new System.Drawing.Size(132, 20);
            this.lblAdditionalServices.TabIndex = 9;
            this.lblAdditionalServices.Text = "Các dịch vụ thêm:";
            // 
            // txtEmployeeShare
            // 
            this.txtEmployeeShare.BackColor = System.Drawing.Color.White;
            this.txtEmployeeShare.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmployeeShare.Location = new System.Drawing.Point(223, 125);
            this.txtEmployeeShare.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtEmployeeShare.Name = "txtEmployeeShare";
            this.txtEmployeeShare.ReadOnly = true;
            this.txtEmployeeShare.Size = new System.Drawing.Size(93, 23);
            this.txtEmployeeShare.TabIndex = 8;
            this.txtEmployeeShare.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblEmployeeShare
            // 
            this.lblEmployeeShare.AutoSize = true;
            this.lblEmployeeShare.Location = new System.Drawing.Point(222, 107);
            this.lblEmployeeShare.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmployeeShare.Name = "lblEmployeeShare";
            this.lblEmployeeShare.Size = new System.Drawing.Size(94, 15);
            this.lblEmployeeShare.TabIndex = 7;
            this.lblEmployeeShare.Text = "Nhân viên nhận:";
            // 
            // txtOwnerShare
            // 
            this.txtOwnerShare.BackColor = System.Drawing.Color.White;
            this.txtOwnerShare.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOwnerShare.Location = new System.Drawing.Point(120, 125);
            this.txtOwnerShare.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtOwnerShare.Name = "txtOwnerShare";
            this.txtOwnerShare.ReadOnly = true;
            this.txtOwnerShare.Size = new System.Drawing.Size(93, 23);
            this.txtOwnerShare.TabIndex = 6;
            this.txtOwnerShare.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblOwnerShare
            // 
            this.lblOwnerShare.AutoSize = true;
            this.lblOwnerShare.Location = new System.Drawing.Point(117, 107);
            this.lblOwnerShare.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOwnerShare.Name = "lblOwnerShare";
            this.lblOwnerShare.Size = new System.Drawing.Size(82, 15);
            this.lblOwnerShare.TabIndex = 5;
            this.lblOwnerShare.Text = "Công ty nhận:";
            // 
            // txtBaseFee
            // 
            this.txtBaseFee.BackColor = System.Drawing.Color.White;
            this.txtBaseFee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBaseFee.Location = new System.Drawing.Point(15, 125);
            this.txtBaseFee.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtBaseFee.Name = "txtBaseFee";
            this.txtBaseFee.ReadOnly = true;
            this.txtBaseFee.Size = new System.Drawing.Size(93, 23);
            this.txtBaseFee.TabIndex = 4;
            this.txtBaseFee.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblBaseFee
            // 
            this.lblBaseFee.AutoSize = true;
            this.lblBaseFee.Location = new System.Drawing.Point(12, 107);
            this.lblBaseFee.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBaseFee.Name = "lblBaseFee";
            this.lblBaseFee.Size = new System.Drawing.Size(66, 15);
            this.lblBaseFee.TabIndex = 3;
            this.lblBaseFee.Text = "Giá cơ bản:";
            // 
            // cmbVehicleType
            // 
            this.cmbVehicleType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVehicleType.FormattingEnabled = true;
            this.cmbVehicleType.Location = new System.Drawing.Point(118, 56);
            this.cmbVehicleType.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbVehicleType.Name = "cmbVehicleType";
            this.cmbVehicleType.Size = new System.Drawing.Size(198, 23);
            this.cmbVehicleType.TabIndex = 2;
            this.cmbVehicleType.SelectedIndexChanged += new System.EventHandler(this.cmbVehicleType_SelectedIndexChanged);
            // 
            // lblVehicleType
            // 
            this.lblVehicleType.AutoSize = true;
            this.lblVehicleType.Location = new System.Drawing.Point(12, 64);
            this.lblVehicleType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVehicleType.Name = "lblVehicleType";
            this.lblVehicleType.Size = new System.Drawing.Size(100, 15);
            this.lblVehicleType.TabIndex = 1;
            this.lblVehicleType.Text = "Loại phương tiện:";
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Location = new System.Drawing.Point(117, 9);
            this.txtEmployeeName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.ReadOnly = true;
            this.txtEmployeeName.Size = new System.Drawing.Size(198, 23);
            this.txtEmployeeName.TabIndex = 1;
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Location = new System.Drawing.Point(12, 17);
            this.lblEmployee.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(83, 15);
            this.lblEmployee.TabIndex = 0;
            this.lblEmployee.Text = "Tên nhân viên:";
            // 
            // btnExportToday
            // 
            this.btnExportToday.BackColor = System.Drawing.Color.White;
            this.btnExportToday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportToday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnExportToday.Location = new System.Drawing.Point(321, 10);
            this.btnExportToday.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnExportToday.Name = "btnExportToday";
            this.btnExportToday.Size = new System.Drawing.Size(157, 29);
            this.btnExportToday.TabIndex = 24;
            this.btnExportToday.Text = "Xuất Excel (Ngày)";
            this.btnExportToday.UseVisualStyleBackColor = false;
            this.btnExportToday.Click += new System.EventHandler(this.btnExportToday_Click);
            // 
            // todaysEntriesPanel
            // 
            this.todaysEntriesPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.todaysEntriesPanel.Controls.Add(this.lsvTodayEntries);
            this.todaysEntriesPanel.Location = new System.Drawing.Point(374, 148);
            this.todaysEntriesPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.todaysEntriesPanel.Name = "todaysEntriesPanel";
            this.todaysEntriesPanel.Size = new System.Drawing.Size(573, 602);
            this.todaysEntriesPanel.TabIndex = 2;
            // 
            // lsvTodayEntries
            // 
            this.lsvTodayEntries.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnTime,
            this.columnVehicle,
            this.columnEmployee,
            this.columnTotal,
            this.columnPaid,
            this.columnWashStatus});
            this.lsvTodayEntries.ContextMenuStrip = this.lsvContextMenu;
            this.lsvTodayEntries.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvTodayEntries.FullRowSelect = true;
            this.lsvTodayEntries.GridLines = true;
            this.lsvTodayEntries.HideSelection = false;
            this.lsvTodayEntries.Location = new System.Drawing.Point(0, 0);
            this.lsvTodayEntries.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lsvTodayEntries.Name = "lsvTodayEntries";
            this.lsvTodayEntries.Size = new System.Drawing.Size(571, 600);
            this.lsvTodayEntries.TabIndex = 0;
            this.lsvTodayEntries.UseCompatibleStateImageBehavior = false;
            this.lsvTodayEntries.View = System.Windows.Forms.View.Details;
            // 
            // columnTime
            // 
            this.columnTime.Text = "Time";
            this.columnTime.Width = 64;
            // 
            // columnVehicle
            // 
            this.columnVehicle.Text = "Vehicle";
            this.columnVehicle.Width = 80;
            // 
            // columnEmployee
            // 
            this.columnEmployee.Text = "Employee";
            this.columnEmployee.Width = 90;
            // 
            // columnTotal
            // 
            this.columnTotal.Text = "Total";
            this.columnTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnTotal.Width = 75;
            // 
            // columnPaid
            // 
            this.columnPaid.Text = "Paid";
            this.columnPaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnPaid.Width = 87;
            // 
            // columnWashStatus
            // 
            this.columnWashStatus.Text = "Wash Status";
            this.columnWashStatus.Width = 85;
            // 
            // lsvContextMenu
            // 
            this.lsvContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.togglePaidStatusToolStripMenuItem,
            this.toggleWashStatusToolStripMenuItem});
            this.lsvContextMenu.Name = "lsvContextMenu";
            this.lsvContextMenu.Size = new System.Drawing.Size(214, 48);
            // 
            // togglePaidStatusToolStripMenuItem
            // 
            this.togglePaidStatusToolStripMenuItem.Name = "togglePaidStatusToolStripMenuItem";
            this.togglePaidStatusToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.togglePaidStatusToolStripMenuItem.Text = "Thay đổi trạng thái Trả";
            this.togglePaidStatusToolStripMenuItem.Click += new System.EventHandler(this.TogglePaidStatus_Click);
            // 
            // toggleWashStatusToolStripMenuItem
            // 
            this.toggleWashStatusToolStripMenuItem.Name = "toggleWashStatusToolStripMenuItem";
            this.toggleWashStatusToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.toggleWashStatusToolStripMenuItem.Text = "Thay đổi trạng thái Rửa";
            this.toggleWashStatusToolStripMenuItem.Click += new System.EventHandler(this.ToggleWashStatus_Click);
            // 
            // dailySummaryPanel
            // 
            this.dailySummaryPanel.BackColor = System.Drawing.Color.White;
            this.dailySummaryPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dailySummaryPanel.Controls.Add(this.btnExportToday);
            this.dailySummaryPanel.Controls.Add(this.txtSummaryMostWashedVehicle);
            this.dailySummaryPanel.Controls.Add(this.lblSummaryMostWashedVehicle);
            this.dailySummaryPanel.Controls.Add(this.txtSummaryTotalWashes);
            this.dailySummaryPanel.Controls.Add(this.lblSummaryTotalWashes);
            this.dailySummaryPanel.Controls.Add(this.txtSummaryTotalEmpShare);
            this.dailySummaryPanel.Controls.Add(this.lblSummaryTotalEmpShare);
            this.dailySummaryPanel.Controls.Add(this.txtSummaryTotalOwnerShare);
            this.dailySummaryPanel.Controls.Add(this.lblSummaryTotalOwnerShare);
            this.dailySummaryPanel.Controls.Add(this.txtSummaryTotalRevenue);
            this.dailySummaryPanel.Controls.Add(this.lblSummaryTotalRevenue);
            this.dailySummaryPanel.Location = new System.Drawing.Point(955, 88);
            this.dailySummaryPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dailySummaryPanel.Name = "dailySummaryPanel";
            this.dailySummaryPanel.Size = new System.Drawing.Size(487, 193);
            this.dailySummaryPanel.TabIndex = 3;
            // 
            // txtSummaryMostWashedVehicle
            // 
            this.txtSummaryMostWashedVehicle.BackColor = System.Drawing.Color.White;
            this.txtSummaryMostWashedVehicle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSummaryMostWashedVehicle.Location = new System.Drawing.Point(268, 162);
            this.txtSummaryMostWashedVehicle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSummaryMostWashedVehicle.Name = "txtSummaryMostWashedVehicle";
            this.txtSummaryMostWashedVehicle.ReadOnly = true;
            this.txtSummaryMostWashedVehicle.Size = new System.Drawing.Size(210, 23);
            this.txtSummaryMostWashedVehicle.TabIndex = 10;
            this.txtSummaryMostWashedVehicle.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblSummaryMostWashedVehicle
            // 
            this.lblSummaryMostWashedVehicle.AutoSize = true;
            this.lblSummaryMostWashedVehicle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSummaryMostWashedVehicle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblSummaryMostWashedVehicle.Location = new System.Drawing.Point(265, 142);
            this.lblSummaryMostWashedVehicle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSummaryMostWashedVehicle.Name = "lblSummaryMostWashedVehicle";
            this.lblSummaryMostWashedVehicle.Size = new System.Drawing.Size(168, 15);
            this.lblSummaryMostWashedVehicle.TabIndex = 9;
            this.lblSummaryMostWashedVehicle.Text = "Phương tiện ưa chuộng nhất:";
            // 
            // txtSummaryTotalWashes
            // 
            this.txtSummaryTotalWashes.BackColor = System.Drawing.Color.White;
            this.txtSummaryTotalWashes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSummaryTotalWashes.Location = new System.Drawing.Point(18, 162);
            this.txtSummaryTotalWashes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSummaryTotalWashes.Name = "txtSummaryTotalWashes";
            this.txtSummaryTotalWashes.ReadOnly = true;
            this.txtSummaryTotalWashes.Size = new System.Drawing.Size(210, 23);
            this.txtSummaryTotalWashes.TabIndex = 8;
            this.txtSummaryTotalWashes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblSummaryTotalWashes
            // 
            this.lblSummaryTotalWashes.AutoSize = true;
            this.lblSummaryTotalWashes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSummaryTotalWashes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblSummaryTotalWashes.Location = new System.Drawing.Point(15, 142);
            this.lblSummaryTotalWashes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSummaryTotalWashes.Name = "lblSummaryTotalWashes";
            this.lblSummaryTotalWashes.Size = new System.Drawing.Size(65, 15);
            this.lblSummaryTotalWashes.TabIndex = 7;
            this.lblSummaryTotalWashes.Text = "Số lần rửa:";
            // 
            // txtSummaryTotalEmpShare
            // 
            this.txtSummaryTotalEmpShare.BackColor = System.Drawing.Color.White;
            this.txtSummaryTotalEmpShare.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSummaryTotalEmpShare.Location = new System.Drawing.Point(268, 96);
            this.txtSummaryTotalEmpShare.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSummaryTotalEmpShare.Name = "txtSummaryTotalEmpShare";
            this.txtSummaryTotalEmpShare.ReadOnly = true;
            this.txtSummaryTotalEmpShare.Size = new System.Drawing.Size(210, 23);
            this.txtSummaryTotalEmpShare.TabIndex = 6;
            this.txtSummaryTotalEmpShare.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblSummaryTotalEmpShare
            // 
            this.lblSummaryTotalEmpShare.AutoSize = true;
            this.lblSummaryTotalEmpShare.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSummaryTotalEmpShare.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblSummaryTotalEmpShare.Location = new System.Drawing.Point(265, 78);
            this.lblSummaryTotalEmpShare.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSummaryTotalEmpShare.Name = "lblSummaryTotalEmpShare";
            this.lblSummaryTotalEmpShare.Size = new System.Drawing.Size(96, 15);
            this.lblSummaryTotalEmpShare.TabIndex = 5;
            this.lblSummaryTotalEmpShare.Text = "Nhân viên nhận:";
            // 
            // txtSummaryTotalOwnerShare
            // 
            this.txtSummaryTotalOwnerShare.BackColor = System.Drawing.Color.White;
            this.txtSummaryTotalOwnerShare.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSummaryTotalOwnerShare.Location = new System.Drawing.Point(18, 96);
            this.txtSummaryTotalOwnerShare.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSummaryTotalOwnerShare.Name = "txtSummaryTotalOwnerShare";
            this.txtSummaryTotalOwnerShare.ReadOnly = true;
            this.txtSummaryTotalOwnerShare.Size = new System.Drawing.Size(210, 23);
            this.txtSummaryTotalOwnerShare.TabIndex = 4;
            this.txtSummaryTotalOwnerShare.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblSummaryTotalOwnerShare
            // 
            this.lblSummaryTotalOwnerShare.AutoSize = true;
            this.lblSummaryTotalOwnerShare.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSummaryTotalOwnerShare.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblSummaryTotalOwnerShare.Location = new System.Drawing.Point(15, 78);
            this.lblSummaryTotalOwnerShare.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSummaryTotalOwnerShare.Name = "lblSummaryTotalOwnerShare";
            this.lblSummaryTotalOwnerShare.Size = new System.Drawing.Size(91, 15);
            this.lblSummaryTotalOwnerShare.TabIndex = 3;
            this.lblSummaryTotalOwnerShare.Text = "Công ty thu về:";
            // 
            // txtSummaryTotalRevenue
            // 
            this.txtSummaryTotalRevenue.BackColor = System.Drawing.Color.White;
            this.txtSummaryTotalRevenue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSummaryTotalRevenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtSummaryTotalRevenue.Location = new System.Drawing.Point(18, 50);
            this.txtSummaryTotalRevenue.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSummaryTotalRevenue.Name = "txtSummaryTotalRevenue";
            this.txtSummaryTotalRevenue.ReadOnly = true;
            this.txtSummaryTotalRevenue.Size = new System.Drawing.Size(210, 20);
            this.txtSummaryTotalRevenue.TabIndex = 2;
            this.txtSummaryTotalRevenue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblSummaryTotalRevenue
            // 
            this.lblSummaryTotalRevenue.AutoSize = true;
            this.lblSummaryTotalRevenue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSummaryTotalRevenue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblSummaryTotalRevenue.Location = new System.Drawing.Point(15, 32);
            this.lblSummaryTotalRevenue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSummaryTotalRevenue.Name = "lblSummaryTotalRevenue";
            this.lblSummaryTotalRevenue.Size = new System.Drawing.Size(97, 15);
            this.lblSummaryTotalRevenue.TabIndex = 1;
            this.lblSummaryTotalRevenue.Text = "Tổng doanh thu:";
            // 
            // lblDailySummary
            // 
            this.lblDailySummary.AutoSize = true;
            this.lblDailySummary.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblDailySummary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblDailySummary.Location = new System.Drawing.Point(951, 65);
            this.lblDailySummary.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDailySummary.Name = "lblDailySummary";
            this.lblDailySummary.Size = new System.Drawing.Size(170, 20);
            this.lblDailySummary.TabIndex = 0;
            this.lblDailySummary.Text = "Doanh Thu trong Ngày";
            // 
            // txtEmployeeToSearch
            // 
            this.txtEmployeeToSearch.Location = new System.Drawing.Point(375, 70);
            this.txtEmployeeToSearch.Name = "txtEmployeeToSearch";
            this.txtEmployeeToSearch.Size = new System.Drawing.Size(148, 23);
            this.txtEmployeeToSearch.TabIndex = 5;
            this.txtEmployeeToSearch.Text = "";
            // 
            // cmbVehicleToSearch
            // 
            this.cmbVehicleToSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVehicleToSearch.FormattingEnabled = true;
            this.cmbVehicleToSearch.Items.AddRange(new object[] {
            "All"});
            this.cmbVehicleToSearch.Location = new System.Drawing.Point(540, 70);
            this.cmbVehicleToSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbVehicleToSearch.Name = "cmbVehicleToSearch";
            this.cmbVehicleToSearch.Size = new System.Drawing.Size(123, 23);
            this.cmbVehicleToSearch.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(372, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 15);
            this.label1.TabIndex = 24;
            this.label1.Text = "Tên nhân viên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(537, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 15);
            this.label2.TabIndex = 24;
            this.label2.Text = "Loại phương tiện:";
            // 
            // txtMinPriceToSearch
            // 
            this.txtMinPriceToSearch.BackColor = System.Drawing.Color.White;
            this.txtMinPriceToSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMinPriceToSearch.Location = new System.Drawing.Point(373, 119);
            this.txtMinPriceToSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMinPriceToSearch.Name = "txtMinPriceToSearch";
            this.txtMinPriceToSearch.Size = new System.Drawing.Size(103, 23);
            this.txtMinPriceToSearch.TabIndex = 24;
            // 
            // txtMaxPriceToSearch
            // 
            this.txtMaxPriceToSearch.BackColor = System.Drawing.Color.White;
            this.txtMaxPriceToSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaxPriceToSearch.Location = new System.Drawing.Point(497, 119);
            this.txtMaxPriceToSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMaxPriceToSearch.Name = "txtMaxPriceToSearch";
            this.txtMaxPriceToSearch.Size = new System.Drawing.Size(115, 23);
            this.txtMaxPriceToSearch.TabIndex = 25;
            // 
            // cmbPaidStatus
            // 
            this.cmbPaidStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPaidStatus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbPaidStatus.FormattingEnabled = true;
            this.cmbPaidStatus.Items.AddRange(new object[] {
            "All",
            "Yes",
            "No"});
            this.cmbPaidStatus.Location = new System.Drawing.Point(620, 118);
            this.cmbPaidStatus.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbPaidStatus.Name = "cmbPaidStatus";
            this.cmbPaidStatus.Size = new System.Drawing.Size(69, 23);
            this.cmbPaidStatus.TabIndex = 24;
            // 
            // cmbWashStatus
            // 
            this.cmbWashStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWashStatus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbWashStatus.FormattingEnabled = true;
            this.cmbWashStatus.Items.AddRange(new object[] {
            "All",
            "Completed",
            "Ongoing"});
            this.cmbWashStatus.Location = new System.Drawing.Point(697, 119);
            this.cmbWashStatus.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbWashStatus.Name = "cmbWashStatus";
            this.cmbWashStatus.Size = new System.Drawing.Size(69, 23);
            this.cmbWashStatus.TabIndex = 26;
            // 
            // dateToSearch
            // 
            this.dateToSearch.Location = new System.Drawing.Point(680, 70);
            this.dateToSearch.Name = "dateToSearch";
            this.dateToSearch.Size = new System.Drawing.Size(221, 23);
            this.dateToSearch.TabIndex = 27;
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnFilter.FlatAppearance.BorderSize = 0;
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.ForeColor = System.Drawing.Color.White;
            this.btnFilter.Location = new System.Drawing.Point(774, 107);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(85, 35);
            this.btnFilter.TabIndex = 24;
            this.btnFilter.Text = "Lọc tìm kiếm";
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(677, 52);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 28;
            this.label3.Text = "Thời gian:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(372, 99);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 15);
            this.label4.TabIndex = 29;
            this.label4.Text = "Giá MIN:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(507, 99);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 15);
            this.label5.TabIndex = 30;
            this.label5.Text = "Giá MAX:";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(867, 107);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(79, 36);
            this.btnRefresh.TabIndex = 31;
            this.btnRefresh.Text = "Làm mới";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(620, 100);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 15);
            this.label6.TabIndex = 32;
            this.label6.Text = "Đã trả?";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(693, 99);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 15);
            this.label7.TabIndex = 33;
            this.label7.Text = "Đã rửa?";
            // 
            // pchVehicles
            // 
            this.pchVehicles.Location = new System.Drawing.Point(1015, 327);
            this.pchVehicles.Name = "pchVehicles";
            this.pchVehicles.Size = new System.Drawing.Size(385, 443);
            this.pchVehicles.TabIndex = 35;
            this.pchVehicles.Text = "pieChart2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label8.Location = new System.Drawing.Point(955, 284);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(241, 20);
            this.label8.TabIndex = 36;
            this.label8.Text = "Live data: Most common vehicles";
            // 
            // DashboardForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1455, 762);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pchVehicles);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.dateToSearch);
            this.Controls.Add(this.cmbWashStatus);
            this.Controls.Add(this.cmbPaidStatus);
            this.Controls.Add(this.txtMaxPriceToSearch);
            this.Controls.Add(this.txtMinPriceToSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbVehicleToSearch);
            this.Controls.Add(this.txtEmployeeToSearch);
            this.Controls.Add(this.dailySummaryPanel);
            this.Controls.Add(this.todaysEntriesPanel);
            this.Controls.Add(this.washEntryPanel);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.lblDailySummary);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = true;
            this.MinimizeBox = true;
            this.Name = "DashboardForm";
            this.Text = "Car Wash Management - Daily Dashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DashboardForm_FormClosed);
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.washEntryPanel.ResumeLayout(false);
            this.washEntryPanel.PerformLayout();
            this.todaysEntriesPanel.ResumeLayout(false);
            this.lsvContextMenu.ResumeLayout(false);
            this.dailySummaryPanel.ResumeLayout(false);
            this.dailySummaryPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel headerPanel;
        private Label welcomeLabel;
        private Button logoutButton;
        private Button btnChangePassword;
        private MenuStrip mainMenu;
        private ToolStripMenuItem adminMenuItem;
        private ToolStripMenuItem manageUsersToolStripMenuItem;
        private ToolStripMenuItem manageVehiclesToolStripMenuItem;
        private ToolStripMenuItem manageServicesToolStripMenuItem;
        private ToolStripMenuItem manageExpensesToolStripMenuItem;
        private ToolStripMenuItem monthlyYearlyReportToolStripMenuItem;
        private ToolStripMenuItem viewChartsToolStripMenuItem;
        private Panel washEntryPanel;
        private TextBox txtEmployeeName;
        private Label lblEmployee;
        private ComboBox cmbVehicleType;
        private Label lblVehicleType;
        private TextBox txtBaseFee;
        private Label lblBaseFee;
        private TextBox txtEmployeeShare;
        private Label lblEmployeeShare;
        private TextBox txtOwnerShare;
        private Label lblOwnerShare;
        private Panel servicePanel;
        private Label lblAdditionalServices;
        private TextBox txtServiceEmpShare;
        private Label lblServiceEmpShare;
        private TextBox txtServiceOwnerShare;
        private Label lblServiceOwnerShare;
        private TextBox txtTotalServiceFee;
        private Label lblTotalServiceFee;
        private CheckBox chkIsPaid;
        private CheckBox chkWashStatus;
        private ComboBox cmbDiscount;
        private Label lblDiscount;
        private TextBox txtTotalAmount;
        private Label lblTotalAmount;
        private Button btnAddTransaction;
        private Button btnExportToday;
        private Panel todaysEntriesPanel;
        private ListView lsvTodayEntries;
        private ColumnHeader columnTime;
        private ColumnHeader columnVehicle;
        private ColumnHeader columnEmployee;
        private ColumnHeader columnTotal;
        private ColumnHeader columnPaid;
        private ColumnHeader columnWashStatus;
        private ContextMenuStrip lsvContextMenu;
        private ToolStripMenuItem togglePaidStatusToolStripMenuItem;
        private ToolStripMenuItem toggleWashStatusToolStripMenuItem;
        private Panel dailySummaryPanel;
        private TextBox txtSummaryMostWashedVehicle;
        private Label lblSummaryMostWashedVehicle;
        private TextBox txtSummaryTotalWashes;
        private Label lblSummaryTotalWashes;
        private TextBox txtSummaryTotalEmpShare;
        private Label lblSummaryTotalEmpShare;
        private TextBox txtSummaryTotalOwnerShare;
        private Label lblSummaryTotalOwnerShare;
        private TextBox txtSummaryTotalRevenue;
        private Label lblSummaryTotalRevenue;
        private Label lblDailySummary;
        private RichTextBox txtEmployeeToSearch;
        private ComboBox cmbVehicleToSearch;
        private Label label1;
        private Label label2;
        private TextBox txtMinPriceToSearch;
        private TextBox txtMaxPriceToSearch;
        private ComboBox cmbPaidStatus;
        private ComboBox cmbWashStatus;
        private DateTimePicker dateToSearch;
        private Button btnFilter;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnRefresh;
        private Label label6;
        private Label label7;
        private LiveCharts.WinForms.PieChart pchVehicles;
        private Label label8;
    }
}