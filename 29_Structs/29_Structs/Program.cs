namespace _29_Structs
{
    public struct Point
    {

        /// <summary>
        /// It's a common practice to make structs immutable
        /// by declaring all fields as readonly and providing only
        /// get accessors for properties.
        /// CLASSES ARE REFERENCE TYPES, SO TWO OF THE SAME CLASS WILL POINT TO THE SAME LOCATION IN THE STACK MEMORY; CHANGING ONE WILL CHANGE THE OTHER.
        /// THIS IS NOT TRUE FOR STRUCTS, SINCE THEY'RE VALUE TYPES.
        /// </summary>
        public double X { get; }
        public double Y { get; }


        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public double DistanceTo(Point other)
        {
            double dx = other.X - X;
            double dy = other.Y - Y;

            return Math.Sqrt(dx * dx + dy * dy);
        }


        public void Display()
        {
            Console.WriteLine($"Point: ({X},{Y})\n");
        }
    }





    internal class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(10,20);
            p1.Display();

            Point p2 = new Point(20,30);
            //p2.X = 5;
            //p2.Y = 30;
            p2.Display();

            double distance = p1.DistanceTo(p2);
            Console.WriteLine($"Distance between points 1 and 2: {distance:F2}");

           


        }
    }
}
