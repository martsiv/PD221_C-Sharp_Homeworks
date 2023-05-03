using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Homework__Events__Task_Trader
{
    internal class Trader
    {
        public string Name { get; }
        private string fileName => Name + ".txt";
        public Trader(string name)
        {
            Name = name;
            using (StreamWriter sw = File.CreateText(fileName)) { }
        }
        public void Trade(int price, bool sellOrNo, CurrencyPair pair)
        {
            string message = $"{Name} sees that the price has " +
                (sellOrNo == true ? "risen" : "fallen") +
                $" on {pair.Name}, so he " +
                (sellOrNo == true ? " sells" : " buys") +
                $" his assets by price {price}$\n";
            File.AppendAllText(fileName, message);
            Console.WriteLine(message);
            Console.ReadKey();
        }
    }
}
