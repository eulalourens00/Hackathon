using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using client.models;
using SqliteDB;
using System.Data.SQLite;
namespace client {
    internal class DBController {
        public Database db;
        public Objects objectsModel;
        public Tasks tasksModel;
        public Documents documentsModel;
        public Photos photosModel;
        public DBController(string dbPath) {
            InitDB(dbPath);
        }

        private void InitDB(string dbPath) {
            try {
                this.db = new Database(dbPath);
                
            } catch (Exception ex) {
                // Call "cherry.rotatick.ru/db-sample"
                // Add returned file next to executable
                throw new NotImplementedException();
            }

            this.objectsModel = new Objects(db);
            this.tasksModel = new Tasks(db);
            this.documentsModel = new Documents(db);
            this.photosModel = new Photos(db);
        }

        public IEnumerable<dynamic> GetTasksWithUsernames()
        {
            var dbPath = @"Data Source=C:\Hackathon\dataBase.db;Version=3;";

            using (var connection = new SQLiteConnection(dbPath))
            {
                connection.Open();
                using (var command = new SQLiteCommand(
                    "SELECT t.*, u.username FROM tasks t LEFT JOIN users u ON t.user_id = u.id",
                    connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            yield return new
                            {
                                id = reader.GetInt32(0),
                                name = reader.GetString(1),
                                link = reader.GetString(2),
                                user_id = reader.GetInt32(3),
                                username = reader.IsDBNull(4) ? null : reader.GetString(4)
                            };
                        }
                    }
                }
            }
        }

        public dynamic GetFullTaskInfo(int taskId)
        {
            var dbPath = @"Data Source=C:\Hackathon\dataBase.db;Version=3;";

            using (var connection = new SQLiteConnection(dbPath))
            {
                connection.Open();
                using (var command = new SQLiteCommand(
                    "SELECT t.*, u.username FROM tasks t LEFT JOIN users u ON t.user_id = u.id WHERE t.id = @id",
                    connection))
                {
                    command.Parameters.AddWithValue("@id", taskId);
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new
                            {
                                id = reader.GetInt32(0),
                                name = reader.GetString(1),
                                link = reader.GetString(2),
                                user_id = reader.GetInt32(3),
                                username = reader.IsDBNull(4) ? null : reader.GetString(4)
                            };
                        }
                    }
                }
            }
            return null;
        }
    }
}
