namespace Models
{
    public class Human : Character
    {
        public new string Name { get; set; }
        public new int Health { get; set; }
        public new int Strength { get; set; }
        public new int Agility { get; set; }
        public new string Race { get; set; }
        public Human(string name, int health, int strength, int agility, string race = "Human") : base(name, health, strength, agility, race)
        {

        }
    }
}
