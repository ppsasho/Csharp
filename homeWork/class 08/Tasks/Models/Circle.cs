namespace Models
{
    public class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius, string name, string color, int[] position) : base(name, color, position)
        {
            Radius = radius;
        }

        public override void GetArea()
        {
            Console.WriteLine($"The area for the circle {Name} is {Math.PI * Math.Pow(Radius, 2)}");
        }
        public override void GetPerimeter()
        {
            Console.WriteLine($"The perimeter for the circle {Name} is {2 * Math.PI * Radius}");
        }
    }
}
