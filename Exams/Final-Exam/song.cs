using System;
using System.Collections.Generic;
using System.Linq;

class Song
{
    public string ID { get; set; }
    public string Title { get; set; }
    public Artist ArtistInfo { get; set; }

    public Song()
    {  
    }

    public Song(string id, string title)
    {
        if (id.Length != 10)
        {
            Console.WriteLine("Id length should be 10");
        }
        ID = id;
        Title = title;
    }

    public void AddArtistInfo(Artist newArtist)
    {
        ArtistInfo = newArtist;
        Console.WriteLine("Artist {0} {1} added to Song {2}", 
            ArtistInfo.FirstName, ArtistInfo.LastName, Title);
    }
    
    public void Display()
    {
        Console.WriteLine("Song id = {0} : Title={1} : Artistname = {2} {3}",
            ID, Title, ArtistInfo.FirstName, ArtistInfo.LastName);
    }
}