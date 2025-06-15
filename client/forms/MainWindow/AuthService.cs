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

        public int? RegisterUser(string username, string password, string email)
        {
            var dbPath = @"Data Source=C:\Hackathon\dataBase.db;Version=3;";

            using (var connection = new SQLiteConnection(dbPath))
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        using (var cmd = new SQLiteCommand(
                            "INSERT INTO users (username, password, email) VALUES (@username, @password, @email); " +
                            "SELECT last_insert_rowid();", connection))
                        {
                            cmd.Parameters.AddWithValue("@username", username);
                            cmd.Parameters.AddWithValue("@password", password);
                            cmd.Parameters.AddWithValue("@email", email);

                            int newUserId = Convert.ToInt32(cmd.ExecuteScalar());

                            transaction.Commit();
                            return newUserId;
                        }
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        Console.WriteLine($"Ошибка при регистрации: {ex.Message}");
                        return null;
                    }
                }
            }
        }
    }
}
