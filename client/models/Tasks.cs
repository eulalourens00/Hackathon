using SqliteDB;
using System.Runtime.Serialization;


namespace client.models
{
    public class Tasks: BaseModel<Tasks>
    {
        public int id { get; set; }
        public string name { get; set; }
        public string link { get; set; }
        public int user_id { get; set; }

        public Tasks() { }
        public Tasks(Database db):base(db) { }
    }
}
