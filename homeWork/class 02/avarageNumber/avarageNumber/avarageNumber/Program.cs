namespace avarageNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = 10;
            int secondNum = 15;
            int thirdNum = 20;
            int fourthNum = 30;
            int sum = (firstNum + secondNum + thirdNum + fourthNum) / 4;
            Console.WriteLine($"The avarage of {firstNum}, {secondNum}, {thirdNum} and {fourthNum} is: {sum}");
        }
    }
}
