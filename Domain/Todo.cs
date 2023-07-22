namespace AuthNet.Domain;

public class Todo
{
    public long Id { get; set; }
    public string Name { get; set; }

    public Todo(long id, string name)
    {
        Id = id;
        Name = name;
    }
}
