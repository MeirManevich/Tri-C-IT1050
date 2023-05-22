using System;
using System.Collections.Generic;
using System.Linq;

class Roster
{   
    public string CRN {get; set;}
    private List<Student> ListOfStudents = new List<Student>();

    public Roster(string crn)
    {
        CRN = crn;
    }

    public void DisplayList()
    {
        Console.WriteLine("List of students in the Roster for CRN = " +CRN);
        foreach (var i in ListOfStudents)
        {
            Console.WriteLine(i.FirstName+" "+i.LastName);
        }
    }

    public void Add(Student s)
    {
        ListOfStudents.Add(s);
        Console.WriteLine("Student Added!");
        
    }

    public void Remove(string id)
    {
        var a = ListOfStudents.Find(x => x.Id == id);
        ListOfStudents.Remove(a);
        Console.WriteLine("Student removed!");
    }
    
  
 
}
