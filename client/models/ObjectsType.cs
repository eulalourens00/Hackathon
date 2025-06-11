using SqliteDB;


namespace client.models
{
     class ObjectsType:BaseModel<ObjectsType>
    {
        public int id { get; set; } 
        public string name { get; set; }    
        public ObjectsType(Database db) : base(db) { }
    }
}
