using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Homework__Interfaces_
{
    internal interface IPrintable
    {
        char PrintableSymbol { get; set; }
        void Print();
    }
}
