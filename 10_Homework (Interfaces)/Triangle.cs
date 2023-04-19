using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Homework__Interfaces_
{
    internal class Triangle : Shape
    {
        private int size;
        public int Size
        {
            get => size;
            set { size = value < 1 ? 1 : value; }
        }
        public override double Area => Math.Sqrt(Perimeter * (Perimeter - size) * (Perimeter - size) * (Perimeter - size * Math.Sqrt(2.0))); 
        public override double Perimeter => size * 2.0 + Math.Sqrt(size * size * 2.0); 
        public override void Print()
        {
            Console.ForegroundColor = Color;

            for (int i = 0, x = X, y = Y; i < size; i++, y++)
            {
                Console.SetCursorPosition(x, y);
                Console.WriteLine(new string(PrintableSymbol, 1 + i));
            }
            Console.ResetColor();
        }
        public Triangle(int size) : base()
        {
            Size = size;
        }
        public Triangle(int size, char printableSymbol, ConsoleColor color, int x, int y)
            : base(printableSymbol, color, x, y)
        {
            Size = size;
        }
    }
}
