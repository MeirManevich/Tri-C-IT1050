// convert Celsius to Farehneit.

using System;

class Program
{
    public static void Main(string[] args)
    {
        // Prompts
        Console.WriteLine("Celsius to Farenheit Conversion");

        Console.WriteLine("Enter temperature in Celsius");

        // Converts user input to double
        double Celsius = Convert.ToDouble(Console.ReadLine());
        // Celcius conversion
        double Farenheit = (Celsius * 9 / 5) + 32;

        // Print the output
        Console.WriteLine("The equivalent temperature in Farenheit is " + Farenheit +
        " degree Farenheit");

        // Conditions to print out whether the temperature is above boiling or below freezing.
        if (Farenheit < 32)
        {
            Console.WriteLine("This temperature is below freezing point of 32 degree Farenheit");

        }
        if (Farenheit > 212)
        {
            Console.WriteLine("This temperature is above boiling point of 212 degree Farenheit");
        }
    }
}
