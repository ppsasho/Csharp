namespace ConsoleAppRevision4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] intArray1 = new int[2];
            intArray1[0] = 4;
            intArray1[1] = 5;
            Console.WriteLine($"First num in the array is {intArray1[0]} and the second num is {intArray1[1]}");
            double[] doubleArray = new double[] { 2.4, 11, 12, 534, 0.99 };
            for (int i = 0; i < doubleArray.Length; i++)
            {
                Console.WriteLine(doubleArray[i]);
            }
            Console.WriteLine("Now to reverse the array..");
            Console.ReadLine();
            Array.Reverse( doubleArray );
            for (int i = 0; i < doubleArray.Length; i++)
            {
                Console.WriteLine(doubleArray[i]);
            }

            int indexFound = Array.IndexOf(doubleArray, 2.4);
            Console.WriteLine($"The index found for the number is {indexFound}, if we try to use the index we get {doubleArray[indexFound]}");
        }
    }
}
