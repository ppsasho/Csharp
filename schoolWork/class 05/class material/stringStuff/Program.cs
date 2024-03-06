using System.Globalization;
using System.Text;

namespace stringStuff
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int credits = 235;
            int membership = 85;
            decimal moneyAmount = 235.23M;

            string message = "You have" + " " + credits + " credits." + " The membership costs " + membership + " a month";
            string message2 = string.Format("You have {0} credits. The membership costs {1} a month", credits, membership);
            string message3 = ($"You have {credits} credits. The membership costs {membership} a month"); 

            Console.WriteLine(message);
            Console.WriteLine(message2);
            Console.WriteLine(message3);

            string formattedMoneyAmount = moneyAmount.ToString("C", new CultureInfo("en-gb")); //en-us for dollars
            Console.WriteLine($"You have: {formattedMoneyAmount}");

            Console.WriteLine(string.Format("Amount: {0:C}", moneyAmount));
            Console.WriteLine($"Amount {moneyAmount:C}");

            Console.WriteLine(string.Format("{0:0##/###-###}", 33234234));

            string studentsCombined = "";
            string[] students = { "Jake", "Max", "Steven" };
            for (int i = 0; i < students.Length; i++)
            {
                if(i < students.Length - 1)
                {
                    studentsCombined += students[i] + ", ";
                } else
                {
                    studentsCombined += students[i];
                }
            }

            Console.WriteLine(studentsCombined);

            // OR

            string studentsCombinedShorter = string.Join(", ", students);
            Console.WriteLine(studentsCombinedShorter);

            string phrase = "Welcome to the club!";

            char[] charArray = phrase.ToCharArray();

            string[] wordsArray = phrase.Split(' '); // Add a breaking point (red circle on the left) to see contents

            string cutPhrase = phrase.Substring(8);
            string cutPhrase2 = phrase.Substring(8, 6);

            Console.WriteLine(charArray);
            Console.WriteLine(cutPhrase);
            Console.WriteLine(cutPhrase2);

            Console.WriteLine(string.Format("[{0,10}|{1,10}]", "id", "Name"));
            string street = "st. \"Avenue\"";
            string fileDirectory = "C:Desktop\\School\\C#\\SchoolWork";
            string fileDirectory2 = @"""C:Desktop\School\C#\SchoolWork"""; //Escape characters don't work with @ except for double quotes
            Console.WriteLine(fileDirectory2);
            


        }
    }
}
