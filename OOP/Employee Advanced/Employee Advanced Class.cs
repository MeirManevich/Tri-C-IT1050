using System;

class Employee
{
    //create fields of the Employee Class
    private string firstname;
    private string lastname;
    private int id;
    private int age;
    private string address;
    private string phonenumber;
    private string title;
    private double yearlysalary;
    private string employmentstatus;

    //new fields that are public to control the private ones
    public string EmploymentStatus{get;set;}
    public string FirstName{get;set;}
    public string LastName{get;set;}
    public int Id{get;set;}
    //age must be at least 18
    public int Age
    {
        get
        {
            //returns private field "age"
            return age;
        }
        
        set
        {
            //controls input to private "age"
            if (value <18)
            {
                age = 18;
            }
            else
            {
                age = value;
            }
        }
    }
    //salary must be at least $1000
    public double YearlySalary
    {
        get
        {
            //same as age situation
            return yearlysalary;
        }
        
        set
        {
            if (value <1000)
            {
                yearlysalary = 1000;
            }
            else
            {
                yearlysalary = value;
            }
        }
    }
    

    //create constructer with no parameters
    public Employee()
    {
        FirstName = "Unknown";
        LastName = "unknown";
        Id = 0;
        Age = 0;
        EmploymentStatus = "active";
    }

    //create constructer with parameters
    //new parameter- empYS for salary
    public Employee(string empFN, string empLN, int empID, int empAge, double empYS)
    {
        //all pararmeters are now directed to the "get" of the public properties
        FirstName = empFN;
        LastName = empLN;
        Id = empID;
        Age = empAge;
        YearlySalary = empYS;
        EmploymentStatus = "active";
    }

    //create class method to introduce an employee
    public void Intro()
    {
        Console.WriteLine("Hello! My name is "+FirstName+" "+LastName);
        Console.WriteLine("Here are some details about me:");
        Console.WriteLine("Age:"+Age);
        Console.WriteLine("Id:"+Id);
        Console.WriteLine("Employment Status:"+EmploymentStatus);
    }

    //rewrite salary with addditional percent increase, unless input is negative
    public void IncreaseSalary(double percent)
    {
        if (percent > 0)
        {
            YearlySalary = YearlySalary + (YearlySalary*(percent/100));
            Console.WriteLine("Yearly Salary after "+percent+ " % increase = $ "+ YearlySalary);
        }
        else
        {
            Console.WriteLine("Percent should not be negative!");
        }
    }

    //sets "active" employees to "inactive" status
    public void RemoveEmployee()
    {
        if (EmploymentStatus == "active")
        {
            EmploymentStatus = "inactive";
            Console.WriteLine("Employee removed successfully!");
        }
        else
        {
            Console.WriteLine("Employee already inactive!");
        }
    }
}