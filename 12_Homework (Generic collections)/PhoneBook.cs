using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Homework__Generic_collections_
{
    internal class PhoneBook 
    {
        private Dictionary<string, PhoneSubscriber> phoneBook = new Dictionary<string, PhoneSubscriber>();

        public void AddRecord(string key, PhoneSubscriber value)
        {
            phoneBook.Add(key, value);
        }

        public bool UpdateRecord(string key, PhoneSubscriber value)
        {
            if (phoneBook.ContainsKey(key))
            {
                phoneBook[key] = value;
                return true;
            }
            else
                return false;
        }

        public bool RemoveRecord(string key) => phoneBook.Remove(key);
   
        public PhoneSubscriber? GetRecord(string key)
        {
            PhoneSubscriber? value;
            phoneBook.TryGetValue(key, out value);
            return value;
        }

        public void PrintAllRecords()
        {
            foreach (var item in phoneBook)
                Console.WriteLine(item.Value);
        }

      
    }
}
