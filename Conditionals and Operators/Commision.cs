// calculate commission based on the SalesAmount.

using System;

class Program
{
    public static void Main(string[] args)
    {

        Console.WriteLine("Commission & Performance reporting!!!");

        // Prompts for name and sale amount
        Console.WriteLine("Enter Sales person name");
        var salesName = Console.ReadLine();

        Console.WriteLine("Enter Sales amount");
        double salesAmount = Convert.ToDouble(Console.ReadLine());

        // Math for commission, asssigned to commision variable
        var commission = 200 + (0.09 * salesAmount);
        commission = Math.Round(commission, 2);

        // Performance review
        string performanceStatus = "default";

        switch (salesAmount)
        {
            case < 3000:
                performanceStatus = "poor";
                break;
            case < 5000:
                performanceStatus = "average";
                break;
            case < 10000:
                performanceStatus = "good";
                break;
            case < 15000:
                performanceStatus = "excellent";
                break;
            case >= 15000:
                performanceStatus = "outstanding";
                break;
        }

        // Greetings and output the commission and performance status
        Console.WriteLine("Hello " + salesName);
        Console.WriteLine("Your commission is $" + commission);
        Console.WriteLine("Your performance is " + performanceStatus);



    }
}