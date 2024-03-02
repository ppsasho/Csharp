using System.Text;

namespace InfiniteLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Внесете број:");

            int number;

            while (true)
            {
                string input = Console.ReadLine();

                if (int.TryParse(input, out number))
                {
                    Console.WriteLine(number);
                    break;
                }
                    Console.WriteLine("Невалиден влез");
            }

            Console.WriteLine(number);


        }
    }
}
