using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemystified.CreationalPatterns
{
    using System;

    public class DatabaseConnection
    {
        private static DatabaseConnection instance;
        private string connectionString;

        // Private constructor to avoid creating external instances.
        private DatabaseConnection()
        {
            // Initialize the database connection string.
            connectionString = "Server=example.com;Database=mydb;User=myuser;Password=mypassword;";
        }

        // Properties to access the Singleton instance.
        public static DatabaseConnection Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DatabaseConnection();
                }
                return instance;
            }
        }

        // Method for opening a database connection.
        public void OpenConnection()
        {
            Console.WriteLine("open database connection: " + connectionString);
            // Here you can implement the code to open the database connection.
        }

        // Method for closing the database connection.
        public void CloseConnection()
        {
            Console.WriteLine("Database connection closed: " + connectionString);
            // Here you can implement the code to close the database connection.
        }
    }
}
