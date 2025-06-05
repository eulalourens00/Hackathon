using SqliteDB;


namespace client.models
{
     class Tasks: BaseModel<Tasks>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Link { get; set; }
        public Tasks(Database db):base(db) { }
    }
}
