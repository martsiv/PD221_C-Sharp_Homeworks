using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Homework__Inheritance._Polymorphism_
{
    internal class KeyboardInstrument : MusicalInstrument
    {
        public int KeysCount { get; set; }
        public bool HasPedals { get; set; }
        public KeyboardInstrument(string brand, string model, int keysCount, bool hasPedals) : base(brand, model)
        {
            KeysCount = keysCount;
            HasPedals = hasPedals;
        }
        public sealed override void Play()
        {
            Console.WriteLine("Playing music on keyboard instrument...");
        }

        public void PressKey()
        {
            Console.WriteLine("Pressing a key on keyboard instrument...");
        }
    }
}
