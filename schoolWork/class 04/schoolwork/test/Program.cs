using System.Linq.Expressions;

namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = {"Asmond", "Sasho"};

            Console.WriteLine(names[0]);
            string[] reversedArray = names.Reverse().ToArray();
            Console.WriteLine(reversedArray[0]);

            int[] numbers = { 1, 2, 3 };
            Array.Resize(ref numbers, numbers.Length + 1);
            numbers[numbers.Length - 1] = 5;
            Console.WriteLine(numbers[numbers.Length - 1]);
            int index = Array.IndexOf(numbers, 5);
            Console.WriteLine($"The index of {5} is {index}");

            string[] students = new string[2] { "C# Basic", "subject 1" };

            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine(students[i]);
            }
            foreach (string student in students)
            {
                Console.WriteLine(student);
            }
            int[] newNumbers = numbers;//doesn't take numbers as a reference


        }
    }
}
