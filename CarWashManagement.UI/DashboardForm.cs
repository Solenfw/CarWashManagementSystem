using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using CarWashManagement.Core.Managers;
using CarWashManagement.Core.FileHandlers;
using CarWashManagement.Core.Enums;
using CarWashManagement.Core;

namespace CarWashManagement.UI
{
    public class DashboardForm : BaseForm
    {
        private readonly User loggedInUser;

        // Declaration of manager instances.
        private readonly CarManager carManager;
        private readonly TransactionManager transactionManager;

        // Declaration of data lists.
        private List<Vehicle> vehicleTypes;
        private List<Service> services;

        // Declaration of header controls.
        private Label welcomeLabel;
        private Button logoutButton;

        // Declaration of panels for layout.
        private Panel washEntryPanel;
        private Panel todaysEntriesPanel;
        private Panel dailySummaryPanel;

        // Declaration of Wash Entry Controls.
        private Label lblEmployee;
        private TextBox txtEmployeeName;
        private Label lblVehicleType;
        private ComboBox cmbVehicleType; // Dropdown for vehicle types.
        private Label lblBaseFee;
        private TextBox txtBaseFee;
        private Label lblOwnerShare;
        private TextBox txtOwnerShare;
        private Label lblEmployeeShare;
        private TextBox txtEmployeeShare;
        private Label lblAdditionalServices;
        private CheckBox chkIsPaid;
        private Button btnAddTransaction;
        private Label lblTotalAmount;
        private TextBox txtTotalAmount;
        private List<Control> serviceControls = new List<Control>(); // To hold created service checkboxes and fee textboxes.

        public DashboardForm(User loggedInUser)
        {
            this.loggedInUser = loggedInUser;

            // Initialize manager instances.
            carManager = new CarManager(
                new VehicleFileHandler(),
                new ServiceFileHandler()
                );
            transactionManager = new TransactionManager(
                new TransactionFileHandler()
                );

            // Load data lists.
            vehicleTypes = carManager.GetVehicleTypes();
            services = carManager.GetServices();

            SetUpControls();
            LoadVehicleComboBox();
            LoadServiceControls();
        }

