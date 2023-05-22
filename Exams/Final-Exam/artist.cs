using System;
using System.Collections.Generic;
using System.Linq;

class Artist
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }

    public Artist()
    {
        FirstName = "Unknown";
        LastName = "Unknown";
        Email = "Unknown";
    }

    public Artist(string fname, string lname)
    {
        FirstName = fname;
        LastName = lname;
        Email = "Unknown";
    }

    public void Display()
    {
        Console.WriteLine("Artist name is: {0} {1}", FirstName, LastName);
    }
}