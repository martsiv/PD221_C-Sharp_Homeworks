namespace _10_Homework__Interfaces_
{
<<<<<<< HEAD
    struct Coordinate
    {
        int x;
        int y;
        public Coordinate(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
=======
>>>>>>> b05bdf7bc80c7bc8acd864cc8cffebd5cb5ec4ad
    internal class Program
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD
            Console.WriteLine("Hello, World!");
=======
            Shape shape = new Rectangle(length: 4, width: 6)
            {
                X = 5,
                Y = 5,
                Color = ConsoleColor.Red,
                PrintableSymbol = '$'
            };
            Console.WriteLine(shape.Perimeter);
            Console.WriteLine(shape.Area);
            shape.Print();
            shape = new Triangle(size: 6)
            {
                X = 6,
                Y = 12,
                Color = ConsoleColor.Yellow,
                PrintableSymbol = '0'
            };
            Console.WriteLine($"{shape.Perimeter:F2}");
            Console.WriteLine($"{shape.Area:F2}");
            shape.Print();
            shape.Move(15, 15);
            shape.Print();

            Line line = new Line(size: 6, printableSymbol: '@', ConsoleColor.Cyan, x: 10, y: 23);
            line.Print();
>>>>>>> b05bdf7bc80c7bc8acd864cc8cffebd5cb5ec4ad
        }
    }
}