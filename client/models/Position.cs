using SqliteDB;

namespace client.models
{
     class Positions:BaseModel<Positions>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Positions(Database db): base(db) { }
    }
}
