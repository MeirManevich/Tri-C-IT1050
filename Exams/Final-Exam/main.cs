using System;

class Program 
{
  public static void Main (string[] args) 
    {
        Artist Yabba = new Artist("yabba", "dabba");
        Yabba.Display();
        Console.WriteLine("\n");

        Song Morning = new Song("1212121212", "Morning");
        Morning.AddArtistInfo(Yabba);
        Console.WriteLine("\n");

        Morning.Display();
        Console.WriteLine("\n");

        Album Bloop = new Album("Bloop");
        Bloop.AddSong(Morning);
        Console.WriteLine("\n");

        Bloop.DisplaySongs();
        Console.WriteLine("\n");

        Bloop.RemoveSong("1212121212");
        Console.WriteLine("\n");

        Bloop.DisplaySongs();
        
    }
}