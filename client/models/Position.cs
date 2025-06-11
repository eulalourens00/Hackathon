using SqliteDB;

namespace client.models
{
     class Positions:BaseModel<Positions>
    {
        public int id { get; set; }
        public string name { get; set; }
        public Positions() { }
        public Positions(Database db): base(db) { }
    }
}
