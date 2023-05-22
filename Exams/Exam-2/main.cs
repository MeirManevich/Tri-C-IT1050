using System;

class Program {
    //fuction that takes height and radius and returns cylinder volume
    public static double CalculateCylinderVolume(double height, double radius)
    {
        return(Math.Round(3.14*radius*radius*height,2));
    }

  
  
  public static void Main (string[] args) {
    //gather height and radius data
    Console.WriteLine ("Enter the radius (in inches)");
    double radius = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine ("Enter the height (in inches)");
    double height = Convert.ToDouble(Console.ReadLine());

    //call the volume function, print the output
    Console.WriteLine("Volume of the cylinder = "+CalculateCylinderVolume(height,radius)+" cubic inches");
  
  }
}