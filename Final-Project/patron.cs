using System;
using System.Collections.Generic;
using System.Linq;

class Patron : Person
{
    public string LibraryId { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public bool IsAccountActive { get; set; }
    public int FineAmountDue { get; set; }
    public List<Rental> RentalCart = new List<Rental>();

    public Patron(string firstname, string lastname, string id) : base()
    {
        FirstName = firstname;
        LastName = lastname;
        LibraryId = id;

        FineAmountDue = 0;
        StartDate = DateTime.Now;
        IsAccountActive = true;
    }

    public void Display()
    {
        Console.WriteLine("Patron ID={0} Name={1} {2}", LibraryId, FirstName, LastName);
    }

    public void AddToRentalCart(Book bookrental, DateTime duedate)
    {
        Rental newRent = new Rental(bookrental, DateTime.Now, duedate);
        RentalCart.Add(newRent);
        Console.WriteLine("Added to rental cart {0} for Patron {1} {2}", bookrental.Title, FirstName, LastName);
    }

    public void RemoveFromRentalCart(Book bookreturn)
    {
        Console.WriteLine("Removed from rental cart {0} for Patron {1} {2}", bookreturn.Title, FirstName, LastName);
    }


}