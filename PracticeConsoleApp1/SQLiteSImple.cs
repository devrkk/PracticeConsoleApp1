using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;

namespace PracticeConsoleApp1
{
    internal class SQLiteSImple
    {
        public SQLiteSImple()
        {
            using (var connection = new SqliteConnection("Data Source=:memory:"))
            {
                connection.Open();
                var createTableCmd = connection.CreateCommand();
                createTableCmd.CommandText =
                @"
                    CREATE TABLE users (
                        id INTEGER PRIMARY KEY,
                        name TEXT,
                        age INTEGER
                    );
                ";
                createTableCmd.ExecuteNonQuery();
                var insertCmd = connection.CreateCommand();
                insertCmd.CommandText =
                @"
                    INSERT INTO users (name, age) VALUES
                    ('Alice', 30),
                    ('Bob', 25),
                    ('Charlie', 35);
                ";
                insertCmd.ExecuteNonQuery();
                var selectCmd = connection.CreateCommand();
                selectCmd.CommandText = "SELECT id, name, age FROM users;";
                using (var reader = selectCmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var id = reader.GetInt32(0);
                        var name = reader.GetString(1);
                        var age = reader.GetInt32(2);
                        Console.WriteLine($"ID: {id}, Name: {name}, Age: {age}");
                    }
                }
            }
        }
    }
}
