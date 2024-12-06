namespace BookApp.lib;

public class Book
{
    private string _author;

    //  Properties
    public string Name { get; set; }

    public string Author
    {
        get => _author;
        set => _author = value;
    }
    public string Published { get; set; }
    public string Description { get; set; }
    public readonly string[] Characters;
    
    
    public Book(string name, string author, string published, string[] ch, string description)
    {
        Name = name;
        Author = author;
        Characters = ch;
        Published = published;
        Description = description;
    }
    public void PrintInfo()
    {
        // Print the book's information
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Author: {Author}");

        string character = "";
        
        // Fetch all actors in the book
        foreach (var element in Characters)
        {
            character += element;
        }
        
        Console.WriteLine($"Characters: {character}");
        Console.WriteLine($"Description: {Description}");
    }
}