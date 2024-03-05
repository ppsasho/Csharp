namespace declareAndInitialize
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = new string[5] { "Dog", "Happy", "Blue", "Apple", "Jump" };
            decimal[] decimals = new decimal[5] { 3.76m, 0.92m, 5.41m, 2.18m, 6.33m };
            char[] characters = new char[5] { '$', '%', '#', '@', '*' };
            bool[] bools = new bool[5] { true, false, false, true, false };
            int[,] arrays = { { 2, 3 }, { 9, 2 }, { 6, 1 }, { 3, 5 }, { 8, 0 } };
        }
    }
}
