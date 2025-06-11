using SqliteDB;

namespace client.models
{
     class Role: BaseModel<Role>
    {
        public int id { get; set; }
        public string name { get; set; }    

        public Role() { }
        public Role(Database db): base(db) { }
    }
}
