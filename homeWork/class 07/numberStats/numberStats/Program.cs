namespace numberStats
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                NumberStats();

                string choice = GetInput("Do you want to try again?(Y / X)");
                switch(choice.ToUpper())
                {
                    case "Y":
                        continue;

                    case "X":
                    default:
                        return;
                }
            }
        }
        static string GetInput(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();
            return input;
        }
        static void NumberStats()
        {
            int wholeNum;
            decimal decimalNum = 0;
            string type = "Why did you pick 0?";
            string polarity = "Why did you pick 0?";
            string parity = "Why did you pick 0?";

            while (true)
            {
                string input = GetInput("Please enter a number (Preferably not 0):");
                if (!int.TryParse(input, out wholeNum) && !decimal.TryParse(input, out decimalNum))
                {
                    Console.WriteLine("Please make sure you enter a number.");
                    continue;
                }
                break;
            }

            if (wholeNum != 0)
            {
                Console.WriteLine($"Stats for number: {wholeNum}");
                type = "Integer";

                if (wholeNum < 0)
                {
                    polarity = "Negative";
                } else
                {
                    polarity = "Positive";
                }

                if (wholeNum % 2 == 0)
                {
                    parity = "Even";
                } else
                {
                    parity = "Odd";
                }

            } else if (decimalNum != 0)
            {
                Console.WriteLine($"Stats for number: {wholeNum}");
                type = "Decimal";
                if (decimalNum < 0)
                {
                    polarity = "Negative";
                }
                else
                {
                    polarity = "Positive";
                }

                if (decimalNum % 2 == 0)
                {
                    parity = "Even";
                }
                else
                {
                    parity = "Odd";
                }
            }
            Console.WriteLine(polarity);
            Console.WriteLine(type);
            Console.WriteLine(parity);
        }
    }
}
