﻿namespace avarageNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 4 numbers:");
            string firstInput = Console.ReadLine();
            string secondInput = Console.ReadLine();
            string thirdInput = Console.ReadLine();
            string fourthInput = Console.ReadLine();

            bool fourNumbers =
                int.TryParse(firstInput, out int firstNum) & int.TryParse(secondInput, out int secondNum)
              & int.TryParse(thirdInput, out int thirdNum) & int.TryParse(fourthInput, out int fourthNum);
            if (!fourNumbers)
            {
                Console.WriteLine("You didn't enter four numbers!");
                return;
            }
            int sum = (firstNum + secondNum + thirdNum + fourthNum) / 4;
            Console.WriteLine($"The avarage of {firstNum}, {secondNum}, {thirdNum} and {fourthNum} is: {sum}");
        }
    }
}
