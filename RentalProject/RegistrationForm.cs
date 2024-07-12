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

namespace RentalProject
{
	public partial class RegistrationForm : Form
	{
		private string conn = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Buabe\\OneDrive\\Documents\\house.mdf;Integrated Security=True;Connect Timeout=30";
		public RegistrationForm()
		{
			InitializeComponent();
		}

		private void signup_showPass_CheckedChanged(object sender, EventArgs e)
		{
			signup_password.PasswordChar = signup_showPass.Checked ? '\0' : '*';
			signup_confirmPass.PasswordChar = signup_showPass.Checked ? '\0' : '*';
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void Close_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void signup_signInBtn_Click(object sender, EventArgs e)
		{
			LoginFile loginForm = new LoginFile();
			loginForm.Show();

			this.Hide();
		}

		private void signup_btn_Click(object sender, EventArgs e)
		{
			if (signup_email.Text == "" || signup_password.Text == "" || signup_confirmPass.Text == "")
			{
				MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				using (SqlConnection connect = new SqlConnection(conn))
				{
					connect.Open();

					string checkEmail = "SELECT email FROM users WHERE email = @userEmail";

					using (SqlCommand checkE = new SqlCommand(checkEmail, connect))
					{
						checkE.Parameters.AddWithValue("@userEmail", signup_email.Text.Trim());

						SqlDataAdapter adapter = new SqlDataAdapter(checkE);
						DataTable table = new DataTable();
						adapter.Fill(table);

						if (table.Rows.Count != 0)
						{
							string tempEmail = signup_email.Text.Substring(0, 1).ToUpper() + signup_email.Text.Substring(1);
							MessageBox.Show($"{tempEmail} already exists", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}else if(signup_password.Text.Length < 8)
						{
							MessageBox.Show("Invalid Password", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
						else if(signup_password.Text != signup_confirmPass.Text)
						{
							MessageBox.Show("Password doesn't match", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
						else
						{
							string query = "INSERT INTO users (email, password, role, status, date_registered)" +
								"VALUES(@userEmail, @pass, @role, @status, @regDate)";

							using(SqlCommand cmd  = new SqlCommand(query, connect))
							{
								cmd.Parameters.AddWithValue("@userEmail", signup_email.Text.Trim());
								cmd.Parameters.AddWithValue("@pass", signup_password.Text.Trim());
								cmd.Parameters.AddWithValue("@role", "Staff");
								cmd.Parameters.AddWithValue("@status", "Active");

								DateTime today = DateTime.Today;
								cmd.Parameters.AddWithValue("@regDate", today);

								cmd.ExecuteNonQuery();

								MessageBox.Show("Registered Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);


								LoginFile loginForm = new LoginFile();
								loginForm.Show();

								this.Hide();

							}
						}
					}

				}

			}
		}
	}
}
