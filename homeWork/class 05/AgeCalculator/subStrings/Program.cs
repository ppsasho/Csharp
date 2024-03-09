namespace subStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            string sentence = "Hello from SEDC Codecademy 2024";

            Console.WriteLine($"The sentence you will be working with is:\n{sentence}(The last letter is index {sentence.Length})\nEnter a number:");
            while(true)
            {
                string input = Console.ReadLine();
                if(!int.TryParse(input, out number))
                {
                    Console.WriteLine("Wrong input, try again.");
                    continue;
                }
                if(number > sentence.Length || number < 0)
                {
                    Console.Write("Make sure the number is not negative or larger than the last index.");
                    continue;
                }
                break;
            }
            SubStrings(number, sentence);
            
        }
        static void SubStrings(int i, string sentence)
        {
            string cutString = sentence.Substring(0, i);
            Console.WriteLine($"the sentence was cut to letter no.{i} :\n{cutString}.\tThe lenght of the new sentence is {cutString.Length}");
        }
    }
}
