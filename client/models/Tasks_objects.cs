using SqliteDB;


namespace client.models
{
     class Tasks_objects:BaseModel<Tasks_objects>
    {
        public int Id { get; set; }
        public int task_Id {  get; set; }
        public int object_Id { get; set; }

        public Tasks_objects(Database db) :base(db) { }
    }
}
