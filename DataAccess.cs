using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miograph
{
    public class DataAccess
    {
        private string connectionString;

        public DataAccess()
        {
            connectionString = $"Data Source=miograph.db";
        }

        /*
        public void CreateTable(string tableName, string columns)
        {
            // метод для создания таблицы с заданным именем и столбцами
            using (SqliteConnection connection = new SqliteConnection(connectionString)) // создаем подключение
            {
                connection.Open(); // открываем подключение
                string sql = $"CREATE TABLE {tableName} ({columns})"; // формируем SQL-запрос для создания таблицы
                using (SqliteCommand command = new SqliteCommand(sql, connection)) // создаем команду
                {
                    command.ExecuteNonQuery(); // выполняем команду
                }
            }
        }
        */

        public long RegistrEmployee(User user)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string sql = $"INSERT INTO users (FIO, acc_type, login, password) VALUES ('{user.Fio}', '{user.AccType}', '{user.Login}', '{user.Password}')";
                using (SQLiteCommand command = new SQLiteCommand(sql, connection))
                {
                    command.ExecuteNonQuery();
                    long id = connection.LastInsertRowId;
                    return id;
                }
            }
        }

        public User LoginUser(string login, string password)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string sql = $"SELECT * FROM users WHERE login = '{login}' and password = '{password}'";
                using (SQLiteCommand command = new SQLiteCommand(sql, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            var Id = reader.GetInt64(0);
                            var FIO = reader.GetString(1);
                            var Acc_type = reader.GetString(2);
                            var Login = reader.GetString(3);
                            var Password = reader.GetString(4);

                            return new User(Id, FIO, Acc_type, Login, Password);
                        } 
                        else 
                        { 
                            return null; 
                        }
                    }
                }
            }
        }
    }
}
