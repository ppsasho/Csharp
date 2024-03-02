namespace Exercise_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            while (true)
            {
                Console.WriteLine("Please enter a number");
                string input = Console.ReadLine();

                if(int.TryParse(input, out number))
                {
                    break;
                }
                Console.WriteLine("Please try again");
            }
            int counter = 0;
            for (int i = 1; i <= number; i++){
                if(i % 3 == 0 ||  i % 7 == 0) 
                {
                    continue;
                }
                Console.WriteLine(i);
                counter++;
                if (counter == 100)
                {
                    break;
                }
            }
        }
    }
}
