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
using System.IO;
using static RentalProject.houseData;

namespace RentalProject
{

    public partial class admin_addHouses : UserControl
    {
        public admin_addHouses()
        {
            InitializeComponent();
            // No data loading here: the VS designer runs this constructor. The main form calls refreshData().
        }

        public void displayHouseData()
        {
            DatabaseAccess dbAccess = new DatabaseAccess();
            List<houseData> listD = dbAccess.GetHouseDataList();

            dataGridView1.DataSource = listD;
        }

        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke(new MethodInvoker(refreshData));
                return;
            }
            displayHouseData();
        }


        public bool isEmpty()
        {
            if (string.IsNullOrEmpty(addHouse_ID.Text) || string.IsNullOrEmpty(addHouse_name.Text) ||
                string.IsNullOrEmpty(addHouse_description.Text) || string.IsNullOrEmpty(addHouse_address.Text) || addHouse_numOfBedrooms.Value == 0 ||
                addHouse_numOfBathrooms.Value == 0 || string.IsNullOrEmpty(addHouse_rentAmount.Text) ||
                string.IsNullOrEmpty(addHouse_dailyRent.Text) ||
                string.IsNullOrEmpty(addHouse_depositAmount.Text) || addHouse_availableDate.Value == DateTimePicker.MinimumDateTime ||
                addHouse_status.SelectedIndex == -1 || addHouse_picture.Image == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Reads the three money boxes. Shows a message and returns false if any is not a positive number.
        private bool TryReadPrices(out decimal rent, out decimal dailyRent, out decimal deposit)
        {
            dailyRent = deposit = 0;
            if (decimal.TryParse(addHouse_rentAmount.Text.Trim(), out rent) && rent > 0 &&
                decimal.TryParse(addHouse_dailyRent.Text.Trim(), out dailyRent) && dailyRent > 0 &&
                decimal.TryParse(addHouse_depositAmount.Text.Trim(), out deposit) && deposit >= 0)
            {
                return true;
            }
            MessageBox.Show("Monthly rent and daily rent must be numbers above 0, and the deposit a number of 0 or more.",
                "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        private void addHouseBtn_Click(object sender, EventArgs e)
        {
            if (isEmpty())
            {
                MessageBox.Show("Please fill all blank fields.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (TryReadPrices(out decimal rent, out decimal dailyRent, out decimal deposit))
            {
                try
                {
                    using (SqlConnection connect = new SqlConnection(Db.ConnectionString))
                    {
                        connect.Open();

                        string checkHouseID = "SELECT house_id FROM addHouse WHERE house_id = @houseID";

                        using (SqlCommand checkHID = new SqlCommand(checkHouseID, connect))
                        {
                            checkHID.Parameters.AddWithValue("@houseID", addHouse_ID.Text.Trim());

                            SqlDataAdapter adapter = new SqlDataAdapter(checkHID);
                            DataTable table = new DataTable();

                            adapter.Fill(table);

                            if (table.Rows.Count > 0)
                            {
                                MessageBox.Show(addHouse_ID.Text.Trim() + "is existing already.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertData = "INSERT INTO addHouse (house_id, house_name, description, address, " +
                                    "number_of_bedrooms, number_of_bathrooms, rent_amount, daily_rent, deposit_amount, image_path, date_available, status)" +
                                    "VALUES(@houseID, @name, @description, @address, @bedrooms, @bathrooms, @rent, @daily, @deposit, @path, @date_avail, @status)";

                                string path = Path.Combine("D:\\wsl\\house_rental_project\\RentalProject\\house_directory\\" + addHouse_ID.Text.Trim() + ".jpg");

                                string directoryPath = Path.GetDirectoryName(path);

                                if (!Directory.Exists(directoryPath))
                                {
                                    Directory.CreateDirectory(directoryPath);
                                }

                                File.Copy(addHouse_picture.ImageLocation, path, true);

                                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@houseID", addHouse_ID.Text.Trim());
                                    cmd.Parameters.AddWithValue("@name", addHouse_name.Text.Trim());
                                    cmd.Parameters.AddWithValue("@description", addHouse_description.Text.Trim());
                                    cmd.Parameters.AddWithValue("@address", addHouse_address.Text.Trim());
                                    cmd.Parameters.AddWithValue("@bedrooms", addHouse_numOfBedrooms.Value);
                                    cmd.Parameters.AddWithValue("@bathrooms", addHouse_numOfBathrooms.Value);
                                    cmd.Parameters.AddWithValue("@rent", rent);
                                    cmd.Parameters.AddWithValue("@daily", dailyRent);
                                    cmd.Parameters.AddWithValue("@deposit", deposit);
                                    cmd.Parameters.AddWithValue("@path", path);
                                    cmd.Parameters.AddWithValue("@date_avail", addHouse_availableDate.Value);
                                    cmd.Parameters.AddWithValue("@status", addHouse_status.SelectedItem.ToString());

                                    cmd.ExecuteNonQuery();

                                    clearFields();

                                    displayHouseData();

                                    MessageBox.Show("Added successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                }

                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:" + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }


        }

        private void addHouse_importBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string imagePath = "";

                OpenFileDialog file = new OpenFileDialog();

                file.Filter = "Image Files(*.jpg; *.png)|*jpg;*png";

                if (file.ShowDialog() == DialogResult.OK)
                {
                    imagePath = file.FileName;
                    addHouse_picture.ImageLocation = imagePath;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void addHouse_update_Click(object sender, EventArgs e)
        {
            if (isEmpty())
            {
                MessageBox.Show("Please select item first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (TryReadPrices(out decimal rent, out decimal dailyRent, out decimal deposit))
            {
                try
                {
                    if (MessageBox.Show("Are you sure you want to UPDATE ID: " + id + "?", "Confirmation Message",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        using (SqlConnection connect = new SqlConnection(Db.ConnectionString))
                        {
                            connect.Open();

                            string updateData = "UPDATE addhouse SET house_id = @houseID, house_name = @name, description = @description, address = @address, " +
                                "number_of_bedrooms = @bedrooms, number_of_bathrooms = @bathrooms, rent_amount = @rent, daily_rent = @daily, deposit_amount = @deposit," +
                                "date_available = @date_avail, status = @status, date_update = @update WHERE id = @id";

                            using (SqlCommand cmd = new SqlCommand(updateData, connect))
                            {
                                cmd.Parameters.AddWithValue("id", id);
                                cmd.Parameters.AddWithValue("@houseID", addHouse_ID.Text.Trim());
                                cmd.Parameters.AddWithValue("@name", addHouse_name.Text.Trim());
                                cmd.Parameters.AddWithValue("@description", addHouse_description.Text.Trim());
                                cmd.Parameters.AddWithValue("@address", addHouse_address.Text.Trim());
                                cmd.Parameters.AddWithValue("@bedrooms", addHouse_numOfBedrooms.Value);
                                cmd.Parameters.AddWithValue("@bathrooms", addHouse_numOfBathrooms.Value);
                                cmd.Parameters.AddWithValue("@rent", rent);
                                cmd.Parameters.AddWithValue("@daily", dailyRent);
                                cmd.Parameters.AddWithValue("@deposit", deposit);
                                cmd.Parameters.AddWithValue("@date_avail", addHouse_availableDate.Value);
                                cmd.Parameters.AddWithValue("@status", addHouse_status.SelectedItem.ToString());

                                DateTime today = DateTime.Today;
                                cmd.Parameters.AddWithValue("@update", today);


                                cmd.ExecuteNonQuery();

                                clearFields();

                                displayHouseData();

                                MessageBox.Show("Updated Successfully.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:" + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }


        }

        private int id;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                houseData house = (houseData)dataGridView1.Rows[e.RowIndex].DataBoundItem;

                id = house.ID;
                addHouse_ID.Text = house.HouseId;
                addHouse_name.Text = house.Name;
                addHouse_description.Text = house.Description;
                addHouse_address.Text = house.Address;
                addHouse_numOfBedrooms.Value = house.Bedrooms;
                addHouse_numOfBathrooms.Value = house.Bathrooms;
                addHouse_rentAmount.Text = house.Rent.ToString("0.00");
                addHouse_dailyRent.Text = house.DailyRent.ToString("0.00");
                addHouse_depositAmount.Text = house.Deposit.ToString("0.00");
                addHouse_picture.ImageLocation = house.Image;
                addHouse_availableDate.Value = house.Date_Available;
                addHouse_status.Text = house.Status;

            }
        }

        public void clearFields()
        {
            addHouse_ID.Text = "";
            addHouse_name.Text = "";
            addHouse_description.Text = "";
            addHouse_address.Text = "";
            addHouse_numOfBedrooms.Value = addHouse_numOfBedrooms.Minimum;
            addHouse_numOfBathrooms.Value = addHouse_numOfBathrooms.Minimum;
            addHouse_rentAmount.Text = "";
            addHouse_dailyRent.Text = "";
            addHouse_depositAmount.Text = "";
            addHouse_picture.Image = null;
            addHouse_availableDate.Value = DateTime.Now;
            addHouse_status.SelectedIndex = -1;

        }
        private void addHouse_clear_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void addHouse_delete_Click(object sender, EventArgs e)
        {
            if (isEmpty())
            {
                MessageBox.Show("Please select item first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    if (MessageBox.Show("Are you sure you want to DELETE ID: " + id + "?", "Confirmation Message",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        using (SqlConnection connect = new SqlConnection(Db.ConnectionString))
                        {
                            connect.Open();

                            string updateData = "UPDATE addhouse SET date_delete = @delete WHERE id = @id";

                            using (SqlCommand cmd = new SqlCommand(updateData, connect))
                            {
                                

                                DateTime today = DateTime.Today;
                                cmd.Parameters.AddWithValue("@delete", today);
                                cmd.Parameters.AddWithValue("id", id);


                                cmd.ExecuteNonQuery();

                                clearFields();

                                displayHouseData();

                                MessageBox.Show("Deleted successfully.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:" + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}
