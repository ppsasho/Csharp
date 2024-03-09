using Microsoft.VisualBasic;
using System.Diagnostics.CodeAnalysis;

namespace AgeCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime userBirthDate = DateConverter();
            int userAge = AgeCalculator(userBirthDate);
            CheckAge(userAge);

        }
        static void CheckAge(int age)
        {
            if (age == 0)
            {
                return;
            }
            Console.WriteLine($"You are {age} years old.");
        }
        static DateTime DateConverter ()
        {
            while (true)
            {
                Console.WriteLine("Please enter your birthday date ( dd-mm-yyyy ):");
                string input = Console.ReadLine();

                if(!DateTime.TryParse(input, out DateTime date))
                {
                    Console.WriteLine("Wrong input, please make sure the date format is correct.");
                    continue;
                }
                Console.WriteLine($"The entered date was converted successfully: {date}");
                return date;
            }
        }

        static int GetNumberOfDays(DateTime date)
        {
            int year = date.Year;
            int month = date.Month;
            int day = date.Day;

            int numberOfDays = (367 * year) - ((7 * (year + ((month + 9) / 12))) / 4) + ((275 * month) / 9) + day - 730531;

            return numberOfDays;
        }
        static int AgeCalculator(DateTime birthDate)
        {
            DateTime currentDate = DateTime.Today;
            Console.WriteLine($"Today's date is : {DateTime.Now}");

            Console.WriteLine($"Current year: {currentDate.Year} | Your birth year: {birthDate.Year}");
            if(birthDate.Year > currentDate.Year)
            {
                Console.WriteLine("Are you a time traveler?");
                return 0;
            }

            int birthDays = GetNumberOfDays(birthDate);
            int currentDays = GetNumberOfDays(currentDate);
            int age = (currentDays - birthDays) / 365;


            if (currentDate.Day == birthDate.Day && currentDate.Month == birthDate.Month)
            {
                Console.WriteLine("Happy birthday!! (:");
            }
            if(birthDate.Month == currentDate.Month && currentDate.Day - birthDate.Day == 1)
            {
                Console.WriteLine("Belated Happy Birthday!");
            }
            if(birthDate.Month == currentDate.Month && birthDate.Day - currentDate.Day == 1)
            {
                Console.WriteLine("Your birthday is one day away, wishing you an incredible birthday in advance!");
            }
            return age;
        }
    }
}
