using System;
using System.Collections.Generic;
using System.Linq;

class Author : Person
{
    private List<Book> ListOfBooks = new List<Book>();

    public Author() : base()
    {
    }
    public Author(string fname, string lname, string ssn) : base(fname,lname,ssn)
    {
    }

    public void DisplayInfo()
    {
        Console.WriteLine("{0} {1}, {2}", FirstName,LastName,Email);
    }

    public void DisplayBooks()
    {
        foreach (var i in ListOfBooks)
        {
            i.Display();
        }
    }

    public void AddBook(Book NewBook)
    {
        ListOfBooks.Add(NewBook);
    }

    public void RemoveBook(string isbn)
    {
        var a = ListOfBooks.Find(x => x.ISBN == isbn);
        ListOfBooks.Remove(a);
    }
}
