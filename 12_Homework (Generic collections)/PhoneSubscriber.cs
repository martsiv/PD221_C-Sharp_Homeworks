using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _12_Homework__Generic_collections_
{
    internal class PhoneSubscriber : IComparable<PhoneSubscriber>, IEquatable<PhoneSubscriber>
    {
        public string PhoneNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        
        public PhoneSubscriber(string phoneNumber, string firstName, string lastName)
        {
            PhoneNumber = phoneNumber;
            FirstName = firstName;
            LastName = lastName;
        }
       
        public override string ToString()
        {
            return $"{PhoneNumber} {FirstName} {LastName}";
        }

        public int CompareTo(PhoneSubscriber? other) 
        {
            if (other == null)
                return 1;

            // Compare by phone number first
            int result = PhoneNumber.CompareTo(other.PhoneNumber);

            if (result == 0)
            {
                // If phone numbers are the same, compare by first name
                result = FirstName.CompareTo(other.FirstName);
            }
            if (result == 0)
            {
                // If phone numbers are the same, compare by last name
                result = LastName.CompareTo(other.LastName);
            }
            return result;
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as PhoneSubscriber);
        }

        public bool Equals(PhoneSubscriber? other)
        {
            return other is not null &&
                   this.PhoneNumber == other.PhoneNumber &&
                   this.FirstName == other.FirstName && 
                   this.LastName == other.LastName;
        }
    }
}
