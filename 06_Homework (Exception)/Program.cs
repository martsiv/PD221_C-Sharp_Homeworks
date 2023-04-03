namespace _06_Homework__Exception_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter email:");
                    string email = Console.ReadLine();
                    Console.WriteLine("Enter the password");
                    string password = Console.ReadLine();
                    Account acc = new Account(email, password);
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                    continue;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    continue;
                }
                break;
            }
        }
    }
}