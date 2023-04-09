using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Homework__Inheritance._Polymorphism_
{
    internal class MusicalInstrument
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public MusicalInstrument(string brand, string model)
        {
            Brand = brand;
            Model = model;
        }
        public virtual void Play()
        {
            Console.WriteLine("Playing music on instrument...");
        }
    }
}
