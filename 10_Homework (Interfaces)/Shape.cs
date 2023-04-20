using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Homework__Interfaces_
{
    abstract class Shape : IPrintable, IMovable, IColored, ILocated
    {
<<<<<<< HEAD
        public double Area { get; }
        public double Perimeter { get; }
        public char PrintableSymbol { get; set; }
        public string Color { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public void Move(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        abstract public void Print();
        public Shape()
        {
            
        }
=======
        abstract public double Area { get; }
        abstract public double Perimeter { get; }
        public char PrintableSymbol { get; set; }
        public ConsoleColor Color { get; set; }
        private int x;

        public int X
        {
            get => x;
            set { x = value < 0 ? 0 : value; }
        }

        private int y;

        public int Y
        {
            get => y;
            set { y = value < 0 ? 0 : value; }
        }


        public void Move(int x, int y)
        {
            X = x;
            Y = y;
        }

        abstract public void Print();
        public Shape(char printableSymbol, ConsoleColor color, int x, int y)
        {
            PrintableSymbol = printableSymbol;
            Color = color;
            X = x;
            Y = y;
        }
        public Shape() : this(printableSymbol: '*', color: ConsoleColor.White, x: 0, y: 0) { }
>>>>>>> b05bdf7bc80c7bc8acd864cc8cffebd5cb5ec4ad
    }
}
