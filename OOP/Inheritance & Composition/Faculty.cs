using System;

class Faculty : Person
{
    public string Id { get; set; }
    public string Title { get; set; }
    public string Employer { get; set; }
    public decimal YearlySalary { get; set; }
    public bool Tenured { get; set; }
    public DateTime DateOfEmployment;


    public Faculty() : base()
    {
        Title = "Instructer";
    }

    public Faculty(string fname, string lname) : base(fname, lname)
    {
        Title = "Instructer";
    }



    public bool GrantTenure()
    {
        if (DateOfEmployment.Year < DateTime.Today.Year - 5 && Tenured != true)
        {
            Tenured = true;
            Console.WriteLine("Tenure granted for " + FirstName + " " + LastName);
            return true;
        }
        if (Tenured == true)
        {
            Console.WriteLine("Faculty " + FirstName + " " + LastName + " is already tenured!");
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool Promote()
    {
        if (Title == "Instructor" && (DateOfEmployment.Year+2) < DateTime.Today.Year)
        {
            Title = "Assistant Professor";
            Console.WriteLine("Faculty " + FirstName + " " + LastName + " promoted to Assistant Professor rank");
            return true;
        }
        if (Title == "Assistant Professor" && (DateOfEmployment.Year+5) < DateTime.Today.Year)
        {
            Title = "Associate Professor";
            Console.WriteLine("Faculty " + FirstName + " " + LastName + " promoted to Associate Professor rank");
            return true;
        }
        if (Title == "Associate Professor")
        {
            if ((DateOfEmployment.Year+11) < DateTime.Today.Year)
            {
                Title = "Professor";
                Console.WriteLine("Faculty " + FirstName + " " + LastName + " promoted to Professor rank");
                return true;
            }

            else if ((DateOfEmployment.Year+11) > DateTime.Today.Year)
            {
                Console.WriteLine("Faculty " + FirstName + " " + LastName + " needs more experience for Promotion");
                return true;
            }

        }
        if (Title == "Professor")
        {
            Console.WriteLine("Faculty " + FirstName + " " + LastName + " cannot be promoted anymore as he/she holds the highest rank already!");
            return true;
        }
        else
        {
            return false;
        }
    }

    public override void Intro()
    {
        base.Intro();
        Console.WriteLine("I work as " + Title + " at " + Employer + " since " + DateOfEmployment.Year);
    }
}