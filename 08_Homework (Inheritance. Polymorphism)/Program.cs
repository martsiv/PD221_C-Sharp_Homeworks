namespace _08_Homework__Inheritance._Polymorphism_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MusicalInstrument[] musicalInstruments = new MusicalInstrument[5]
            {
                new AcousticGuitar("Fender", "WEF42", 6, "Concert", false),
                new ElectricGuitar("Gibson", "FWR334", 6, "Parlor", true),
                new Piano("Yamaha", "FEFB34", 88, true, true, true),
                new Organ("Hammond", "f334r3", 120, true, false, "Wood"),
                new Synthesizer("Yamaha", "ZT35345", 61, false, false, false)
            };

            foreach (var item in musicalInstruments)
            {
                Console.WriteLine(item);
                item.Play();
                Console.WriteLine();
            }
        }
    }
}