using System;

class Program 
{
  public static void Main (string[] args)
    {
        //create a new employee using constructor with no parameters
        Employee unknown = new Employee();
        unknown.Intro();

        //create a new employee using constructor with parameters
        Employee John = new Employee("John", "Smith", 1234, 45);
        John.Intro();
    }
}