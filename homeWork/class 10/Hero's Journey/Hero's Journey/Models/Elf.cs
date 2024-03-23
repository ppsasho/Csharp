namespace Models
{
    public class Elf : Character
    {
        public new string Name { get; set; }
        public new int Health { get; set; }
        public new int Strength { get; set; }
        public new int Agility { get; set; }
        public string Race { get; set; }
        public Elf(string name, int health, int strength, int agility, string race = "Elf") : base(name, health, strength, agility, race)
        {

        }
    }
}
