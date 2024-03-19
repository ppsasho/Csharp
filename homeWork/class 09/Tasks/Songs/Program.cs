using System.Collections.Generic;
using Models;
namespace Songs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Song song1 = new("Dear Mama", "4:38", Genre.Hip_Hop);
            Song song2 = new("Ms.Jackson", "4:30", Genre.Hip_Hop);
            Song song3 = new("Big Pimpin", "4:44", Genre.Hip_Hop);
            Song song4 = new("Strobe", "10:34", Genre.Techno);
            Song song5 = new("Insomnia", "3:36", Genre.Techno);
            Song song6 = new("Blue Monday", "7:29", Genre.Techno);

            List<Song> songs = new();
            songs.Add(song1);
            songs.Add(song2);
            songs.Add(song3);
            songs.Add(song4);
            songs.Add(song5);
            songs.Add(song6);

            Person person1 = new(1, "Mitre", "Mitkovski", 25, Genre.Hip_Hop, songs);
            Person person2 = new(2, "Bob", "Bobsky", 30, Genre.Techno, new List<Song>());
            person1.GetFavouriteSongs();
            person2.GetFavouriteSongs();
        }
    }
}
