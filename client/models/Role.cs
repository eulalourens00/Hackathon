using SqliteDB;

namespace client.models
{
     class Role: BaseModel<Role>
    {
        public int Id { get; set; }
        public string Name { get; set; }    

        public Role(Database db): base(db) { }
    }
}
