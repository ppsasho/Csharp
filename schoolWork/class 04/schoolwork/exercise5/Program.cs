namespace exercise5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int[] array = new int[0];

                do
                {
                    Console.WriteLine("Enter a number: ");
                    string input = Console.ReadLine();
                    if (!int.TryParse(input, out int number))
                    {
                        Console.WriteLine("Wrong input");
                        continue;
                    }

                    Array.Resize(ref array, array.Length + 1);
                    array[array.Length - 1] = number;

                    Console.WriteLine("Do you want to keep adding numbers? (Y/N):");
                    string option = Console.ReadLine();
                    string upperOption = option.ToUpper();
                    if (upperOption != "Y")
                    {
                        break;
                    }

                } while (true);
                int sum = array.Sum();
                Console.WriteLine($"The sum is {sum}");
            }

        }
    }
}
