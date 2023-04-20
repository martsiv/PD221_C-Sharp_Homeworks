using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Homework__Interfaces_
{
    abstract class Shape : IPrintable, IMovable, IColored, ILocated
    {
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
    }
}
