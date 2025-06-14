using SqliteDB;


namespace client.models
{
     class Documents: BaseModel<Documents>
    {
        public int id { get; set; }
        public string name { get; set; }
        public string link { get; set; }
        public Documents() { }
        public Documents(Database db): base(db) { }
    }
}
