// See https://aka.ms/new-console-template for more information

using System;

struct Books
{
    public string title;
    public string subject;
    public string author;
    public int book_id;
};

public class testStructure
{
    public static void Main(string[] args) 
    {
        Books book1;
        Books book2;

        book1.title = "C programming";
        book1.author = "Nuha Ali";
        book1.subject = "C programming Tutorial";
        book1.book_id = 6495407;

        book2.title = "Telecom Billing";
        book2.author = "Zara Ali";
        book2.subject = "Telecom Billing Tutorial";
        book2.book_id = 6495700;

        Console.WriteLine("Book 1 title : {0}", book1.title);
        Console.WriteLine("Book 1 author : {0}", book1.author);
        Console.WriteLine("Book 1 subject : {0}", book1.subject);
        Console.WriteLine("Book 1 book_id : {0}", book1.book_id);

        Console.ReadKey();
    }
}
