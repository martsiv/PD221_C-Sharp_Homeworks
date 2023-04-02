namespace _05_Homework__Classes._Props_
{
   
    internal class Program
    {
        static void Main(string[] args)
        {
            Airplane a1 = new Airplane("AH72", "SL715FE", 1500, 450, 22);
            Console.WriteLine("Specify the remaining parameters of aircraft number 2:");
            Airplane a2 = new Airplane("Boeing 747", "DH172JR");
            Console.WriteLine($"Airplane N1:\n{a1}\n");
            Console.WriteLine($"Airplane N2:\n{a2}\n");
            Console.WriteLine("After swap");
            Airplane.Swap(ref a1, ref a2);
            Console.WriteLine($"Airplane N1:\n{a1}\n");
            Console.WriteLine($"Airplane N2:\n{a2}\n");
            a1.Refuel();
            a2.Refuel();
            a1.MakeAFlight(19);
            Airplane a3;
            Airplane.InputProperties(out a3);
            Console.WriteLine($"Airplane N3:\n{a2}\n");

        }
    }
}