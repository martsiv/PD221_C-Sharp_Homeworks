 using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

enum WagonsType { Intercity, Passengers, PassengersSV };
enum TrainType { Electric, Diesel, ElectricDiesel };

namespace _04_Homework__Train_
{
    struct Wagon
    {
        private const string owner = "UZD";
        private readonly WagonsType type = WagonsType.Intercity;
        public int Number { get; private set; }
        public int TotalSeats { get; init; }
        public int PassengersNumber { get; private set; }
        public int FreePlaces { get { return TotalSeats - PassengersNumber; } }

        public Wagon(int number, int totalSeats, int passengers, WagonsType type = WagonsType.Passengers)
        {
            this.type = type;
            Number = number;
            TotalSeats = totalSeats;    
           PassengersNumber = passengers;
        }
        public override string ToString()
        {
            return $"Car #{Number}\nPassengers {PassengersNumber}/{TotalSeats}";
        }
   
        public bool AddPassengers(int num)
        {
            if (TotalSeats < (PassengersNumber + num))
                return false;
            PassengersNumber += num;
            return true;
        }
        public bool DropPassengers(int num)
        {
            if ((PassengersNumber - num) < 0)
                return false;
            PassengersNumber -= num;
            return true;    
        }
    }
    internal class Train
    {
        public int Number { get; private set; }
        public TrainType type { get; init; }
        private Wagon[] wagons;
        public string RouteName { get; set; }
        public DateTime Dispath { get; set; }
        public DateTime Arrived { get; set; }

        public TimeSpan RemainingTime 
        {
            get
            {
                TimeSpan difference = Arrived-  DateTime.Now;
                if (difference.TotalMilliseconds < 0)
                {
                    Console.WriteLine("The difference between the dates is negative");
                    return TimeSpan.Zero;
                }
                return difference;
            }
        }
        public Train(int number, TrainType type, string routeName, DateTime dispath, DateTime arrived)
        {
            wagons = null;
            Number = number;
            RouteName = routeName;
            this.type = type;
            RouteName = routeName;
            Dispath = dispath;
            Arrived = arrived;

        }
        public void AddCar(Wagon wagon)
        {
            if (wagons == null)
                wagons = new Wagon[1] { wagon };
            else
            {
                Array.Resize(ref wagons, wagons.Length + 1);
                wagons.Append(wagon);
            }
        }
        public void UnhookWagon(int wagonsIndex)
        {
            for (int i = wagonsIndex; i < wagons.Length - 1; i++)
                wagons[i] = wagons[i + 1];
        }

        public void AddPassengers(int wagonsIndex, int numOfPassengers)
        {
            if (wagonsIndex < 0 || wagons.Length <= wagonsIndex)
            {
                Console.WriteLine("Wrong index");
                return;
            }
            if (wagons[wagonsIndex].AddPassengers(numOfPassengers))
                Console.WriteLine("Success!");
            else
                Console.WriteLine("There are not enough free places");
        }
        public void DropPassengers(int wagonsIndex, int numOfPassengers)
        {
            if (wagonsIndex < 0 || wagons.Length <= wagonsIndex)
            {
                Console.WriteLine("Wrong index");
                return;
            }
            if (wagons[wagonsIndex].DropPassengers(numOfPassengers))
                Console.WriteLine("Success!");
            else
                Console.WriteLine("There are not enough passengers");
        }

        public int GetWagons { get { return wagons.Length; } }
        public int GetFreePlaces {
            get
            {
                int result = 0;
                foreach (var item in wagons)
                {
                    result += item.FreePlaces;
                }
                return result;
            }
        }

        public int AveragePassengers 
        { 
            get
            {
                int result = 0;
                foreach (var item in wagons)
                {
                    result += item.PassengersNumber;
                }
                return result / wagons.Length; 
            }
        }
        public override string ToString()
        {
            return $"{type} train #{Number} {RouteName}, dispath - {Dispath}, arrived - {Arrived}\nWagons: {GetWagons}, Free Places: {GetFreePlaces}, Average passengers: {AveragePassengers}";
        }
    }
}