        private void SetUpControls()
        {
            // - - - - - Form set up - - - - -
            Text = "Car Wash Management - Daily Dashboard";
            Size = new Size(800, 600);

            // - - - - - Welcome Label - - - - -
            welcomeLabel = new Label();
            welcomeLabel.Text = $"Welcome, {loggedInUser.FullName} ({loggedInUser.Role})";
            welcomeLabel.Location = new Point(10, 10);
            welcomeLabel.AutoSize = true; // Makes label resize to fit text
            Controls.Add(welcomeLabel);

            // - - - - - Logout Button - - - - -
            logoutButton = new Button();
            logoutButton.Text = "Logout";
            logoutButton.Location = new Point(ClientSize.Width - 85, 10);
            logoutButton.Size = new Size(75, 30);
            logoutButton.Click += LogoutButton_Click;
            Controls.Add(logoutButton);

            // - - - - - Wash Entry Panel - - - - -
            washEntryPanel = new Panel();
            washEntryPanel.Location = new Point(10, 50);
            washEntryPanel.Size = new Size(300, 500);
            washEntryPanel.BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(washEntryPanel);

            // --- Employee Name ---
            int currentY = 15;
            lblEmployee = new Label();
            lblEmployee.Text = "Employee Name:";
            lblEmployee.Location = new Point(10, currentY);
            lblEmployee.AutoSize = true;
            washEntryPanel.Controls.Add(lblEmployee);

            txtEmployeeName = new TextBox();
            txtEmployeeName.Location = new Point(110, currentY - 3);
            txtEmployeeName.Size = new Size(170, 23);
            washEntryPanel.Controls.Add(txtEmployeeName);

            currentY += 35;

            // --- Vehicle Type ---
            lblVehicleType = new Label();
            lblVehicleType.Text = "Vehicle Type:";
            lblVehicleType.Location = new Point(10, currentY);
            lblVehicleType.AutoSize = true;
            washEntryPanel.Controls.Add(lblVehicleType);

            cmbVehicleType = new ComboBox();
            cmbVehicleType.Location = new Point(110, currentY - 3);
            cmbVehicleType.Size = new Size(170, 23);
            cmbVehicleType.DropDownStyle = ComboBoxStyle.DropDownList; // Prevents user from typing
            cmbVehicleType.SelectedIndexChanged += cmbVehicleType_SelectedIndexChanged;
            washEntryPanel.Controls.Add(cmbVehicleType);

            currentY += 35;

            // --- Base Fee ---
            lblBaseFee = new Label();
            lblBaseFee.Text = "Base Fee:";
            lblBaseFee.Location = new Point(10, currentY);
            lblBaseFee.AutoSize = true;
            washEntryPanel.Controls.Add(lblBaseFee);

            txtBaseFee = new TextBox();
            txtBaseFee.Location = new Point(10, currentY + 20);
            txtBaseFee.Size = new Size(80, 23);
            txtBaseFee.ReadOnly = true; // Base fee is auto-filled based on vehicle type
            txtBaseFee.TextAlign = HorizontalAlignment.Right;
            washEntryPanel.Controls.Add(txtBaseFee);

            // --- Owner Share ---
            lblOwnerShare = new Label();
            lblOwnerShare.Text = "Owner Share:";
            lblOwnerShare.Location = new Point(100, currentY);
            lblOwnerShare.AutoSize = true;
            washEntryPanel.Controls.Add(lblOwnerShare);

            txtOwnerShare = new TextBox();
            txtOwnerShare.Location = new Point(100, currentY + 20);
            txtOwnerShare.Size = new Size(80, 23);
            txtOwnerShare.ReadOnly = true; // Owner share is auto-filled based on vehicle type
            txtOwnerShare.TextAlign = HorizontalAlignment.Right;
            washEntryPanel.Controls.Add(txtOwnerShare);

            // --- Employee Share ---
            lblEmployeeShare = new Label();
            lblEmployeeShare.Text = "Employee Share:";
            lblEmployeeShare.Location = new Point(190, currentY);
            lblEmployeeShare.AutoSize = true;
            washEntryPanel.Controls.Add(lblEmployeeShare);

            txtEmployeeShare = new TextBox();
            txtEmployeeShare.Location = new Point(190, currentY + 20);
            txtEmployeeShare.Size = new Size(80, 23);
            txtEmployeeShare.ReadOnly = true; // Employee share is auto-filled based on vehicle type.
            txtEmployeeShare.TextAlign = HorizontalAlignment.Right;
            washEntryPanel.Controls.Add(txtEmployeeShare);

            currentY += 60;

            // --- Additional Services ---
            lblAdditionalServices = new Label();
            lblAdditionalServices.Text = "Additional Services:";
            lblAdditionalServices.Location = new Point(10, currentY);
            lblAdditionalServices.Font = new Font(Font, FontStyle.Bold);
            lblAdditionalServices.AutoSize = true;
            washEntryPanel.Controls.Add(lblAdditionalServices);

            currentY += 30;

            // --- Placeholder for Dynamic Services ---
            // Method to be added.

            // --- Is Paid Checkbox ---
            chkIsPaid = new CheckBox();
            chkIsPaid.Text = "Employee paid owner's share?";
            chkIsPaid.Location = new Point(10, washEntryPanel.Height -100);
            chkIsPaid.AutoSize = true;
            washEntryPanel.Controls.Add(chkIsPaid);

            // --- Total Amount ---
            lblTotalAmount = new Label();
            lblTotalAmount.Text = "Total Amount:";
            lblTotalAmount.Location = new Point(10, washEntryPanel.Height - 60);
            lblTotalAmount.Font = new Font(Font, FontStyle.Bold);
            lblTotalAmount.AutoSize = true;
            washEntryPanel.Controls.Add(lblTotalAmount);

            txtTotalAmount = new TextBox();
            txtTotalAmount.Location = new Point(110, washEntryPanel.Height - 63);
            txtTotalAmount.Size = new Size(170, 23);
            txtTotalAmount.ReadOnly = true; // Total amount is auto-calculated
            txtTotalAmount.Font = new Font(Font, FontStyle.Bold);
            txtTotalAmount.TextAlign = HorizontalAlignment.Right;
            washEntryPanel.Controls.Add(txtTotalAmount);

            // --- Add Transaction Button ---
            btnAddTransaction = new Button();
            btnAddTransaction.Text = "Add Entry";
            btnAddTransaction.Location = new Point(10, washEntryPanel.Height - 35);
            btnAddTransaction.Size = new Size(270, 25);
            washEntryPanel.Controls.Add(btnAddTransaction);

            // - - - - - Today's Entry Panel - - - - -
            todaysEntriesPanel = new Panel();
            todaysEntriesPanel.Location = new Point(320, 50);
            todaysEntriesPanel.Size = new Size(450, 250);
            todaysEntriesPanel.BorderStyle = BorderStyle.FixedSingle;
            todaysEntriesPanel.Controls.Add(new Label { Text = "Today's Entries Area", Location = new Point(10, 10) });
            this.Controls.Add(todaysEntriesPanel);

            // - - - - - Daily Summary Panel - - - - -
            dailySummaryPanel = new Panel();
            dailySummaryPanel.Location = new Point(320, 310);
            dailySummaryPanel.Size = new Size(450, 240);
            dailySummaryPanel.BorderStyle = BorderStyle.FixedSingle;
            dailySummaryPanel.Controls.Add(new Label { Text = "Daily Summary Area", Location = new Point(10, 10) });
            this.Controls.Add(dailySummaryPanel);
        }

