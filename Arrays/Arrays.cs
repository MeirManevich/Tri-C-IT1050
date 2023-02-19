using System;
using System.Linq;

class Program
{
    public static void Main(string[] args)
    {

        //create arrays length 7
        double[] celsius = new double[7];
        double[] fahrenheit = new double[7];

        //loop 0-6
        for (int day = 0; day < 7; day++)
        {
            //get celsius input
            Console.WriteLine("Enter temperature in Celsius");
            //place each input into each array; unaltered celsius and 
            // calculated fahrenheit (rounded to 2 decimals)
            celsius[day] = Convert.ToDouble(Console.ReadLine());
            fahrenheit[day] = Math.Round(((celsius[day] * 9 / 5) + 32), 2);

            //print the conversion
            Console.WriteLine("Farenheit equivalent of " + celsius[day] + " degree celsius is " + fahrenheit[day]);
        }

        Console.WriteLine("Farenheit in descending order:");

        //sort arry ascending and then reverse
        Array.Sort(fahrenheit);
        Array.Reverse(fahrenheit);

        //create sum variable outside loop
        double sum = 0;

        //loop to print all fahrenheit and add each one to "sum"
        foreach (double i in fahrenheit)
        {
            Console.WriteLine(i);
            sum += i;
        }

        //calculate the average fahrenheit using the sum and print results
        double avg = (Math.Round(sum / 7, 2));
        Console.WriteLine("Average temperature is " + avg + " degree Farenheit");
    }
}