namespace treesExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the amount of trees");
            string strTrees = Console.ReadLine();
            if(!int.TryParse(strTrees, out int trees))
            {
                Console.WriteLine("Incorrect input");
                return;
            }
            int branches = 12;
            int basket = 5;
            int apples = 8;


            int numberOfApples = trees * (branches * apples);
            int numberOfBasketsNeeded = numberOfApples / basket;
            if((numberOfApples % basket) > 0)
            {
                numberOfBasketsNeeded++;
            }
            Console.WriteLine($"You need {numberOfBasketsNeeded} baskets");
        }
    }
}