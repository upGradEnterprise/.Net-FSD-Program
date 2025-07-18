namespace ConsoleApp39
{

    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public static Point operator +(Point p1, Point p2)
        {
            Point p3 = new Point();
            p3.X = p1.X + p2.X;
            p3.Y = p1.Y + p2.Y;
            return p3;  
        }

        public override string ToString()
        {
            return $"X = {X}, Y = {Y}";
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {         
                Point p1 = new Point() { X = 10, Y = 20 }; 
                Point p2 = new Point() { X = 30, Y = 40 };

                Point p3 = p1 + p2;

                Console.WriteLine(p1);
                Console.WriteLine(p2);
                Console.WriteLine(p3);

                Console.ReadLine();
        } 
    }
}
