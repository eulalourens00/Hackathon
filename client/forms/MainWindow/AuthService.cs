using SqliteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCrypt.Net;
using System.Data.SQLite;

namespace client.forms.MainWindow
{
    public class AuthService
    {
        private readonly string _connectionString;
        private readonly Database _db;

        public AuthService(string dbFilePath, Database db)
        {
            if (string.IsNullOrEmpty(dbFilePath))
                throw new ArgumentNullException(nameof(dbFilePath));

            _connectionString = $"Data Source={@"C:\Hackathon\dataBase.db"};Version=3;";
            _db = db ?? throw new ArgumentNullException(nameof(db));
        }

        public Users Authenticate(string username, string password)
        {
            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();

                var command = new SQLiteCommand(
                    "SELECT * FROM Users WHERE username = @username",
                    connection);
                command.Parameters.AddWithValue("@username", username);

                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        var storedHash = reader["password"].ToString();
                        if (VerifyPassword(password, storedHash))
                        {
                            return new Users(_db)
                            {
                                id = Convert.ToInt32(reader["id"]),
                                username = reader["username"].ToString(),
                                password = storedHash
                            };
                        }
                    }
                }
            }
            return null;
        }

        private bool VerifyPassword(string inputPassword, string storedPassword)
        { return inputPassword == storedPassword; }

        public bool RegisterUser(string username, string plainPassword, string email)
        {
            if (string.IsNullOrEmpty(_connectionString))  { return false; }
            try
            {
                using (var connection = new SQLiteConnection(_connectionString))
                {
                    connection.Open();

                    var command = new SQLiteCommand(
                        "INSERT INTO Users (username, password, email) VALUES (@username, @password, @email)",
                        connection);

                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", plainPassword);
                    command.Parameters.AddWithValue("@email", email);

                    return command.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            { MessageBox.Show($"Ошибка: {ex.Message}"); return false; }
        }
    }
}
