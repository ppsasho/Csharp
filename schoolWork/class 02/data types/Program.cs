namespace data_types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] students = { "Jake", "Billy", "David" };
            DateTime currentTime = DateTime.Now;
            char letter = 'b';
            int testNumber = 5;

            //  Random numbers
            Random dice = new Random();
            int randomNumber = dice.Next(0, 10);
            Console.WriteLine(randomNumber);

            //  Decimal numbers
            float avarageRate = 5.1f;

            double avarageRate2 = 3.2;

            decimal avarageRate3 = 4.2m;


            Console.WriteLine($"5 + b = {testNumber + letter} at {currentTime}");

            foreach(string student in students )
            {
                Console.WriteLine($"Student #{Array.IndexOf(students, student) + 1} {student}");
            }

            //  Operators

            int num1 = 6;
            int num2 = 3;
            num1 += num2;
            Console.WriteLine($"The result is {num1}");

            int sum1 = num1 + ++num2;
            int sum2 = num1 + num2++;
            Console.WriteLine(sum1);
            Console.WriteLine(sum2);

            

        }
    }
}       