using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Homework__Inheritance._Polymorphism_
{
    internal class Organ : KeyboardInstrument
    {
        public bool IsDigital { get; set; }
        public string PipeMaterial { get; set; }
        public Organ(string brand, string model, int keysCount, bool hasPedals, bool isDigital, string pipeMaterial) : base(brand, model, keysCount, hasPedals)
        {
            IsDigital = IsDigital;
            PipeMaterial = pipeMaterial;
        }
        public void SetVolume()
        {
            Console.WriteLine("You have set the volume pitch for playing the organ...");
        }
        public override string ToString()
        {
            return $"Organ {Brand} {Model}: {KeysCount} keys, "
                + (HasPedals ? "with" : "without") + $" pedals "
                + (IsDigital ? "digital" : "not digital") + $" is made of {PipeMaterial}";
        }
    }
}
