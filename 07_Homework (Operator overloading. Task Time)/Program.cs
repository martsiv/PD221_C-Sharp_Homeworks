namespace _07_Homework__Operator_overloading._Task_Time_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Time time1 = new Time(86400);
            Console.WriteLine($"time1 = {time1}");
            --time1;
            --time1;
            Console.WriteLine($"time1 --(2x) {time1}");
            Time time2 = new Time(34234);
            Console.WriteLine($"time2 = {time2}");
            Console.WriteLine($"time1 + time2 = {time1 + time2}");
            Console.WriteLine($"time1 <= time2 = {time1 <= time2}");
            TimeOnly time3 = time2.TimeOnly();
            Console.WriteLine($"Time3 is TimeOnly = time2 = {time3}");
        }
    }
}