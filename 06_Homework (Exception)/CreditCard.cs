using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Homework__Exception_
{
    internal class CreditCard
    {
        public string Name { get; set; }
		private string number;
        public string Number
		{
			get { return number; }
            set
            {
                if (IsValidNumber(value))
                {
                    number = value;
                }
                else
                {
                    throw new ArgumentException("Invalid credit card number.");
                }
            }
        }
        private bool IsValidNumber(string number)
        {
            // Remove any non-digit characters
            string cleanNumber = new string(number.Where(char.IsDigit).ToArray());

            // Check if the number is the right length
            if (cleanNumber.Length != 16)
            {
                return false;
            }

            // Apply the Luhn algorithm
            int sum = 0;
            bool isSecondDigit = false;
            for (int i = cleanNumber.Length - 1; i >= 0; i--)
            {
                int digit = cleanNumber[i] - '0';

                if (isSecondDigit)
                {
                    digit *= 2;
                    if (digit > 9)
                    {
                        digit -= 9;
                    }
                }

                sum += digit;
                isSecondDigit = !isSecondDigit;
            }

            return sum % 10 == 0;
        }
		
        private DateTime expirationDate;
		public DateTime ExpirationDate
		{
			get { return expirationDate; }
			set 
            {
                if (DateTime.Today < value.AddYears(-5))
                    throw new ArgumentException("The date must be no more than 5 years old");
                expirationDate = value; 
            }
		}
        public short CVV { get; set; }
        public CreditCard(string name, string number, DateTime date, short cvv)
        {
            Name = name;
            Number = number;
            ExpirationDate = date;
            CVV = cvv;
        }
        public override string ToString()
        {
            return $"{Name} {Number} {ExpirationDate:MM/yy} {CVV}";
        }
    }
}
