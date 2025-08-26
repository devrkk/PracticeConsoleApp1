using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;

namespace PracticeConsoleApp1
{
    internal class SQLiteSImple2
    {
        public SQLiteSImple2()
        {
            using var connection = new SqliteConnection("Data Source=sample.db");
            Console.WriteLine(Path.GetFullPath("sample.db"));

            connection.Open();

            var command = connection.CreateCommand();
            command.CommandText = "CREATE TABLE IF NOT EXISTS Users (Id INTEGER PRIMARY KEY, Name TEXT);";
            command.ExecuteNonQuery();

            command.CommandText = "INSERT INTO Users (Name) VALUES ('Alice3');";
            command.ExecuteNonQuery();

            command.CommandText = "SELECT COUNT(*) FROM Users;";
            var count = (long)command.ExecuteScalar();
            Console.WriteLine($"User count: {count}");


            command.CommandText = "SELECT DISTINCT Name FROM Users;";
            using var reader = command.ExecuteReader();

            while (reader.Read())
            {
                string name = reader.GetString(0);
                Console.WriteLine($"Name: {name}");
            }

        }
    }
}
