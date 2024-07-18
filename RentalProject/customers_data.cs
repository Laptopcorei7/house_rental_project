using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace RentalProject
{
    internal class customers_data
    {
        private string conn = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Buabe\\OneDrive\\Documents\\house.mdf;Integrated Security=True;Connect Timeout=30";

        public int ID { get; set; }
        public string BookID { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string ContactNum { get; set; }
        public string Gender { get; set; }
        public string HouseID { get; set; }
        public decimal RentAmount { get; set; }
        public string StatusPayment { get; set; }
        public string Status { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public DateTime DateBook { get; set; }

        public List<customers_data> customerDataList()
        {
            List<customers_data> listData = new List<customers_data>();

            using (SqlConnection connect = new SqlConnection(conn))
            {
                connect.Open();

                string selectData = "SELECT * FROM customers";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        customers_data cData = new customers_data();

                        cData.ID = (int)reader["id"];
                        cData.BookID = reader["book_id"].ToString();
                        cData.FullName = reader["full_name"].ToString();
                        cData.Email = reader["email"].ToString();
                        cData.ContactNum = reader["contact"].ToString();
                        cData.Gender = reader["gender"].ToString();
                        cData.HouseID = reader["house_id"].ToString();
                        cData.RentAmount = reader.GetDecimal(reader.GetOrdinal("rent_amount"));
                        cData.StatusPayment = reader["status_payment"].ToString();
                        cData.Status = reader["status"].ToString();
                        cData.DateStart = reader.GetDateTime(reader.GetOrdinal("date_start"));
                        cData.DateEnd = reader.GetDateTime(reader.GetOrdinal("date_end"));
                        cData.DateBook = reader.GetDateTime(reader.GetOrdinal("date_book"));

                        listData.Add(cData);
                    }
                }
            }
            return listData;
        }
    }
}
