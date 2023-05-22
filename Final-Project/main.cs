using System;

class Program 
{
  public static void Main (string[] args) 
    {
        Author Ted = new Author("Ted", "Nail", "12345");
        Author Grace = new Author("Grace", "Malcom", "6789");
        Console.WriteLine("Author Info:");
        Ted.DisplayInfo();
        Grace.DisplayInfo();
        Console.WriteLine("\n");

        Book Flower = new Book("1321","Falling Flowers", Ted);
        Book Bee = new Book("1322","Busy Bees", Grace);
        Book Rain = new Book("1323","Rampant Rain", Ted);
        Book Grass = new Book("1324","Glowing Grass", Grace, DateTime.Now, "Penguin");
        Book Tomato = new Book("1325","Telling Tomatoes", Ted, DateTime.Now, "Penguin");
        Book Owl = new Book("1326","Occupied Owls", Grace, DateTime.Now, "Penguin");

        Ted.AddBook(Flower);
        Ted.AddBook(Rain);
        Ted.AddBook(Tomato);
        
        Console.WriteLine("Displaying Ted's books");
        Ted.DisplayBooks();
        Console.WriteLine("\n");

        
        Grace.AddBook(Bee);
        Grace.AddBook(Grass);
        Grace.AddBook(Owl);
        
        Console.WriteLine("Displaying Grace's books");
        Grace.DisplayBooks();
        Console.WriteLine("\n");

        Ted.RemoveBook("1321");
        Console.WriteLine("Displaying Ted's books, with the 1st book removed");
        Ted.DisplayBooks();   
        Console.WriteLine("\n");

        Patron Hugo = new Patron("Hugo", "Said", "L1111");
        Patron Gaston = new Patron("Gaston", "Said", "L1112");
        Patron Otto = new Patron("Otto", "Said", "L1113");
        Patron Arlo = new Patron("Arlo", "Said", "L1114");
        Patron Atlas = new Patron("Atlas", "Said", "L1115");
        
        Hugo.AddToRentalCart(Flower, DateTime.Now.AddDays(7));
        Hugo.RemoveFromRentalCart(Rain);
        Hugo.Display();
        
    }
}