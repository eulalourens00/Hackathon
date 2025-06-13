using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using client.models;
using SqliteDB;
using System.Data.SQLite;
using System.Data;
namespace client {
    internal class DBController
    {
        public Database db;
        public Objects objectsModel;
        public Tasks tasksModel;
        public Documents documentsModel;
        public Photos photosModel;

        public Users usersModel;
        public Employees employeesModel;
        public Positions positionsModel;
        public Role rolesModel;

        public AvaEmployee avaEmployeeModel;
        public DBController(string dbPath)
        {
            InitDB(dbPath);
        }

        private void InitDB(string dbPath)
        {
            try
            {
                this.db = new Database(dbPath);

            }
            catch (Exception ex)
            {
                // Call "cherry.rotatick.ru/db-sample"
                // Add returned file next to executable
                throw new NotImplementedException();
            }

            this.objectsModel = new Objects(db);
            this.tasksModel = new Tasks(db);
            this.documentsModel = new Documents(db);
            this.photosModel = new Photos(db);
            this.avaEmployeeModel = new AvaEmployee(db);
        }

        //tasks
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


        //user acc
        public dynamic GetUserWithEmployeeInfo(int userId)
        {
            var dbPath = @"Data Source=C:\Hackathon\dataBase.db;Version=3;";

            using (var connection = new SQLiteConnection(dbPath))
            {
                connection.Open();
                using (var command = new SQLiteCommand(
                    @"SELECT 
                u.id as user_id,
                u.username,
                u.email,
                e.id as employee_id,
                e.first_name,
                e.last_name,
                p.name as position_name,
                r.name as role_name
              FROM users u
              JOIN employees e ON u.employee_id = e.id
              LEFT JOIN positions p ON e.position_id = p.id
              LEFT JOIN roles r ON e.role_id = r.id
              WHERE u.id = @userId",
                    connection))
                {
                    command.Parameters.AddWithValue("@userId", userId);
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new
                            {
                                user_id = reader.GetInt32(0),
                                username = reader.GetString(1),
                                email = reader.GetString(2),
                                employee_id = reader.GetInt32(3),
                                first_name = reader.GetString(4),
                                last_name = reader.GetString(5),
                                position_name = reader.IsDBNull(6) ? null : reader.GetString(6),
                                role_name = reader.IsDBNull(7) ? null : reader.GetString(7)
                            };
                        }
                    }
                }
            }
            return null;
        }
    

    // still user acc AVATAR
    public string GetEmployeeAvatar(int employeeId)
        {
            var dbPath = @"Data Source=C:\Hackathon\dataBase.db;Version=3;";
            using (var connection = new SQLiteConnection(dbPath))
            {
                connection.Open();
                using (var command = new SQLiteCommand(
                    "SELECT link FROM AvaEmployee WHERE employee_id = @employeeId ORDER BY id DESC LIMIT 1",
                    connection))
                {
                    command.Parameters.AddWithValue("@employeeId", employeeId);
                    var result = command.ExecuteScalar();
                    return result?.ToString();
                }
            }
        }

        public bool SaveEmployeeAvatar(int employeeId, string imagePath)
        {
            var dbPath = @"Data Source=C:\Hackathon\dataBase.db;Version=3;";
            using (var connection = new SQLiteConnection(dbPath))
            {
                connection.Open();
                using (var command = new SQLiteCommand(
                    "INSERT INTO AvaEmployee (employee_id, link) VALUES (@employeeId, @link)",
                    connection))
                {
                    command.Parameters.AddWithValue("@employeeId", employeeId);
                    command.Parameters.AddWithValue("@link", imagePath);
                    return command.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}
