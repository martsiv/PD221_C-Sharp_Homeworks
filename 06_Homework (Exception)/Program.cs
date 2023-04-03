namespace _06_Homework__Exception_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter email:");
            string email = Console.ReadLine();
            Console.WriteLine("Enter the password");
            string password = Console.ReadLine();
            Account acc = new Account(email, password);
        }
    }
}