        // Method to load the vehicle types in the dropdown combo box.
        private void LoadVehicleComboBox()
        {
            // ComboBox configuration
            cmbVehicleType.DataSource = vehicleTypes;
            cmbVehicleType.DisplayMember = "Type";
            cmbVehicleType.ValueMember = "Type";
            cmbVehicleType.SelectedIndex = -1; // Start with no selection.

        }

        // Method to load the service controls.
        private void LoadServiceControls()
        {
            int currentY = 180;

            foreach(Control c in serviceControls)
            {
                washEntryPanel.Controls.Remove(c);
            }
            serviceControls.Clear();

            foreach(Service service in services)
            {
                // Create the CheckBox.
                CheckBox chk = new CheckBox();
                chk.Text = service.Name;
                chk.Location = new Point(10, currentY);
                chk.AutoSize = true;
                chk.Tag = service; // Store the service object in the tag.
                chk.CheckedChanged += ServiceCheckbox_CheckedChanged;
                washEntryPanel.Controls.Add(chk);
                serviceControls.Add(chk);

                // Create the Textbox
                TextBox txt = new TextBox();
                txt.Location = new Point(190, currentY - 3);
                txt.Size = new Size(80, 23);
                txt.Enabled = false;
                txt.Tag = service; // Store the service object in the tag.
                washEntryPanel.Controls.Add(txt);
                serviceControls.Add(txt);

                if (service.PricingType == ServicePricingType.ManualInput)
                {
                    txt.Text = "0.00";
                    txt.ReadOnly = false; // Allow user input.
                    txt.Enabled = false; // Initially disabled until checkbox is checked.
                    txt.TextChanged += ServiceTextBox_TextChanged;
                    txt.TextAlign = HorizontalAlignment.Right;

                } else if (service.PricingType == ServicePricingType.FixedPrice)
                {
                    txt.Text = service.Fee.ToString("N2");
                    txt.ReadOnly = true;
                    txt.Enabled = false; // Initially disabled until checkbox is checked.
                    txt.TextAlign = HorizontalAlignment.Right;
                } 
                else if (service.PricingType == ServicePricingType.VehicleBaseFeeMultiplier)
                {
                    txt.Text = "0.00"; // Will be calculated based on vehicle base fee.
                    txt.ReadOnly = true;
                    txt.Enabled = false; // Initially disabled until checkbox is checked.
                    txt.TextAlign = HorizontalAlignment.Right;
                }

                currentY += 30;
            }
        }

