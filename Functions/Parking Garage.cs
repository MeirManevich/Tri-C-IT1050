using System;

class Program
{
    //function to calculate charges with parameter for hours parked
    public static double CalculateCharges(double hours)
    {

        //intermediate variable for simplicity
        double garageFee =0;
        
        //condition to add $0.50 for each hour after 3
        if(3<=hours)
        {
            garageFee = 0.50*(Convert.ToInt32(hours)-3);
        }
        
        double totalCost = 2.00+garageFee;
        
        //unless the price goes beyong $10, then stick with $10
        if (totalCost >= 10)
        {
            totalCost = 10;
        }
        
        //return the calculated cost
        return totalCost;
    }

    //main function, where fun happens
    public static void Main (string[] args)
    {
        //counter for the loop and strings to identify the customer
        int counter;

        //get data customer data
        Console.WriteLine("Enter how many customers you want to process now:");
        int numCustomer = Convert.ToInt32(Console.ReadLine());

        //loop to calculate chages for each car
        for(counter =1; counter<=numCustomer; counter++)
        {
            Console.WriteLine("Enter total hours parked by Customer # "+counter);
            double totalHours = Convert.ToDouble(Console.ReadLine());

            //send totalHours as parameter for the CalculateCharges() function
            //store return value in totalCharges
            double totalCharges = CalculateCharges(totalHours);

            //output
            Console.WriteLine("Total Charges for Customer # " +counter+" = $"+                     totalCharges);
        }
    }

}