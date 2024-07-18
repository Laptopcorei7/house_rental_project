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
        private string conn = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Buabe\\OneDrive\\Documents\\house.mdf;Integrated Security=True;Connect Timeout=30";
        public admin_addUser()
        {
            InitializeComponent();

            displayData();
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
                using (SqlConnection connect = new SqlConnection(conn))
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
                            MessageBox.Show("Invalid Password", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            string insertData = "INSERT INTO users (name, email, password, role, status, date_registered)" + "VALUES(@name, @userEmail, @pass, @role, @status, @date)";

                            using (SqlCommand cmd = new SqlCommand(insertData, connect))
                            {
                                cmd.Parameters.AddWithValue("@name", addUser_name.Text.Trim());
                                cmd.Parameters.AddWithValue("@userEmail", addUser_email.Text.Trim());
                                cmd.Parameters.AddWithValue("@pass", addUser_password.Text.Trim());
                                cmd.Parameters.AddWithValue("@role", addUser_role.SelectedItem.ToString());
                                cmd.Parameters.AddWithValue("@status", addUser_status.SelectedItem.ToString());

                                DateTime today = DateTime.Today;

                                cmd.Parameters.AddWithValue("@date", today);

                                cmd.ExecuteNonQuery();

                                clearFields();

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
        }
        private void addUser_clearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void adduser_updateBtn_Click(object sender, EventArgs e)
        {
            if (addUser_name.Text == "" || addUser_email.Text == "" || addUser_password.Text == "" || addUser_role.SelectedIndex == -1 || addUser_status.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill all all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to update ID: " + getID + "?", "Confirmation Message",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlConnection connect = new SqlConnection(conn))
                    {
                        connect.Open();

                        string updateData = "UPDATE users SET name = @name, password = @pass, role = @role, status = @status WHERE email = @userEmail";

                        using (SqlCommand cmd = new SqlCommand(updateData, connect))
                        {
                            cmd.Parameters.AddWithValue("@name", addUser_name.Text.Trim());
                            cmd.Parameters.AddWithValue("@pass", addUser_password.Text.Trim());
                            cmd.Parameters.AddWithValue("@role", addUser_role.SelectedItem.ToString());
                            cmd.Parameters.AddWithValue("@status", addUser_status.SelectedItem.ToString());
                            cmd.Parameters.AddWithValue("@userEmail", addUser_email.Text.Trim());


                            cmd.ExecuteNonQuery();
                            displayData();

                            MessageBox.Show("Upadated successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }
                }


            }
        }

        private int getID;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                getID = (int)row.Cells[0].Value;
                addUser_name.Text = row.Cells[1].Value.ToString();
                addUser_email.Text = row.Cells[2].Value.ToString();
                addUser_password.Text = row.Cells[3].Value.ToString();
                addUser_role.Text = row.Cells[4].Value.ToString();
                addUser_status.Text = row.Cells[5].Value.ToString();

            }
        }

        private void addUser_deleteBtn_Click(object sender, EventArgs e)
        {
            if (addUser_name.Text == "" || addUser_email.Text == "" || addUser_password.Text == "" || addUser_role.SelectedIndex == -1 || addUser_status.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill all all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to delete ID: " + getID + "?", "Confirmation Message",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlConnection connect = new SqlConnection(conn))
                    {
                        connect.Open();

                        string updateData = "DELETE FROM users WHERE email = @userEmail";

                        using (SqlCommand cmd = new SqlCommand(updateData, connect))
                        {
                            cmd.Parameters.AddWithValue("@userEmail", addUser_email.Text.Trim());


                            cmd.ExecuteNonQuery();
                            displayData();

                            MessageBox.Show("Deleted successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }
                }


            }
        }
    }
}
