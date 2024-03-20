using Models;
namespace Songs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Song song1 = new("Dear Mama", 278, Genre.Hip_Hop);
            Song song2 = new("Ms.Jackson", 270, Genre.Hip_Hop);
            Song song3 = new("Big Pimpin", 274, Genre.Hip_Hop);
            Song song4 = new("Strobe", 634, Genre.Techno);
            Song song5 = new("Insomnia", 216, Genre.Techno);
            Song song6 = new("Blue Monday", 459, Genre.Techno);

            List<Song> songs = new()
            {
                song1, song2, song3, song4, song5, song6
            };

            List<Song> technoSongs = songs.Where(x => x.Genre == Genre.Techno).ToList();
            List<Song> hipHopSongs = songs.Where(x => x.Genre == Genre.Hip_Hop).ToList();

            List<string> sixMinuteSongs = songs.Where(x => x.Length > 360).Select(x => $"{x.Title} ({x.Length}s)").ToList();
            foreach (string s in sixMinuteSongs) Console.WriteLine(s);

            Song foundSong = songs.First(x => x.Title.ToLower().Contains("so"));
            Console.WriteLine($"Fist song that contains 'so' in the title: {foundSong.Title}");

            Song findSongOrDefault = songs.FirstOrDefault(x => x.Title.ToLower().Contains("mons"));
            if (findSongOrDefault != null) Console.WriteLine(findSongOrDefault); // Handled exception
            else Console.WriteLine("No song found that contains 'mons'");

            //  Unhandled exception
            try
            {
                Song findSong = songs.First(x => x.Title.Contains("Sasho"));
                Console.WriteLine(findSong);
            } catch (Exception ex)
            {
                Console.WriteLine($"\nError happened : {ex}\n Please try again.\n");
            }
            

            List<string> songsOrdered = songs.OrderBy(x => x.Length).Select(x => $"{x.Title} ({x.Length}s)").ToList();
            Console.WriteLine("Songs ordered by ascending order:\n");
            foreach(string s in  songsOrdered) Console.WriteLine(s);
            Console.WriteLine("\n");

            List<IGrouping<Genre, Song>> groupedSongs = songs.GroupBy(x => x.Genre).ToList();
            //foreach(IGrouping<Genre, Song> group in groupedSongs)
            //{
            //    Console.WriteLine(group.Key);
            //    foreach(Song s in   )
            //    {
            //        Console.WriteLine(s.Title);
            //    }
            //}

            List<Song> songsForJerry = songs.Where(x => x.Title.StartsWith("B")).ToList();
            List<Song> songsForMaria = songs.Where(x => x.Length > 360).ToList();
            List<Song> songsForJane = songs.Where(x => x.Genre == Genre.Rock).ToList();
            List<Song> songsForStephen = songs.Where(x => x.Length < 180 && x.Genre == Genre.Hip_Hop).ToList();

            Person person1 = new(1, "Mitre", "Mitkovski", 25, Genre.Hip_Hop, songs);
            Person person2 = new(2, "Bob", "Bobsky", 30, Genre.Techno, new List<Song>());

            Person person3 = new(3, "Jerry", "Mason", 24, Genre.Techno, new List<Song>());
            Person person4 = new(4, "Maria", "Manes", 19, Genre.Classical, new List<Song>());
            Person person5 = new(5, "Jane", "Smith", 35, Genre.Rock, new List<Song>());
            Person person6 = new(6, "Stephen", "Johnson", 21, Genre.Hip_Hop, new List<Song>());
            person3.FavouriteSongs = songsForJerry;
            person4.FavouriteSongs = songsForMaria;
            person5.FavouriteSongs = songsForJane;
            person6.FavouriteSongs = songsForStephen;

            List<Person> fans = new()
            {
                person3, person4, person5, person6
            };

            person1.GetFavouriteSongs();
            person2.GetFavouriteSongs();
            person3.GetFavouriteSongs();
            person4.GetFavouriteSongs();
            person5.GetFavouriteSongs();
            person6.GetFavouriteSongs();
        }
    }
}
