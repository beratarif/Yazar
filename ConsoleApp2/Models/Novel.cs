namespace ConsoleApp2.Models;

public class Novel : Book
{
   public string Genre { get; private set; }

    public Novel(string title, string author, int year, string genre) : base(title, author, year)
    {
        Genre = genre;
    }
    public override string GetInfo()
    {
        return $"[Roman] {Title} - {Author} ({Year}) | Tür: {Genre}";
    }
}
