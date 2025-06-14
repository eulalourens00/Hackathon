using SqliteDB;


namespace client.models
{
     class Photos_objects: BaseModel<Photos_objects>
    {
        public int Id { get; set; }
        public int photo_Id { get; set; }
        public int object_Id { get; set; }
        public Photos_objects() { }
        public Photos_objects(Database db): base(db) { }    
    }
}
