namespace exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            DateTime dateOfBirth = DateTime.Today.AddYears(20);
            
            Human trainer = new Human();
            trainer.FirstName = "Sasho";
            trainer.LastName = "Popovski";
            trainer.DateOfBirth = new DateTime(2004, 10, 01);
            string personStats = trainer.GetPersonStats();
            Console.WriteLine(personStats);

            Human trainer2 = new Human("Slave", "Ivanovski", dateOfBirth);
            //  OR
/*            {
                FirstName = "Slave",
                LastName = "Ivanovski",
                DateOfBirth = DateTime.Now.AddYears(-20)
            };*/

            Console.WriteLine(trainer2.GetPersonStats());
/*            string firstName = GetStringInputFromConsole("Vnesete ime:");
            string lastName = GetStringInputFromConsole("Vnesete prezime");*/
            /*            Human trainer3 = new Human()
                        {
                            FirstName = firstName,
                            LastName = lastName
                        };

                        Console.WriteLine(trainer3.GetPersonStats());*/
            Human trainer3 = new Human(GetStringInputFromConsole("Vnesete ime:"), GetStringInputFromConsole("Vnesete prezime:"), DateTime.Now);
            Console.WriteLine(trainer3.GetPersonStats());
            
        }
        public static string GetStringInputFromConsole(string displayMessage)
        {
            Console.WriteLine(displayMessage);
            string input = Console.ReadLine();

            return input;
        }
    }
}
