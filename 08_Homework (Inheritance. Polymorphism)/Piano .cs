using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Homework__Inheritance._Polymorphism_
{
    internal class Piano : KeyboardInstrument
    {
        public bool IsUpright { get; set; } //construction of body vertical 
        public bool HasLid { get; set; }    //the lid on top of the piano
        public Piano(string brand, string model, int keysCount, bool hasPedals, bool isUpright, bool hasLid) : base(brand, model, keysCount, hasPedals)
        {
            IsUpright = isUpright;
            HasLid = hasLid;
        }
        public void Transpose()
        {
            Console.WriteLine("You transposed the pitch on the piano...");
        }

        public override string ToString()
        {
            return $"Piano {Brand} {Model}: {KeysCount} keys, "
                            + (HasPedals ? "with" : "without") + $" pedals "
                            + (IsUpright ? "with upright construction " : "with classic construction ")
                            + (HasLid ? "with lid on the top." : ".");
        }
    }
}
