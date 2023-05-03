using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Homework__Events__Task_Trader
{
    internal class Exchange
    {
        private List<CurrencyPair> currencyPairs = new List<CurrencyPair>();
        public void AddCurrencyPair(CurrencyPair currencyPair)
        {
            currencyPairs.Add(currencyPair);
        }

        public void StartTrade()
        {
            Random random = new Random();
            foreach (var item in currencyPairs)
            {
                int price = item.Price;
                item.ChangePrice(random.Next(price - 5, price + 5));
            }
        }
    }
}
