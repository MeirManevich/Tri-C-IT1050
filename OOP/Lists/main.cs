using System;

class Program 
{
  public static void Main (string[] args) 
    {
        string crn;
        string fname;
        string lname;
        string ssn;
        string id;
        double gpa;
        Student s;

        Console.WriteLine("Enter CRN for creating Roster: ");
        crn = Console.ReadLine();

        Roster r = new Roster(crn);

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Enter first name:");
            fname = Console.ReadLine();
            Console.WriteLine("Enter last name:");
            lname = Console.ReadLine();
            Console.WriteLine("Enter SSN:");
            ssn = Console.ReadLine();
            Console.WriteLine("Enter ID:");
            id = Console.ReadLine();
            Console.WriteLine("Enter GPA:");
            gpa = Convert.ToDouble(Console.ReadLine());
            s = new Student(fname, lname, ssn, id, gpa);
            r.Add(s);
        }

        r.DisplayList();

        Console.WriteLine("Enter id of student to remove from Roster:");
        id = Console.ReadLine();
        r.Remove(id);

        r.DisplayList();

        
        
    }
}