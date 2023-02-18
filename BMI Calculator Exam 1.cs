using System;

class Program {
  public static void Main (string[] args) {

    //Collect data for number of times to loop
    Console.WriteLine("Enter number of people for BMI check today: ");
    int num = Convert.ToInt32(Console.ReadLine());

    //create variables
    int counter;
    int underWeightCount=0;
    int normalCount=0;
    int overWeightCount=0;
    int obeseCount=0;
    string bmiHealthStatus = "N/A";

    //loop begins, will stop before it is equal to "num"
    for(counter = 0; counter < num; counter++)
    {
      //get data
      Console.WriteLine("Enter name: ");
      string name = Console.ReadLine();

      Console.WriteLine("Enter height in inches: ");
      double height = Convert.ToDouble(Console.ReadLine());

      Console.WriteLine("Enter weight in pounds: ");
      double weight = Convert.ToDouble(Console.ReadLine());

      //calculate BMI
      double BMI = ((703*weight)/(height*height));
      

      //conditional function to print status and increase wright counters
      switch (BMI)
      {
      case<18.5:
        bmiHealthStatus="UnderWeight";
        underWeightCount++;
        break;
      case<25:
        bmiHealthStatus="Normal";
        normalCount++;
        break;
      case<30:
        bmiHealthStatus="Overweight";
        overWeightCount++;
        break;
      case>=30:
        bmiHealthStatus="Obese";
        obeseCount++;
        break;
      }

      //Within the loop, report to each person their BMI and status
      Console.WriteLine("Hello " + name);
      Console.WriteLine("Your BMI is " + BMI);
      Console.WriteLine("Your health is " + bmiHealthStatus);  
    }

    //upon completion, report numbers of different weight classes
    Console.WriteLine("Number of people underweight = " +underWeightCount);
    Console.WriteLine("Number of people normal = " +normalCount);
    Console.WriteLine("Number of people overweight = " + overWeightCount);
    Console.WriteLine("Number of people obese = " + obeseCount);
    
  }
}