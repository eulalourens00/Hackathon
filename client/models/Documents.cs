using SqliteDB;


namespace client.models
{
     class Documents: BaseModel<Documents>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Link { get; set; }

        public Documents(Database db): base(db) { }
    }
}
