namespace countUp_Down
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum;
            int secondNum;
            while (true)
            {
                Console.WriteLine("Enter a number:");
                string firstInput = Console.ReadLine();

                if (int.TryParse(firstInput, out firstNum))
                {
                    break;
                }
                Console.WriteLine("The number is invalid!");
            }

            Console.WriteLine($"Counting up to {firstNum}..");
            for(int i = 1; i <= firstNum; i++)
            {
                Console.WriteLine(i);
            }
            
            while (true)
            {
            Console.WriteLine("Enter a second number:");
            string secondInput = Console.ReadLine();

            if(int.TryParse(secondInput, out secondNum))
            {
                break;
            }
                Console.WriteLine("The number is invalid!");
            }

            Console.WriteLine($"Counting down from {secondNum}..");
            for (int i = secondNum; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}
