namespace ConsoleApp2.Models;

public class Magazine : Book
{
    public int Issue { get; private set; }
    public Magazine(string title, string author, int year, int issue) : base(title, author, year)
    {
        Issue = issue;
    }
    public override string GetInfo()
    {
        return $"[Dergi] {Title} - Sayı: {Issue} ({Year})";
    }
}
