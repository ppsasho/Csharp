using System.Security.Cryptography.X509Certificates;

namespace class_material
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            DateTime dateTime = DateTime.UtcNow;
            DateTime dateTime1 = new DateTime(2024, 3, 6);
            DateTime dateTime2 = new DateTime(2024, 3, 6, 10, 23, 50, 40);

            Console.WriteLine(dateTime.ToString());
            Console.WriteLine(dateTime1);
            Console.WriteLine(dateTime2);

            DateTime modifiedDate = dateTime2.AddSeconds(5);
            Console.WriteLine(modifiedDate);

            // Format and printing dates
            Console.WriteLine(dateTime);
            Console.WriteLine(dateTime.ToString("ddd*M*yyyy HH-mm-ss zz"));
            

            decimal euro = MKDToEurConversion(600);
            Console.WriteLine($"You converted your denar to {euro} euros");
        }


        static decimal MKDToEurConversion(int denar)
        {
            decimal euro = Math.Round(denar / 61.5m, 2);
            return euro;
        }
    }
}
