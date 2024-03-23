using System.ComponentModel;

namespace Models
{
    public class Dwarf : Character
    {
        public new string Name {  get; set; }
        public new int Health {  get; set; }
        public new int Strength { get; set; }
        public new int Agility { get; set; }
        public string Race { get; set; }
        public Dwarf(string name, int health, int strength, int agility, string race = "Dwarf") : base(name, health, strength, agility, race)
        {

        }


    }
}
