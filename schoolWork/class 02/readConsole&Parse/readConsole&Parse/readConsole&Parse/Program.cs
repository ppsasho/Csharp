namespace readConsole_Parse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a num");
            string input = Console.ReadLine();

            bool success = int.TryParse(input, out int result );

            if(!success)
            {
                Console.WriteLine("Wrong input!");
            }
            Console.WriteLine($"Using TryParse: {result}");

            //int newNum = Convert.ToInt32(input);
            //Console.WriteLine($"Using Convert: {newNum}");

            if (result > 0) 
            {
                Console.WriteLine("It's a number!");
            } else {
                Console.WriteLine("It's not a number!");
            }
            
            
        }
    }
}