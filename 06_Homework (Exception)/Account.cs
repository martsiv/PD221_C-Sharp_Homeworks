using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Homework__Exception_
{
    internal class Account
    {
        private string email;
        public string Email 
        { 
            get { return email; }
            set
            {
                if ((4 < value.Length) && (value.Length < 50) &&
                    (value.Where(x => (char)x == '@').ToArray().Length == 1) &&
                    (value.Where(x => char.IsLetter(x) || char.IsDigit(x) || (x == '_') || (x == '@')).ToArray().Length == value.Length))
                {
                    Console.WriteLine("Seccess email");
                    email = value;
                }
                else
                    throw new ArgumentException("Not correct format email");
            }
        }
        private string password;

        public string Password
        {
            get { return password; }
            set 
            {
                if ((6 < value.Length) &&
                    (0 < value.Where(x => char.IsLetter(x)).ToArray().Length) &&
                    (0 < value.Where(x => char.IsDigit(x)).ToArray().Length))
                {
                    Console.WriteLine("Seccess email");
                    password = value;
                }
                else
                    throw new ArgumentException("Not correct format password");
            }
        }
        public Account(string email, string password)
        {
            Email = email;
            Password = password;
        }
    }
}
