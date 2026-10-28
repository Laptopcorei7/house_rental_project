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
    public partial class admin_addUser : UserControl
    {
        public admin_addUser()
        {
            InitializeComponent();
            // No data loading here: the VS designer runs this constructor. The main form calls refreshData().
        }

        public void refreshData()
        {
            if(InvokeRequired)
            {
                Invoke(new MethodInvoker(refreshData));
                return;
            }
            displayData();
        }

        public void displayData()
        {
            usersData uData = new usersData();
            dataGridView1.DataSource = uData.listUsersData();
        }

        private void addUser_addBtn_Click(object sender, EventArgs e)
        {
            if (addUser_name.Text == "" || addUser_email.Text == "" || addUser_password.Text == "" || addUser_role.SelectedIndex == -1 || addUser_status.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill all all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (SqlConnection connect = new SqlConnection(Db.ConnectionString))
                {
                    connect.Open();

                    string checkUserEmail = "SELECT email FROM users WHERE email = @userEmail";

                    using (SqlCommand checkE = new SqlCommand(checkUserEmail, connect))
                    {
                        checkE.Parameters.AddWithValue("@userEmail", addUser_email.Text.Trim());

                        SqlDataAdapter adapter = new SqlDataAdapter(checkE);
                        DataTable table = new DataTable();

                        adapter.Fill(table);

                        if (table.Rows.Count != 0)
                        {
                            string tempName = addUser_name.Text.Substring(0, 1).ToUpper() + addUser_name.Text.Substring(1);

                            MessageBox.Show($"{tempName} is existing already", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (addUser_password.Text.Length < 8)
                        {
                            MessageBox.Show("The password must be at least 8 characters.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            string insertData = "INSERT INTO users (name, email, password, role, status, date_registered)" + "VALUES(@name, @userEmail, @pass, @role, @status, @date)";

                            using (SqlCommand cmd = new SqlCommand(insertData, connect))
                            {
                                cmd.Parameters.AddWithValue("@name", addUser_name.Text.Trim());
                                cmd.Parameters.AddWithValue("@userEmail", addUser_email.Text.Trim());
                                cmd.Parameters.AddWithValue("@pass", Passwords.Hash(addUser_password.Text));
                                cmd.Parameters.AddWithValue("@role", addUser_role.SelectedItem.ToString());
                                cmd.Parameters.AddWithValue("@status", addUser_status.SelectedItem.ToString());

                                DateTime today = DateTime.Today;

                                cmd.Parameters.AddWithValue("@date", today);

                                cmd.ExecuteNonQuery();

                                clearFields();
                                displayData();

                                MessageBox.Show("Added Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }
                        }
                    }
                }
            }
        }

        public void clearFields()
        {
            addUser_name.Text = "";
            addUser_email.Text = "";
            addUser_password.Text = "";
            addUser_role.SelectedIndex = -1;
            addUser_status.SelectedIndex = -1;
            getID = 0;
        }
        private void addUser_clearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        // Returns why an update or delete of the selected user can't go ahead, or null when it can.
        // The logged-in admin can't delete, demote or deactivate themselves. That also guarantees
        // at least one active admin is always left: the person doing it.
        private string? FindProblem(bool deleting)
        {
            if (getID == 0) return "Please select a user in the list first.";
            if (getID != Session.UserId) return null;
            if (deleting) return "You can't delete your own account.";
            if (addUser_role.Text != "Admin" || addUser_status.Text != "Active")
                return "You can't remove your own admin role or deactivate your own account.";
            return null;
        }

        private void adduser_updateBtn_Click(object sender, EventArgs e)
        {
            string? problem = FindProblem(deleting: false);
            if (problem == null && (addUser_name.Text == "" || addUser_email.Text == "" || addUser_role.SelectedIndex == -1 || addUser_status.SelectedIndex == -1))
                problem = "Please fill all blank fields. Leave the password empty to keep the current one.";
            if (problem == null && addUser_password.Text != "" && addUser_password.Text.Length < 8)
                problem = "The new password must be at least 8 characters.";
            if (problem != null)
            {
                MessageBox.Show(problem, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Are you sure you want to update ID: " + getID + "?", "Confirmation Message",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            using SqlConnection connect = new SqlConnection(Db.ConnectionString);
            connect.Open();

            using (SqlCommand checkE = new SqlCommand("SELECT 1 FROM users WHERE email = @userEmail AND id <> @id", connect))
            {
                checkE.Parameters.AddWithValue("@userEmail", addUser_email.Text.Trim());
                checkE.Parameters.AddWithValue("@id", getID);
                if (checkE.ExecuteScalar() != null)
                {
                    MessageBox.Show("Another user already has this email.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // An empty password box keeps the current password.
            string updateData = "UPDATE users SET name = @name, email = @userEmail, role = @role, status = @status" +
                (addUser_password.Text == "" ? "" : ", password = @pass") + " WHERE id = @id";

            using (SqlCommand cmd = new SqlCommand(updateData, connect))
            {
                cmd.Parameters.AddWithValue("@name", addUser_name.Text.Trim());
                cmd.Parameters.AddWithValue("@userEmail", addUser_email.Text.Trim());
                cmd.Parameters.AddWithValue("@role", addUser_role.Text);
                cmd.Parameters.AddWithValue("@status", addUser_status.Text);
                cmd.Parameters.AddWithValue("@id", getID);
                if (addUser_password.Text != "") cmd.Parameters.AddWithValue("@pass", Passwords.Hash(addUser_password.Text));

                cmd.ExecuteNonQuery();
            }

            clearFields();
            displayData();
            MessageBox.Show("Updated successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private int getID;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                usersData user = (usersData)dataGridView1.Rows[e.RowIndex].DataBoundItem;

                getID = user.ID;
                addUser_name.Text = user.Name;
                addUser_email.Text = user.Email;
                addUser_password.Text = "";
                addUser_role.Text = user.Role;
                addUser_status.Text = user.Status;
            }
        }

        private void addUser_deleteBtn_Click(object sender, EventArgs e)
        {
            string? problem = FindProblem(deleting: true);
            if (problem != null)
            {
                MessageBox.Show(problem, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show($"Are you sure you want to delete {addUser_name.Text} (ID: {getID})?", "Confirmation Message",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            using (SqlConnection connect = new SqlConnection(Db.ConnectionString))
            {
                connect.Open();

                using SqlCommand cmd = new SqlCommand("DELETE FROM users WHERE id = @id", connect);
                cmd.Parameters.AddWithValue("@id", getID);
                cmd.ExecuteNonQuery();
            }

            clearFields();
            displayData();
            MessageBox.Show("Deleted successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
