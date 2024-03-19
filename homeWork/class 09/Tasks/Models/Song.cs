namespace Models
{
    public class Song
    {
        public string Title { get; set; }
        public string Length { get; set; }
        public Genre Genre { get; set; }
        public Song(string title, string length, Genre genre) 
        {
            Title = title;
            Length = length;
            Genre = genre;
        }
    }
}
