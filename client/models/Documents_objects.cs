using SqliteDB;


namespace client.models
{
     class Documents_objects: BaseModel<Documents_objects>
    {
        public int id { get; set; }
        public int document_Id { get; set; }
        public int object_Id { get; set; }

        public Documents_objects() { }
        public Documents_objects(Database db): base(db) { }
    }
}
