public class Position
{
    public Guid Id { get; private set; }
    public string Name { get; private set; }
    public string Abbreviation { get; private set; }

    // EF Core constructor
    private Position() { }

    public Position(string name, string abbreviation)
    {
        Id = Guid.NewGuid();
        Name = name;
        Abbreviation = abbreviation;
    }
}