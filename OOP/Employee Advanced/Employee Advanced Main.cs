using System;

class Program
{
    public static void Main(string[] args)
    {
        //create a new employee using constructor with no parameters
        Employee unknown = new Employee();
        unknown.Intro();

        //create a new employee using constructor with parameters
        Employee John = new Employee("John", "Smith", 1234, 45, 50000);
        John.IncreaseSalary(-2);
        John.RemoveEmployee();
        John.Intro();

        Employee Robert = new Employee("Robert", "Downey", 5678, 62, 100);
        Robert.Intro();

        Employee Maria = new Employee("Maria", "Lambert", 5010, 26, 80000);
        Maria.IncreaseSalary(7);
        Maria.RemoveEmployee();
        Maria.RemoveEmployee();
        Maria.Intro();
    }
}