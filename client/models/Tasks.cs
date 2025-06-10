using SqliteDB;


namespace client.models
{
    public class Tasks: BaseModel<Tasks>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Link { get; set; }
        public int User_Id { get; set; }

        public Tasks() { }
        public Tasks(Database db):base(db) { }
    }
}
