using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace RentalProject
{


    internal class houseData
    {
        public int ID { get; set; }
        public string HouseId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public int Bedrooms { get; set; }
        public int Bathrooms { get; set; }
        public decimal Rent { get; set; }
        public decimal Deposit { get; set; }
        public string Image { get; set; }
        public DateTime Date_Available { get; set; }
        public string Status { get; set; }

        

        public class DatabaseAccess
        {
            private string conn = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Buabeng\\Documents\\HOUSE.mdf;Integrated Security=True;Connect Timeout=30";

            public List<houseData> GetHouseDataList()
            {
                List<houseData> listData = new List<houseData>();

                using (SqlConnection connect = new SqlConnection(conn))
                {
                    connect.Open();

                    string selectData = "SELECT * FROM addHouse WHERE date_delete IS NULL";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            houseData hData = new houseData();

                            hData.ID = (int)reader["id"];
                            hData.HouseId = reader["house_id"].ToString();
                            hData.Name = reader["house_name"].ToString();
                            hData.Description = reader["description"].ToString();
                            hData.Address = reader["address"].ToString();
                            hData.Bedrooms = (int)reader["number_of_bedrooms"];
                            hData.Bathrooms = (int)reader["number_of_bathrooms"];
                            hData.Rent = reader.GetDecimal(reader.GetOrdinal("rent_amount"));
                            hData.Deposit = reader.GetDecimal(reader.GetOrdinal("deposit_amount"));
                            hData.Image = reader["image_path"].ToString();
                            hData.Date_Available = reader.GetDateTime(reader.GetOrdinal("date_available"));
                            hData.Status = reader["status"].ToString();

                            listData.Add(hData);
                        }
                    }
                }
                return listData;
            }
        }


    }
}

       
