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
        public decimal DailyRent { get; set; }
        public decimal Deposit { get; set; }
        public string Image { get; set; }
        public DateTime Date_Available { get; set; }
        public string Status { get; set; }
        // Current and upcoming bookings, e.g. "28 Oct 2026 - 28 Dec 2026". Empty when none.
        public string BookedDates { get; set; } = "";
        // Move-out day of the booking running today, or null if nobody is in the house today.
        [System.ComponentModel.Browsable(false)]
        public DateTime? BookedUntil { get; set; }


        public class DatabaseAccess
        {

            public List<houseData> GetHouseDataList()
            {
                List<houseData> listData = new List<houseData>();

                using (SqlConnection connect = new SqlConnection(Db.ConnectionString))
                {
                    connect.Open();

                    string selectData = "SELECT * FROM addHouse WHERE date_delete IS NULL";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        using SqlDataReader reader = cmd.ExecuteReader();

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
                            hData.DailyRent = reader.GetDecimal(reader.GetOrdinal("daily_rent"));

                            listData.Add(hData);
                        }
                    }

                    // Bookings that haven't ended yet. The end date is the move-out day.
                    string selectBookings =
                        "SELECT house_id, date_start, date_end FROM customers " +
                        "WHERE status = 'Rent Approved' AND date_start IS NOT NULL AND date_end > @today " +
                        "ORDER BY date_start";

                    using (SqlCommand cmd = new SqlCommand(selectBookings, connect))
                    {
                        DateTime today = DateTime.Today;
                        cmd.Parameters.AddWithValue("@today", today);
                        using SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            houseData? house = listData.Find(h => h.HouseId == reader.GetString(0));
                            if (house == null) continue;

                            DateTime start = reader.GetDateTime(1);
                            DateTime end = reader.GetDateTime(2);
                            string period = $"{start:d MMM yyyy} - {end:d MMM yyyy}";
                            house.BookedDates = house.BookedDates == "" ? period : house.BookedDates + ", " + period;
                            if (start <= today) house.BookedUntil = end;
                        }
                    }
                }
                return listData;
            }
        }


    }
}

       
