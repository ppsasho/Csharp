using Models;
namespace Bonus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new(12, "Bob",  "Red", new int[2] { 4, 5 });
            Circle circle2 = new(41, "Jake", "Blue", new int[2] { 5, 2 });
            Rectangle rectangle = new(20, 30, "Dorry", "Green", new int[2] { 7, 3 });
            Rectangle rectangle2 = new(53, 14, "Broggy", "Gray", new int[2] { 10, 23 });

            List<Shape> shapes = new()
            {
                circle, circle2, rectangle, rectangle2
            };

            foreach(Shape shape in shapes)
            {
                shape.GetArea();
                shape.GetPerimeter();
                int[] movedPosition = Shape.Move(shape.Position);
                Console.WriteLine($"New position for {shape.Name} with color {shape.Color}: x{movedPosition[0]}, y{movedPosition[1]}");
            }
        }
    }
}
