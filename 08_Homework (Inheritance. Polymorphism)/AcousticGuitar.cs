using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Homework__Inheritance._Polymorphism_
{
    internal class AcousticGuitar : StringInstrument
    {
        public string BodyShape { get; set; }
        public bool HasCutaway { get; set; }
        public AcousticGuitar(string brand, string model, int stringsCount, string bodyShape, bool hasCutaway) : base(brand, model, stringsCount)
        {
            BodyShape = bodyShape;
            HasCutaway = hasCutaway;
        }
        public void ChangeStrings()
        {
            Console.WriteLine("You replaced the old strings with new ones...");
        }
        public override string ToString()
        {
            return $"Acoustic guitar {Brand} {Model} with {StringsCount} strings with {BodyShape} body shape" + (HasCutaway ? " and cutaway." : ".");
        }
    }
}
