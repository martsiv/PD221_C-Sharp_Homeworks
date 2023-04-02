using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Homework__Classes._Props_
{
    internal partial class Airplane
    {
        private const string countrie = "Ukraine";
        private static string transportType;
        public string TransportType { get { return transportType; } }
        private static string fuelType;
        public string FuelType { get { return fuelType; } }
        private readonly string model;
        public string Model => model;
        public string BoardNumber { get; private set; }
        public int Payload { get; private set; }
        public int? CurrentPayload { get; private set; }    //nullable
        public int Tank { get; private set; }
        public double Fuel { get; private set; }
        public double FuelConsumption { get; init; }
        public double MaxRange 
        { get
            {
                return Tank * 100 / FuelConsumption;
            }
        }
        public double RangeWithCurrentFuel
        { get 
            { 
                return Fuel * 100 / FuelConsumption;
            }
        }
        public Airplane(string model, string boardNumber) : this(model, boardNumber, EnterPayload(), EnterTankValue(), EnterFuelConsumption()) {}
        public Airplane(string model, string boardNumber, int payload, int tank, double fuelConsumption) 
        {
            this.model = model;
            BoardNumber = boardNumber;
            Payload = payload;
            CurrentPayload = 0;
            Tank = tank;
            Fuel = 0;
            FuelConsumption = fuelConsumption;
        }
        static Airplane()       //static ctor
        {
            transportType = "Passengers airplane";
            fuelType = "Kerosene";
        }

        public void LoadBaggage(int baggage)
        {
            if (Payload < (CurrentPayload + baggage))
            {
                Console.WriteLine("Not enough space");
                return; 
            }
            CurrentPayload += baggage;
        }
        public int UnloadBaggage()     //nullable to 0 / value
        {
            CurrentPayload = 0;
            if (CurrentPayload == null)
                return 0;
            else 
                return (int)CurrentPayload;
        }
        public void Refuel()
        {
            Fuel = Tank;
            Console.WriteLine("The tank is full");
        }
        public bool MakeAFlight(int km)
        {
            if (MaxRange < km)
            {
                Console.WriteLine("Your plane cannot fly that far");
                return false;
            }
            if (RangeWithCurrentFuel < km)
            {
                Console.WriteLine("You don't have enough fuel, you need to refuel");
                return false;
            }
            double consumed = (FuelConsumption / 100 * km);
            Console.WriteLine($"The plane flew {km} km and consumed {consumed} liters of fuel. {Fuel} liters of fuel left.");
            Fuel -= consumed;
            return true;
        }
        public override string ToString()
        {
            return $"{TransportType} {Model} - {BoardNumber} {countrie}\n" +
                $"Type of fuel - {FuelType} {Tank}\\{Fuel}, Fuel Consumption - {FuelConsumption:F2}L\\100km \n" +
                $"Max range = {MaxRange:F2}km. Range with current fuel = {RangeWithCurrentFuel:F2}km";
        }
    }
}
