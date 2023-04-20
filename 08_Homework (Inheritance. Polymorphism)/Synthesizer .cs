using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Homework__Inheritance._Polymorphism_
{
    internal class Synthesizer : KeyboardInstrument
    {
        public bool HasArpeggiator { get; set; }
        public bool HasSampler { get; set; }
        public Synthesizer(string brand, string model, int keysCount, bool hasPedals, bool hasArpeggiator, bool hasSampler) : base(brand, model, keysCount, hasPedals)
        {
            HasArpeggiator = hasArpeggiator;
            HasSampler = hasSampler;
        }
        public void SetPreset()
        {
            Console.WriteLine("You have installed a new music preset to play on the synthesizer...");
        }
        public override string ToString()
        {
            return $"Synthesizer {Brand} {Model}: {KeysCount} keys, "
                + (HasPedals ? "with" : "without") + $" pedals "
                + (HasArpeggiator ? "with arpeggiator " : "without arpeggiator ")
                + (HasSampler ? "with Sampler." : "without Sampler.");
        }
    }
}

