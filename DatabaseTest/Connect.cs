using Microsoft.Data.Sqlite;

namespace DatabaseTest
{
    partial class DataBase
    {
        SqliteConnection connection;
        public DataBase()
        {
            connection = new SqliteConnection("Data Source = people.db");

            connection.Open();
        }
    }
}
