using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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

        public long AddPatient(PatientCard patient, long doctor_id)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string sql = $"INSERT INTO patient_card(p_id, surname, name, patronymic, gender, birth, height, weight) VALUES ('{patient.P_id}', '{patient.Surname}', '{patient.Name}', '{patient.Patronymic}', '{patient.Gender}', '{patient.Birth}', '{patient.Height}', '{patient.Weight}, '{patient.Registration_DT}')";
                using (SQLiteCommand command = new SQLiteCommand(sql, connection))
                {
                    command.ExecuteNonQuery();
                    long patient_id = connection.LastInsertRowId;
                    string sql1 = $"INSERT INTO doctor_patient(doctor_id, patient_id) VALUES ('{doctor_id}', '{patient_id}')";
                    using (SQLiteCommand command1 = new SQLiteCommand(sql, connection))
                    {
                        command1.ExecuteNonQuery();
                    }
                    return patient_id;
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

        public List<PatientCard> DoctorsPatients(long id)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string sql = "SELECT pc.* FROM patient_card pc JOIN doctor_patient dp ON pc.id = dp.patient_id WHERE dp.doctor_id = @id";
                using (SQLiteCommand command = new SQLiteCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        List<PatientCard> patients = new List<PatientCard>();
                        while (reader.Read())
                        {
                            var patiet_id = reader.GetInt64(0);
                            var p_id = reader.GetInt64(1);
                            var surname = reader.GetString(2);
                            var name = reader.GetString(3);
                            var patronymic = reader.GetString(4);
                            var gender = reader.GetString(5);
                            var birth = reader.GetDateTime(6);
                            var height = reader.GetInt32(7);
                            var weight = reader.GetInt32(8);
                            var registration_DT = reader.GetDateTime(9);

                            patients.Add(new PatientCard(patiet_id, p_id, surname, name, patronymic, gender, birth, height, weight, registration_DT));
                        }
                        return patients;
                    }
                }
            }
        }

    }
}
