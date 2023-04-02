using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Homework__Classes._Props_
{
    internal partial class Airplane
    {
        public static void Swap(ref Airplane airplane1, ref Airplane airplane2)
        { 
            Airplane toSwap = airplane1;
            airplane1 = airplane2;
            airplane2 = toSwap;
        }
        public static void InputProperties(out Airplane airplane)
        {
            airplane = new Airplane(EnterModel(), EnterBoardNumber(), EnterPayload(), EnterTankValue(), EnterFuelConsumption());
        }
        private static string EnterModel()
        {
            Console.Write("Enter the model: ");
            string model = Console.ReadLine();
            return model;
        }
        private static string EnterBoardNumber()
        {
            Console.Write("Enter the board number: ");
            string boardNumber = Console.ReadLine();
            return boardNumber;
        }
        private static int EnterPayload()
        {
            Console.Write("Enter the payload: ");
            int payload = int.Parse(Console.ReadLine());
            return payload;
        }
        private static int EnterTankValue()
        {
            Console.Write("Enter the tank: ");
            int tank = int.Parse(Console.ReadLine());
            return tank;
        }
        private static double EnterFuelConsumption()
        {
            Console.Write("Enter the fuel consumption: ");
            double fuelConsumption = double.Parse(Console.ReadLine());
            return fuelConsumption;
        }
    }
}