        // Method to update the total amount based on selected services and vehicle type.
        private void UpdateTotalAmount()
        {
            Vehicle selectedVehicle = cmbVehicleType.SelectedItem as Vehicle;
            decimal baseFee = 0.00m;

            if (selectedVehicle != null)
            {
                baseFee = selectedVehicle.BaseFee;
            }

            decimal servicesTotal = 0.00m;

            // Iterate through service controls to calculate total.
            foreach (Control control in serviceControls)
            {
                // Only process checked services.
                if (control is CheckBox chk && chk.Checked)
                {
                    Service service = chk.Tag as Service;
                    if (service == null) { continue; }

                    // Find the corresponding textbox for this service.
                    TextBox txt = serviceControls.FirstOrDefault(c => c is TextBox && c.Tag == service) as TextBox;

                    switch (service.PricingType)
                    {
                        case ServicePricingType.FixedPrice:
                            servicesTotal += service.Fee;
                            break;
                        case ServicePricingType.ManualInput:
                            if (txt != null && decimal.TryParse(txt.Text, out decimal manualFee))
                            {
                                servicesTotal += manualFee;
                            }
                            break;
                        case ServicePricingType.VehicleBaseFeeMultiplier:
                            decimal serviceFee = baseFee * service.Multiplier;
                            txt.Text = serviceFee.ToString("N2");
                            servicesTotal += serviceFee;
                            break;
                    }
                }
            }

            decimal totalAmount = baseFee + servicesTotal;
            txtTotalAmount.Text = totalAmount.ToString("N2");
        }

        // Method that allow users to logout from the main dashboard.
        private void LogoutButton_Click(object sender, EventArgs e)
        {
            DialogResult isLogout = MessageBox.Show("Are you sure you want to log out?", "Logout?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (isLogout == DialogResult.Yes)
            {
                Form loginForm = Application.OpenForms["LoginForm"];

                if (loginForm != null)
                {
                    // Clear textboxes on login form.
                    ((LoginForm)loginForm).ClearFields();
                    loginForm.Show();

                    Close();
                }
                else
                {
                    Application.Exit();
                }
            }
        }

        // Method to handle vehicle type selection change.
        private void cmbVehicleType_SelectedIndexChanged(object sender, EventArgs e)
        {
            Vehicle selectedVehicle = cmbVehicleType.SelectedItem as Vehicle;
            decimal baseFee = 0.00m;

            if (selectedVehicle != null)
            {
                baseFee = selectedVehicle.BaseFee;
                txtBaseFee.Text = selectedVehicle.BaseFee.ToString("N2");
                txtOwnerShare.Text = selectedVehicle.OwnerShare.ToString("N2");
                txtEmployeeShare.Text = selectedVehicle.EmployeeShare.ToString("N2");
            }
            else
            {
                // Clear the fee textboxes if no vehicle is selected.
                txtBaseFee.Clear();
                txtOwnerShare.Clear();
                txtEmployeeShare.Clear();
            }

            foreach (Control control in serviceControls)
            {
                if (control is TextBox txt)
                {
                    Service service = txt.Tag as Service;
                    if (service != null && service.PricingType == ServicePricingType.VehicleBaseFeeMultiplier)
                    {
                        decimal serviceFee = baseFee * service.Multiplier;
                        txt.Text = serviceFee.ToString("N2");
                    }
                }
            }

            // Recalculate total if the selected vehicle is changed.
            // Because services with pricing type "VehicleBaseFeeMultiplier" depends on the vehicle's base fee. 
            UpdateTotalAmount();
        }

        // Method to handle services checkbox state changes.
        private void ServiceCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chk = sender as CheckBox;
            Service service = chk.Tag as Service;

            // Find the corresponding textbox for this service.
            TextBox txt = serviceControls.FirstOrDefault(c => c is TextBox && c.Tag == service) as TextBox;
            
            if (service.PricingType == ServicePricingType.ManualInput)
            {
                txt.Enabled = chk.Checked;
                if (!chk.Checked)
                {
                    txt.Text = "0.00";
                }
            } else if (service.PricingType == ServicePricingType.VehicleBaseFeeMultiplier)
            {
                txt.Enabled = chk.Checked;

            } else if (service.PricingType == ServicePricingType.ManualInput)
            {
                txt.Enabled = chk.Checked;
            }

            // Recalculate total amount whenever a service checkbox is ticked.
            UpdateTotalAmount();
        }

        // Method to update the total amount when the text changes in a service textbox manual input.
        private void ServiceTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateTotalAmount();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            Form loginForm = Application.OpenForms["LoginForm"];

            if (loginForm != null)
            {
                // Clear textboxes on login form.
                ((LoginForm)loginForm).ClearFields();
                loginForm.Show();
            }
  
            base.OnFormClosed(e);
        }
    }
}
