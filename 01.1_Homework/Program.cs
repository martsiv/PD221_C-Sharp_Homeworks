namespace _01._1_Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Task 1
            //Console.Write("Enter radius of the circle ");
            //float R = float.Parse(Console.ReadLine());
            //Console.WriteLine($"Diameter = {2 * R}");

            ////Task 2
            //Random rnd = new Random();
            //int number = rnd.Next(0, 11);
            //Console.WriteLine("Try to guess the number (0-10) ");
            //for (int i = 0; i < 3; i++) 
            //{
            //    Console.Write($"{i + 1}/3) ");
            //    int tmp = int.Parse(Console.ReadLine());
            //    if (tmp == number)
            //    {
            //        Console.WriteLine("You win!!!");
            //        return;
            //    }
            //}
            //Console.WriteLine("You loose");

            ////Task 3
            //Console.WriteLine("Enter two sides of the rectangle ");
            //Console.Write("Vertical line ");
            //int vertical = int.Parse(Console.ReadLine());
            //Console.Write("Horizontal line ");
            //int horizontal = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter startup coords ");
            //Console.Write("x = ");
            //int x = int.Parse(Console.ReadLine());
            //Console.Write("y = ");
            //int y = int.Parse(Console.ReadLine());
            //Console.Clear();

            ////roof
            //Console.SetCursorPosition(x, y);
            //for (int i = 0; i < vertical; i++)
            //{
            //    Console.ForegroundColor = ConsoleColor.Red;
            //    Console.Write("* ");
            //}

            ////floor
            //Console.SetCursorPosition(x, y + horizontal - 1);
            //for (int i = 0; i < vertical; i++)
            //{
            //    Console.ForegroundColor = ConsoleColor.Green;
            //    Console.Write("* ");
            //}

            ////left side
            //for (int i = 0; i < horizontal; i++)
            //{
            //    Console.SetCursorPosition(x, y + i);
            //    Console.ForegroundColor = ConsoleColor.Blue;
            //    Console.WriteLine("*");
            //}

            ////right side
            //for (int i = 0; i < horizontal; i++)
            //{
            //    Console.SetCursorPosition(x + vertical * 2 - 2, y + i);
            //    Console.ForegroundColor = ConsoleColor.Cyan;
            //    Console.WriteLine("*");
            //}
            //Console.ResetColor();   


            ////Task 4
            //Console.Write("Enter the number of harvester ");
            //int harvesters = int.Parse(Console.ReadLine());
            //Console.Write("How long did the first harvester work(hours)? ");
            //int hoursOfWorkOfFirst = int.Parse(Console.ReadLine());
            //int minutesOfWorkOfFirst = hoursOfWorkOfFirst * 60;

            //int previusWorkMinutes = minutesOfWorkOfFirst;
            //int totalWorkMinutes = 0;
            //for (int i = 0; i < harvesters; i++) 
            //{
            //    totalWorkMinutes += previusWorkMinutes;
            //    previusWorkMinutes += 10;
            //}
            //Console.WriteLine($"Total minutes of work = {totalWorkMinutes}");
            //Console.WriteLine($"Total hours of work = {(float)totalWorkMinutes / 60}");


            //Task 5
            //Console.WriteLine("Enter the number (1 - 6)");
            //int num;
            //do
            //{
            //    num = int.Parse(Console.ReadLine());
            //} while ((num < 1) || (6 < num)) ;
            //Console.Clear();
            //for (int i = 0; i < num; i++) 
            //{
            //    for (int j = 0; j < num; j++)
            //    {
            //        Console.SetCursorPosition((i * num * 2 + num - j - 1), j);
            //        for (int k = 0; k < j * 2 + 1; k++)
            //        Console.Write("*");
            //    }
            //}

        }
    }
}