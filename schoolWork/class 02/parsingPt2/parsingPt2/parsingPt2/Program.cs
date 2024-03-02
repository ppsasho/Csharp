namespace parsingPt2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a rating");
            string input = Console.ReadLine();

            if(!decimal.TryParse(input, out decimal rating))
            {
                Console.WriteLine($"Wrong input");
                return;
            }
            Console.WriteLine($"Your rating has been submitted, thanks for your review! ({rating})*");           
        
            
        }
    }
}