// Determine if a number is prime or not. 

using System;

class Program {
  public static void Main (string[] args) {

    //create intiger variables
    int remainder = 0;
    int divisorCounter = 0;
    int counter = 0;

    //get initial number from user and assign to "num"
    Console.WriteLine("Enter a number : ");
    int num = Convert.ToInt32(Console.ReadLine());

    //loop begins, dependant on counter being less than num but more than 2.
    for(counter = 2; counter < num; counter++)
    {
      //assign remainder to variable
      remainder = (num%counter);

      //begin if statement- if no remainder, then no prime
      if (remainder == 0)
      {
        Console.WriteLine("The number " +num+ " is divisible by " +counter);
        divisorCounter++;
        break;
      }
      else
      {
        Console.WriteLine("The number " +num+ " is NOT divisible by " +counter);
      }
    }

    //print the divisor counter
    Console.WriteLine("Divisor count = " +divisorCounter );

    //if the count is zero then we have a prime number
    if(divisorCounter==0)
    {
      Console.WriteLine("The number " +num+ " is a prime number");
    }
    else
    {
      Console.WriteLine("The number " +num+ " is not a prime number");
    }
      
  }
}