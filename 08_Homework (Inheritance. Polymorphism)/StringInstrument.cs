using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Homework__Inheritance._Polymorphism_
{
    internal class StringInstrument : MusicalInstrument 
    {
        public int StringsCount { get; set; }
        public StringInstrument(string brand, string model, int stringsCount) : base(brand, model)
        {
            StringsCount = stringsCount;
        }
        public sealed override void Play()
        {
            Console.WriteLine("Playing music on stringed instrument...");
        }

        public void TuneStrings()
        {
            Console.WriteLine("Tuning strings on stringed instrument...");
        }
    }
}
