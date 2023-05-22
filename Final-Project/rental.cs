using System;
using System.Collections.Generic;
using System.Linq;

class Rental
{
    public Book book {get;set;}
    public DateTime DateRented {get;set;}
    public DateTime DateDue {get;set;}

    public Rental(Book abook, DateTime adate, DateTime anotherdate)
    {
        book = abook;
        DateRented = adate;
        DateDue = anotherdate;
    }
}