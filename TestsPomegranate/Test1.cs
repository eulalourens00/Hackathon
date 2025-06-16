using SqliteDB;

namespace TestsPomegranate
{
    public class Users : BaseModel<Users>
    {
        //new string _tablename = "users"; // необязательно

        public int id { get; set; }
        public int employee_id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string email { get; set; }

        public Users() : base() { }

        public Users(Database db) : base(db) { }
    }

    [TestClass]
    public sealed class UserTest
    {
        [TestMethod]
        public void IsAdminPresent()
        {
            //Database db = new Database("C:\\Hackathon\\dataBase.db");
            //Users usersModel = new Users(db);

            //List<Users> users = usersModel.Query();

            //foreach (var user in users)
            //{ if (user.username == "admin" && user.password == "admin_09") { return; } }

            //throw new ArgumentException("No admin found");
        }
    }
    public class Objects : BaseModel<Objects>
    {
        //new string _tablename = "objects"; // необязательно

        public int id { get; set; }
        public int object_type { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string location { get; set; }
        public int number { get; set; }

        public Objects() : base() { }

        public Objects(Database db) : base(db) { }
    }
    [TestClass]
    public sealed class ObjectTest
    {
        [TestMethod]
        public void CanObjToCreate()
        {
            //try
            //{
            //    Database db = new Database("C:\\Hackathon\\dataBase.db");
            //    Objects objectsModel = new Objects(db);

            //    var newObj = new Objects
            //    {
            //        object_type = 1,
            //        name = "Тестовый объект",
            //        description = "Это тестовый объект",
            //        location = "Локация 1",
            //        number = 999
            //    };

            //    objectsModel.CreateRecord(newObj);
            //}
            //catch (Exception ex)
            //{ throw new ArgumentException(ex.Message); }
        }
    }
    class Documents : BaseModel<Documents>
    {
        public int id { get; set; }
        public string name { get; set; }
        public string link { get; set; }
        public Documents() { }
        public Documents(Database db) : base(db) { }
    }
    [TestClass]
    public sealed class DocumentTests
    {
        [TestMethod]
        public void AddDocument()
        {
            //try
            //{
            //    Database db = new Database("C:\\Hackathon\\dataBase.db");
            //    Documents docModel = new Documents(db);

            //    var newDoc = new Documents
            //    {
            //        name = "Тестовый документ.txt",
            //        link = @"C:\\Users\\alopo\\Downloads\\tz2.docx"
            //    };

            //    docModel.CreateRecord(newDoc);
            //}
            //catch (Exception ex) { throw new Exception(ex.Message); }
        }
    }

    public class Tasks : BaseModel<Tasks>
    {
        public int id { get; set; }
        public string name { get; set; }
        public string link { get; set; }
        public int user_id { get; set; }

        public Tasks() { }
        public Tasks(Database db) : base(db) { }
    }
    [TestClass]
    public sealed class TaskTests
    {
        [TestMethod]
        public void CreateTask()
        {
            //try
            //{
            //    Database db = new Database("C:\\Hackathon\\dataBase.db");
            //    Tasks taskModel = new Tasks(db);

            //    var newTask = new Tasks
            //    {
            //        name = "Тестовая задача",
            //        link = "https://journal.top-academy.ru",
            //        user_id = 1
            //    };

            //    taskModel.CreateRecord(newTask);
            //}
            //catch (Exception ex) { throw new Exception(ex.Message); }
        }
    }

    class Employees : BaseModel<Employees>
    {
        public int id { get; set; }
        public int role_id { get; set; }
        public int position_id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }

        public Employees() { }
        public Employees(Database db) : base(db) { }
    }
    [TestClass]
    public sealed class EmployeeTests
    {
        [TestMethod]
        public void CreateEmployee()
        {
            //try
            //{
            //    Database db = new Database("C:\\Hackathon\\dataBase.db");
            //    Employees employeeModel = new Employees(db);

            //    var newEmployee = new Employees
            //    {
            //        role_id = 1,
            //        position_id = 1,
            //        first_name = "Иван",
            //        last_name = "Тестовый"
            //    };

            //    employeeModel.CreateRecord(newEmployee);
            //}
            //catch (Exception ex) { throw new Exception(ex.Message); }
        }
    }

}
