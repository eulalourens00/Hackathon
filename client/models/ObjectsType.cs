using SqliteDB;


namespace client.models
{
     class ObjectsType:BaseModel<ObjectsType>
    {
        public int Id { get; set; } 
        public string Name { get; set; }    
        public ObjectsType(Database db) : base(db) { }
    }
}
