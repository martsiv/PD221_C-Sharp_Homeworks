using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Homework___Serialization_
{
    struct MyFloat
    {
        public int Numerator { get; set; }
        public int Denominator { get; set; }
        public MyFloat()
        {

        }
        public MyFloat(int numerator, int denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
        }
        public override string ToString()
        {
            return $"{Numerator}/{Denominator}";
        }
    }
}
