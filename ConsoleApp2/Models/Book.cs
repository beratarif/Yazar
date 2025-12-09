namespace ConsoleApp2.Models;
public abstract class Book
{
    public string Title { get; private set; } = string.Empty;
    public string Author { get; private set; } = string.Empty;
    public int Year { get; private set; }

    protected Book(string title, string author, int year)
    {
        Title = title;
        Author = author;
        Year = year;
    }

    public abstract string GetInfo();
}
