namespace ConsoleAppRevision5
{
    internal class Human
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public string GetPersonStats() => $"{FirstName} {LastName} Age: {Age}";
    }
}
