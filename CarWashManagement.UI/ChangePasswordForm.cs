using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarWashManagement.Core;
using CarWashManagement.Core.Managers;
using CarWashManagement.Core.FileHandlers;

namespace CarWashManagement.UI
{
    public class ChangePasswordForm : BaseForm
    {
        private Label lblOldPassword;
        private TextBox txtOldPassword;
        private Label lblNewPassword;
        private TextBox txtNewPassword;
        private Label lblConfirmPassword;
        private TextBox txtConfirmPassword;
        private Button btnSubmit;
        private Button btnCancel;

        private readonly AccountManager accountManager;
        private readonly User loggedInUser;

        public ChangePasswordForm(User user)
        {
            loggedInUser = user;

            accountManager = new AccountManager(
                new UserFileHandler(),
                new AuditFileHandler()
            );

            SetUpControls();
        }

        // Method to setup UI.
        public void SetUpControls()
        {
            Text = "Change Password";
            Size = new Size(300, 280);

            int currentY = 20;

            // --- Old Password ---
            lblOldPassword = new Label 
            { 
                Text = "Old Password:", 
                Location = new Point(15, currentY), 
                AutoSize = true 
            };

            txtOldPassword = new TextBox 
            { 
                Location = new Point(15, currentY + 20), 
                Size = new Size(250, 23), 
                PasswordChar = '*' 
            };

            currentY += 55;

            // --- New Password ---
            lblNewPassword = new Label 
            { 
                Text = "New Password:", 
                Location = new Point(15, currentY), 
                AutoSize = true 
            };

            txtNewPassword = new TextBox 
            { 
                Location = new Point(15, currentY + 20), 
                Size = new Size(250, 23), 
                PasswordChar = '*' 
            };

            currentY += 55;

            // --- Confirm Password ---
            lblConfirmPassword = new Label 
            { 
                Text = "Confirm New Password:", 
                Location = new Point(15, currentY), 
                AutoSize = true 
            };
            txtConfirmPassword = new TextBox 
            { 
                Location = new Point(15, currentY + 20), 
                Size = new Size(250, 23), 
                PasswordChar = '*' 
            };
            currentY += 55;

            // --- Submit Button ---
            btnSubmit = new Button 
            { 
                Text = "Submit", 
                Location = new Point(110, currentY + 10), 
                Size = new Size(75, 25) 
            };
            btnSubmit.Click += btnSubmit_Click;

            // --- Cancel Button ---
            btnCancel = new Button 
            { 
                Text = "Cancel", 
                Location = new Point(190, currentY + 10), 
                Size = new Size(75, 25) 
            };
            btnCancel.Click += (sender, e) => { this.Close(); }; // Close this dialog.

            Controls.Add(lblOldPassword);
            Controls.Add(txtOldPassword);
            Controls.Add(lblNewPassword);
            Controls.Add(txtNewPassword);
            Controls.Add(lblConfirmPassword);
            Controls.Add(txtConfirmPassword);
            Controls.Add(btnSubmit);
            Controls.Add(btnCancel);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string oldPassword = txtOldPassword.Text;
            string newPassword = txtNewPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            // Check if the inputs are null or whitespace.
            if (string.IsNullOrWhiteSpace(oldPassword) || string.IsNullOrWhiteSpace(newPassword) || string.IsNullOrWhiteSpace(confirmPassword))
            {
                MessageBox.Show("All fields are required.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool hasUpper = newPassword.Any(char.IsUpper);
            bool hasLower = newPassword.Any(char.IsLower);
            bool hasDigit = newPassword.Any(char.IsDigit);

            // Check password if it satisfy the requierments.
            if (newPassword.Length < 8 || !hasUpper || !hasLower || !hasDigit)
            {
                string message = "Password must meet the following requirements:\n" +
                                 "• At least 8 characters long\n" +
                                 "• Contains at least one uppercase letter\n" +
                                 "• Contains at least one lowercase letter\n" +
                                 "• Contains at least one digit\n";

                MessageBox.Show(message, "Password Requirements", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Check if new password matches the confirm password.
            if (newPassword != confirmPassword)
            {
                MessageBox.Show("The new passwords do not match.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool success = accountManager.ChangePassword(loggedInUser.Username, oldPassword, newPassword);

            if (success)
            {
                MessageBox.Show("Password changed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close(); // Close this form.
            }
            else
            {
                MessageBox.Show("The 'Old Password' was incorrect. Please try again.", "Authentication Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtOldPassword.Clear();
                txtOldPassword.Focus();
            }
        }
    }
}
