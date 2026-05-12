using Models;

namespace Class5HomeworkRevision
{
    public static class StaticDB
    {
        public static List<Car> Cars = new() 
        { 
            new() { Model = "Hyundai", Speed = 30 },
            new() { Model = "Mazda", Speed = 34 },
            new() { Model = "Ferrari", Speed = 40 },
            new() { Model = "Porsche", Speed = 45 }
        };

        public static List<Driver> Drivers = new() 
        {
            new() {Name = "Bob", Skill = 10 },
            new() {Name = "Greg", Skill = 5 },
            new() {Name = "Jill", Skill = 20 },
            new() {Name = "Anne", Skill = 30 },
        };
    }
}
