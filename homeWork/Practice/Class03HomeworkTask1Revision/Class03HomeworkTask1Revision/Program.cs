namespace Class03HomeworkTask1Revision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter the first number:");
                string firstInput = Console.ReadLine();
                Console.WriteLine("Enter the second number:");
                string secondInput = Console.ReadLine();

                bool GoodNumberInput = 
                    int.TryParse(firstInput, out int firstNumber)
                  & int.TryParse(secondInput, out int secondNumber);

                if (!GoodNumberInput) {
                    Console.Clear();
                    Console.WriteLine("Please make sure to enter numbers!");
                    continue;
                } else
                {
                    while (true)
                    {
                        Console.WriteLine("Choose an operator:\n" +
                            "1) +\n" +
                            "2) -\n" +
                            "3) *\n" +
                            "4) /\n");
                        bool GoodOperatorInput = int.TryParse(Console.ReadLine(), out int chosenOperator);
                        if (!GoodOperatorInput)
                        {
                            Console.Clear();
                            Console.WriteLine("Please pick the number next to the options!");
                            continue;
                        } else {
                            Console.WriteLine("Calculating...");
                            int result = 0;
                            switch (chosenOperator)
                            {
                                case 1:
                                    result = firstNumber + secondNumber;
                                    break;
                                case 2:
                                    result = firstNumber - secondNumber;
                                    break;
                                case 3:
                                    result = firstNumber * secondNumber;
                                    break;
                                case 4:
                                    result = firstNumber / secondNumber;
                                    break;

                                default:
                                    Console.Clear();
                                    Console.WriteLine("Please pick between the options in the menu!");
                                    continue;
                            }
                            Console.WriteLine($"The result of the operation is {result}");
                            
                            break;
                        }
                    }
                    Console.WriteLine("App completed!");
                    break;
                }
            }
        }
    }
}
