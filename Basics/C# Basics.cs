// Program will calculate the total price of an item.

using System;

class Program
{
    public static void Main(string[] args)
    {

        // Declare variables
        string itemName;
        int quantity;
        double unitPrice;
        double totalPrice;


        // Create Prompts
        Console.WriteLine("Enter item name");
        itemName = Console.ReadLine();
      
        Console.WriteLine("Enter quantity");
        quantity = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter unit price");
        unitPrice = Convert.ToDouble(Console.ReadLine());


        // Calculations
        totalPrice = unitPrice * quantity;
        // Round it up
        totalPrice = Math.Round(totalPrice, 2);

        // Display final output
        Console.WriteLine("Total price of item = $" + totalPrice);



    }
}