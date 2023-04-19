using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static _10_Homework__Interfaces_.ILocated;

namespace _10_Homework__Interfaces_
{
    internal class Rectangle : Shape
    {
        private int l;
        public int L
        {
            get => l;
            set { l = value < 1 ? 1 : value; }
        }
        private int w;
        public int W
        {
            get => w;
            set { w = value < 1 ? 1 : value; }
        }
        public override double Area => L * W; 
        public override double Perimeter => 2 * L + 2 * W; 
        public override void Print()
        {
            Console.ForegroundColor = Color;
            for (int i = 0, x = X, y = Y; i < L; i++, y++)
            {
                Console.SetCursorPosition(x, y);
                Console.WriteLine(new string(PrintableSymbol, W));
            }
            Console.ResetColor();
        }
        public Rectangle(int length, int width) : base()
        {
            L = length;
            W = width;
        }
        public Rectangle(int length, int width, char printableSymbol, ConsoleColor color, int x, int y) 
            : base(printableSymbol, color, x, y)
        {
            L = length;
            W = width;
        }
    }
}
