using System;

class Program 
{
  public static void Main (string[] args) 
    {
        Faculty f = new Faculty();

        Console.WriteLine("Enter first name:");
        f.FirstName= Console.ReadLine();

        Console.WriteLine("Enter last name:");
        f.LastName= Console.ReadLine();

        Console.WriteLine("Enter Employer name:");
        f.Employer= Console.ReadLine();

        Console.WriteLine("Enter Title:");
        f.Title= Console.ReadLine();

        Console.WriteLine("Enter date of employment:");
        f.DateOfEmployment= Convert.ToDateTime(Console.ReadLine());

        Faculty f2 = new Faculty(f.FirstName,f.LastName);
        f2.DateOfEmployment = f.DateOfEmployment;
        f2.Title = f.Title;
        f2.Employer = f.Employer;
        f2.PermanentAddress.AddressLine1 = "123 Main Street";
        f2.PermanentAddress.AddressLine2 = "(Next to Subway)";
        f2.PermanentAddress.City = "Parma";
        f2.PermanentAddress.State = "OH";
        f2.PermanentAddress.Zipcode= "44143";

        f2.Intro();
        f2.Promote();
        f2.Promote();
        f2.GrantTenure();
        f2.GrantTenure();
    }
}