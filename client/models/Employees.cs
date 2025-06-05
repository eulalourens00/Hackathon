using SqliteDB;

namespace client.models
{
     class Employees:BaseModel<Employees>
    {
        public int Id { get; set; }
        public int role_Id { get; set; }
        public int position_Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Employees(Database db): base(db) { }
    }
}
