// For n number of cars, calculate the average speed given the distance travelled and time taken.

using System;

class Program
{
    public static void Main(string[] args)
    {
        //create the total speed variable
        double totalSpeed = 0;

        //get info on cars and assign to variable n
        Console.WriteLine("Enter the number of cars (n):");
        int n = Convert.ToInt32(Console.ReadLine());

        //begin loop, counter at zero and continues so long as the counter is less than n, the number of cars
        for (int counter = 0; counter < n; counter++)
        {
            //collect speed and distance data and assign to respective variables, all decimal-capable
            Console.WriteLine("Enter the distance travelled (in miles) for Car # " + (counter + 1) + " :");
            double distance = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the time travelled (in hours) for Car # " + (counter + 1) + ":");
            double time = Convert.ToDouble(Console.ReadLine());

            //assign speed for each car to this variable for the total speed
            double speed = distance / time;

            //then add the speed to the total for division later
            totalSpeed = totalSpeed + speed;
        }

        //out of loop, now divide total added speed by n, number of cars, for average speed, and print.
        double averageSpeed = totalSpeed / n;
        Console.WriteLine("Average speed of the cars is " + averageSpeed + " miles per hour");
    }
}