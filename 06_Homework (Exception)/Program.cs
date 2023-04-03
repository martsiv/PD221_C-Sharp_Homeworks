namespace _06_Homework__Exception_
{
    internal class Program
    {
        static void EnterAccountData(out Account acc)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter email:");
                    string email = Console.ReadLine();
                    Console.WriteLine("Enter the password");
                    string password = Console.ReadLine();
                    acc = new Account(email, password);
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
        static void Main(string[] args)
        {
            //Account
            Account acc;
            EnterAccountData(out acc);

            //Credit Card
            try
            {
                CreditCard visa = new CreditCard("Visa", "4556481986697540", DateTime.Parse("25-12-25"), 423);
                Console.WriteLine(visa);
            }
            catch (ArgumentException e)
            { Console.WriteLine(e); }
        }
    }
}