using System.Diagnostics;
using System.Text;

namespace _11_Homework__Built_in___Train_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("Hello, World!");
            Wagon wagon = new Wagon(342, 50, 12);
            Console.WriteLine(wagon.ToString());
            Console.WriteLine(wagon.FreePlaces);
            Console.WriteLine(wagon.AddPassengers(38));
            Console.WriteLine(wagon.DropPassengers(20));
            
            Train train = new Train(2432, TrainType.Electric, "Rivne-Lviv", new DateTime(2023, 04, 01, 14, 30, 00), new DateTime(2023, 04, 01, 18, 50, 00));
            train.AddCar(wagon);
            train.AddCar(new Wagon(13, 40, 24, WagonsType.PassengersSV));
            train.AddCar(new Wagon(422, 50, 31, WagonsType.Intercity));
            Console.WriteLine(train.ToString());

            TimeSpan difference = train.RemainingTime;
            Console.WriteLine($"There are {difference.Hours} hours {difference.Minutes} minutes {difference.Seconds} seconds left until arrived");

            Train copy = (Train)train.Clone();
            Console.WriteLine("New Train");
            Console.WriteLine(copy);
            copy.AddPassengers(0, 2);
            Console.WriteLine(copy);
            Console.WriteLine("Old Train\n" + train);
           
            Console.WriteLine("\nBefore sort");
            foreach (var item in train)
            {
                Console.WriteLine(item);
            }
            train.Sort();

            Console.WriteLine("\nAfter sort");
            foreach (var item in train)
            {
                Console.WriteLine(item);
            }
        }
    }
}