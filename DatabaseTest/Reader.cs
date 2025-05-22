using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTest
{
    partial class DataBase
    {
        public void Read()
        {
            string sql = "SELECT name, age FROM person";

            SqliteCommand command = new SqliteCommand(sql, connection);
            using (SqliteDataReader reader = command.ExecuteReader())
            {
                Console.WriteLine("Данные из таблицы 'person':\n");

                while (reader.Read())
                {
                    string name = reader.GetString(0); // первая колонка — name
                    int age = reader.GetInt32(1);       // вторая колонка — age

                    Console.WriteLine($"Имя: {name}, Возраст: {age}\n");
                }
            }
        }
    }
}
