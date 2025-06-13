using SqliteDB;

public class AvaEmployee : BaseModel<AvaEmployee>
{
    public int id { get; set; }
    public int employee_id { get; set; }
    public string link { get; set; }

    public AvaEmployee() { }
    public AvaEmployee(Database db) : base(db) { }
}