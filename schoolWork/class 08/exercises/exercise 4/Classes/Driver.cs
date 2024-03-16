namespace exercise_4.Classes
{
    public class Driver
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public Driver(string name, int level)
        {
            Name = name;
            Level = level;
        }
        public Driver(string name)
        {
            Name = name;
        }
    }
}
