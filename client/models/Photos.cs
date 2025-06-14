using SqliteDB;


namespace client.models
{
     class Photos: BaseModel<Photos>
    {
        public int Id { get; set; }
        public int object_Id { get; set; }
        public string Link { get; set; }
        public Photos() { }

        public Photos(Database db): base(db) { }
    }
}
