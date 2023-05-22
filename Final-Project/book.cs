using System;
using System.Collections.Generic;
using System.Linq;

class Book
{
    public string ISBN {get;set;}
    public string Title {get;set;}
    public Author AuthorInfo {get;set;}
    public DateTime PublishedOn {get;set;}
    public string PublishedBy {get;set;}

    public Book(string isbn, string title, Author authorinfo)
    {
        ISBN = isbn;
        Title= title;
        AuthorInfo = authorinfo;
        PublishedOn = DateTime.Now;
        PublishedBy="Unknown";
    }

    public Book(string isbn, string title, Author authorinfo, DateTime publishedon, string publishedby)
    {
        ISBN = isbn;
        Title= title;
        AuthorInfo = authorinfo;
        PublishedOn = publishedon;
        PublishedBy = publishedby;      
    }

    public void Display()
    {
        Console.WriteLine("Book '{0}' was written by {1} {2} and published on {3}", Title, AuthorInfo.FirstName, AuthorInfo.LastName, PublishedOn.ToString("d"));
    }
    
}