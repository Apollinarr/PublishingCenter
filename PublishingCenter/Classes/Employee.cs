using MySql.Data.MySqlClient;
using System.Data;

namespace PublishingCenter
{
    public class Employee
    {
        private MySqlConnection connection;
        public static int ID { get; private set; }
        public static string FirstName { get; private set; }
        public static string LastName { get; private set; }
        public static string MiddleName { get; private set; }   
        public static int Position { get; private set; }
        public static string Login { get; private set; }

        public bool SetUserData(string login)
        {
            connection = new Connection().GetConnectionString();

            if (connection.State == ConnectionState.Closed)
                connection.Open();

            string query = "SELECT * FROM employees WHERE login = @login";
            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@login", login);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        reader.Read();

                        ID = (int)reader["ID"];
                        FirstName = reader["first_name"].ToString();
                        LastName = reader["last_name"].ToString();
                        MiddleName = reader["middle_name"].ToString();
                        Position = (int)reader["position_id"];
                        Login = reader["login"].ToString();
                        connection.Close();
                        return true;
                    }
                }
                connection.Close();
                return false;
            }
        }

        //unused
        public void SetGuest()
        {
            ID = -1;
            FirstName = "";
            LastName = "";
            MiddleName = "";
            Position = 4;
            Login = "";
        }
    }
}
