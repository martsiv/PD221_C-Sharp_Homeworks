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
                if ((value.Length < 4) || (50 < value.Length))
                    throw new ArgumentException("Not correct lenght email");

                if (value.Where(x => (char)x == '@').ToArray().Length != 1)
                    throw new ArgumentException("There must be only one '@' symbol in email");

                if (!(value.Where(x => char.IsLetter(x) || char.IsDigit(x) || (x == '_') || (x == '@')).ToArray().Length == value.Length))
                    throw new ArgumentException("Email can only contain numbers, letters, and the '@' and '_' symbols");

                else
                {
                    Console.WriteLine("Seccess email");
                    email = value;
                }
            }
        }
        private string password;

        public string Password
        {
            get { return password; }
            set
            {
                if (value.Length < 6)
                    throw new ArgumentException("Too small passwords length");

                if (0 == value.Where(x => char.IsLetter(x)).ToArray().Length)
                    throw new ArgumentException("Password must contain at least one letter");
                if (0 == value.Where(x => char.IsDigit(x)).ToArray().Length)
                    throw new ArgumentException("Password must contain at least one digit");

                else
                {
                    Console.WriteLine("Seccess email");
                    password = value;
                }
            }
        }
        public Account(string email, string password)
        {
            Email = email;
            Password = password;
        }
    }
}
