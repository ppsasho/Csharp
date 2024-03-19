namespace Models
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Genre FavoriteMusicType { get; set; }
        public List<Song> FavouriteSongs { get; set; }

        public Person(int id, string firstName, string lastName, int age, Genre favouriteMusicType, List<Song> favouriteSongs) 
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            FavoriteMusicType = favouriteMusicType;
            FavouriteSongs = favouriteSongs;
        }
        public void GetFavouriteSongs()
        {
            if (FavouriteSongs.Count() < 1) Console.WriteLine($"{FirstName} listens to paint dry since he doesn't have any favourite songs");
            else { Console.WriteLine($"{FirstName}'s favourite songs:"); foreach (Song song in FavouriteSongs) Console.WriteLine($"{song.Title} - {song.Length} [{song.Genre}]"); }
        }
    }
}
