using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Homework__Inheritance._Polymorphism_
{
    internal class ElectricGuitar : StringInstrument
    {
        public string PickupType { get; set; }
        public bool HasTremolo { get; set; }
        public ElectricGuitar(string brand, string model, int stringsCount, string pickupType, bool hasTremolo) : base(brand, model, stringsCount)
        {
            PickupType = pickupType;
            HasTremolo = hasTremolo;
        }
        public void SetEffects()
        {
            Console.WriteLine("Set some Effects on electric guitar...");
        }
        public override string ToString()
        {
            return $"Electric guitar {Brand} {Model} with {StringsCount} strings {PickupType} " 
                + (HasTremolo ? "with ": "without ") + "tremolo.";
        }
    }
}
