using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Homework__Interfaces_
{
    internal class Line : ILocated, IColored, IPrintable, IMovable
    {
        private int size;
        public int Size
        {
            get => size;
            set { size = value < 1 ? 1 : value; }
        }
        private int x;
        private int y;
        public int X 
        {
            get { return x; }
            set { x = value < 0 ? 0 : value; }
        }
        public int Y 
        {
            get { return y; }
            set { y = value < 0 ? 0 : value; }
        }
        public ConsoleColor Color { get; set; }
        public char PrintableSymbol { get; set; }
        public void Print()
        {
            Console.ForegroundColor = Color;
            Console.SetCursorPosition(X, Y);
            Console.WriteLine(new string(PrintableSymbol, size));
            Console.ResetColor();
        }
        public void Move(int x, int y)
        {
            X = x;
            Y = y;
        }
        public Line(int size)
        {
            Size = size;
        }
        public Line(int size, char printableSymbol, ConsoleColor color, int x, int y)
        {
            Size = size;
            PrintableSymbol = printableSymbol;
            Color = color;
            X = x;
            Y = y;
        }
    }
}
