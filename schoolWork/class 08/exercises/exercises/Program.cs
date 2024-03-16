namespace exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sentence = "The whole group of G3 loves C#. They find learning this language fun and easy.";
            int indexOfDot = sentence.IndexOf('.') + 1;
            if (indexOfDot == -1)
            {
                Console.WriteLine("Dot wasn't found!");
            } else
            {
            string cutString = sentence.Substring(indexOfDot);
            Console.WriteLine(cutString);
            }

            string[] cutStrings = sentence.Split('.');
            if(cutStrings.Length > 1) 
            {
            Console.WriteLine(cutStrings[1]);
            }
            else
            {
                Console.WriteLine("No strings retrieved");
            }
        }
    }
}
