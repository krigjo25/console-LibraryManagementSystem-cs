// See https://aka.ms/new-console-template for more information

// File references
using BookApp.lib;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("Initialize books !");
        Console.WriteLine("Which tittle would you give the book?");
        var name = Console.ReadLine();
        
        Console.WriteLine("Whom is the author of the book?");
        var author = Console.ReadLine();
        
        Console.WriteLine("What is the description of the book?");
        var description = Console.ReadLine();
        
        Console.WriteLine("Characters of the book?");
        string[] ch = Console.ReadLine().Split(',');

        Console.WriteLine("When was the book published");
        var published = Console.ReadLine();
        
        Book book = new Book(name, author, published, ch, description);
        
        book.PrintInfo();



    }
}