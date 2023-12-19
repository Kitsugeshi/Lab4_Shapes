namespace Inheritance
{
    internal class Program
    {
        private static void Main()
        {
            Point point = new Point(10, 10);
            Console.WriteLine(point.Name);
            Console.WriteLine(point.GetSize());
            Console.WriteLine();

            LineSegment line = new LineSegment(point.X, point.Y, 20, 20);
            Console.WriteLine(line.Name);
            Console.WriteLine(line.GetSize());
            Console.WriteLine();

            Square square = new Square(line.X, line.Y, line.X2, line.Y2);
            Console.WriteLine(square.Name);
            Console.WriteLine(square.GetSize());
            Console.WriteLine();

            Cube cube = new Cube(square.X, square.Y, square.X2, square.Y2);
            Console.WriteLine(cube.Name);
            Console.WriteLine(cube.GetSize());
            Console.WriteLine();
        }
    }
}

