using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DatabaseTest
{
    partial class DataBase
    {
        public void Write(string name, int age)
        {
            string sql = $"insert into person (name, age) values ('{name}', {age})";
            SqliteCommand command = new SqliteCommand(sql, connection);
            command.ExecuteNonQuery();
            Console.WriteLine("запись успешно добавлена");
        }
    }
}
