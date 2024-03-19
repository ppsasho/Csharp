namespace Models
{
    public class Shape
    {
        private string name { get; set; }
        private string color { get; set; }

        public string Name {
            get
            {
                Console.WriteLine($"Name of shape: {name}");
                return name;
            }
            
            set
            {
                if (value.Length >= 3)
                {
                    name = value;
                }
                else
                {
                    name = "NA";
                }
            }
            }
        public string Color {
            get 
            {
                Console.WriteLine($"Color of shape: {color}");
                return color;
            }
            set
            {
                if (value.Length > 3) color = value;
                else color = "NA";
            } 
        }
        public int[] Position { get; set; }

        public Shape(string name, string color, int[] position) 
        {
            Name = name;
            Color = color;
            Position = position;
        }
        public static int[] Move(int[] coordinates)
        {
            int[] moved = Array.Empty<int>();
            foreach(int cord in coordinates)
            {
                Array.Resize(ref moved, moved.Length + 1);
                moved[moved.Length - 1] = cord + 5;
            }
            return moved;
        }
        public virtual void GetArea() {
            Console.WriteLine("There is no special implementation for area");
        }
        public virtual void GetPerimeter(){
            Console.WriteLine("There is no special implementation for perimeter");
        }


    }
}
