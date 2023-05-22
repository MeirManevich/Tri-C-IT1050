using System;
using System.Collections.Generic;
using System.Linq;

class Album
{
    public string Title { get; set; }
    public List<Song> SongList = new List<Song>();

    public Album(string title)
    {
        Title = title;
    }

    public void AddSong(Song newSong)
    {
        SongList.Add(newSong);
        Console.WriteLine("Song {0} has been added to Album {1}", 
            newSong.Title, Title);
    }

    public void RemoveSong(string id)
    {
        var a = SongList.Find(x => x.ID == id);
        SongList.Remove(a);
        Console.WriteLine("Song {0} has been removed from the Album {1}", 
            a.Title, Title);
    }

    public void DisplaySongs()
    {
        Console.WriteLine("Songs from Album {0}:", Title);
        foreach (var i in SongList)
        {
            i.Display();
        }
    }
}