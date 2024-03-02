namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // FOR

            for(int i = 10; i > 0; i--)
            {
                Console.WriteLine(i);
            }
            int k = 0;
            for(;k < 10; k++)
            {
                Console.WriteLine(k);
            }

            //  While
            int z = 40;
            do
            {
                Console.WriteLine(z);
            } while (z > 40);
        }
    }
}
