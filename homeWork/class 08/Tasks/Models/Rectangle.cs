namespace Models
{
    public class Rectangle : Shape
    {
        public int SideA {  get; set; }
        public int SideB { get; set; }
        public Rectangle(int sideA, int sideB, string name, string color, int[] coordinates) : base(name, color, coordinates)
        {
            SideA = sideA;
            SideB = sideB;
        }
        public override void GetArea()
        {
            Console.WriteLine($"The area of the rectangle {Name} is: {SideA * SideB}");
        }
        public override void GetPerimeter()
        {
            Console.WriteLine($"The perimeter of the rectangle {Name} is: {2 * SideA * SideB}");
        }
    }
}
