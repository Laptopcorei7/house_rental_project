using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace RentalProject
{
    public partial class LoginFile : Form
    {


        public LoginFile()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_showPass_CheckedChanged(object sender, EventArgs e)
        {
            login_password.PasswordChar = login_showPass.Checked ? '\0' : '*';
        }

        // This login form lives for the whole session: it hides while a main form is open
        // and comes back when that form closes (logout), so no hidden forms pile up.
        private void OpenMainForm(Form mainForm)
        {
            login_password.Text = "";
            mainForm.FormClosed += (sender, e) =>
            {
                if (e.CloseReason != CloseReason.ApplicationExitCall)
                {
                    Show();
                }
            };
            mainForm.Show();
            Hide();
        }

        private bool IsValidEmail(string email)
        {
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, emailPattern);
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            if (login_email.Text == "" || login_password.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!IsValidEmail(login_email.Text))
            {
                MessageBox.Show("Please enter a valid email address.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                int userId = 0;
                string? storedPassword = null, userRole = null;

                using (SqlConnection connect = new SqlConnection(Db.ConnectionString))
                {
                    connect.Open();
                    Passwords.HashPlainTextPasswords(connect);

                    string selectData = "SELECT id, password, role FROM users WHERE email = @userEmail AND status = 'Active'";
                    using SqlCommand cmd = new SqlCommand(selectData, connect);
                    cmd.Parameters.AddWithValue("@userEmail", login_email.Text.Trim());

                    using SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        userId = reader.GetInt32(0);
                        storedPassword = reader.GetString(1);
                        userRole = reader.GetString(2);
                    }
                }

                // Same message for a wrong email and a wrong password, so it doesn't reveal which accounts exist.
                if (storedPassword == null || !Passwords.Verify(login_password.Text, storedPassword))
                {
                    MessageBox.Show("Incorrect Email or Password", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Session.UserId = userId;
                if (userRole == "Admin")
                {
                    OpenMainForm(new AdminMainForm());
                }
                else if (userRole == "Staff")
                {
                    OpenMainForm(new staffMainForm());
                }
            }
        }
    }
}
