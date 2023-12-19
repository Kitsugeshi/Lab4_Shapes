namespace Aggregation
{
    internal class Program
    {
        private static void Main()
        {
            Point point1 = new Point(10, 10);
            Point point2 = new Point(20, 20);
            Console.WriteLine(point1.Name);
            Console.WriteLine(point1.GetSize());
            Console.WriteLine();
            Console.WriteLine(point2.Name);
            Console.WriteLine(point2.GetSize());
            Console.WriteLine();

            LineSegment line = new LineSegment(point1, point2);
            Console.WriteLine(line.Name);
            Console.WriteLine(line.GetSize());
            Console.WriteLine();

            Square square = new Square(line);
            Console.WriteLine(square.Name);
            Console.WriteLine(square.GetSize());
            Console.WriteLine();

            Cube cube = new Cube(square);
            Console.WriteLine(cube.Name);
            Console.WriteLine(cube.GetSize());
            Console.WriteLine();
        }
    }
}
