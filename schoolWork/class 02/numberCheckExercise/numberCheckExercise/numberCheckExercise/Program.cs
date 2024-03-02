namespace numberCheckExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers:");
            string firstNumStr = Console.ReadLine();
            string secondNumStr = Console.ReadLine();

            if (!(int.TryParse(firstNumStr, out int firstNum) & int.TryParse(secondNumStr, out int secondNum))     ){
                Console.WriteLine("Wrong input");
                return;
            }

            int largerNumber = Math.Max(firstNum, secondNum);
            Console.WriteLine($"The larger number is {largerNumber}");

            if(firstNum % 2  == 0 && secondNum % 2 == 0)
            {
                Console.WriteLine($"{firstNum} and {secondNum} are even!");
            }
            else if(firstNum % 2 == 0)
            {
                Console.WriteLine($"{firstNum} is even!");
            }
            else if(secondNum % 2 == 0) 
            {
                Console.WriteLine($"{secondNum} is even");
            }
            else
            {
                Console.WriteLine("Both numbers are odd!");
            }

        }
    }
}