using System;

class Employee
{
    //create properties of the Employee Class
    private string firstname;
    private string lastname;
    private int id;
    private int age;
    private string address;
    private string phonenumber;
    private string title;
    private double yearlysalary;
    private string employmentstatus;

    //create constructer with no parameters
    public Employee()
    {
        firstname = "Unknown";
        lastname = "unknown";
        id = 0;
        age = 0;
        employmentstatus = "active";
    }

    //create constructer with four parameters
    public Employee(string employeefirstname, string employeelastname, int employeeid, int employeeage)
    {
        firstname = employeefirstname;
        lastname = employeelastname;
        id = employeeid;
        age = employeeage;
        employmentstatus = "active";
    }

    //create class method to introduce an employee
    public void Intro()
    {
        Console.WriteLine("Hello! My name is "+firstname+" "+lastname);
        Console.WriteLine("Here are some details about me:");
        Console.WriteLine("Age:"+age);
        Console.WriteLine("Id:"+id);
        Console.WriteLine("Employment Status:"+employmentstatus);
    }
}