namespace collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> colors = new();
            List<int> nums = new();
            List<bool> bools = new();

            bools.Add(true);

            colors.Add("blue");
            colors.Add("red");
            colors.Add("green");
            colors.Add("brown");

            nums.Add(123);

            List<string> newColors = new();
            newColors.AddRange(colors);
            newColors.Add("purple");

            newColors.Remove("red");
            newColors.RemoveAt(newColors.IndexOf("brown"));

            foreach (string color in newColors) {
                Console.WriteLine(color);
            }

        }
    }
}
