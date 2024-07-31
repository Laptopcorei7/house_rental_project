using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace RentalProject
{
    internal class usersData
    {
        private string conn = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Buabeng\\Documents\\HOUSE.mdf;Integrated Security=True;Connect Timeout=30";

        public int ID {  get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string Status { get; set; }
        public string DateReg { get; set; }

        public List<usersData> listUsersData()
        {
            List<usersData> listData = new List<usersData>();

            using(SqlConnection connection = new SqlConnection(conn))
            {
                connection.Open();

                string selectData = "SELECT * FROM users";

                using(SqlCommand cmd = new SqlCommand(selectData, connection))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        usersData uData = new usersData();

                        uData.ID = (int)reader["id"];
                        uData.Name = reader["name"].ToString();
                        uData.Email = reader["email"].ToString();
                        uData.Password = reader["password"].ToString();
                        uData.Role = reader["role"].ToString();
                        uData.Status = reader["status"].ToString();
                        uData.DateReg = reader["date_registered"].ToString();

                        listData.Add(uData);



                    }
                }
            }

            return listData;
        }


    }
}
