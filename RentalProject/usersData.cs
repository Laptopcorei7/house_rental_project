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

        public int ID {  get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public string Status { get; set; }
        public string DateReg { get; set; }

        public List<usersData> listUsersData()
        {
            List<usersData> listData = new List<usersData>();

            using(SqlConnection connection = new SqlConnection(Db.ConnectionString))
            {
                connection.Open();

                // No password column: the grid must never show password hashes.
                string selectData = "SELECT id, name, email, role, status, date_registered FROM users";

                using(SqlCommand cmd = new SqlCommand(selectData, connection))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        usersData uData = new usersData();

                        uData.ID = (int)reader["id"];
                        uData.Name = reader["name"].ToString();
                        uData.Email = reader["email"].ToString();
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
