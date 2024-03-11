using System.Text;

namespace dateTimeExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = UTF8Encoding.UTF8;
            DateTime today = DateTime.Today;

            DateTime threeDays = today.AddDays(3);
            Console.WriteLine($"Three days from now: {threeDays}");

            DateTime oneMonthAhead = today.AddMonths(1);
            Console.WriteLine($"One month ahead of now: {oneMonthAhead}");

            Console.WriteLine($"Date that is one month and three days from now: {AddDaysAndMonths(3, 1)}");

            Console.WriteLine($"Current month: {today.Month}, current year: {today.Year}");

            string dateWithFullMonth = today.ToString("MMMM");
            Console.WriteLine(dateWithFullMonth);

            
        }
        //  public - access modifier, defines from where this method can be accessed
        //  static - because we want to use this methodin the Main function, we define it as static
        //  DateTime - return time, result that the method returns
        //  parameter types must be specified
        public static DateTime AddDaysAndMonths(int days, int months)
        {
            DateTime now = DateTime.Now;

            return now.AddDays(days).AddMonths(months);
        }
    }
}
