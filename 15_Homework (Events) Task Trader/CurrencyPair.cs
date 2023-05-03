using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Homework__Events__Task_Trader
{
    internal class CurrencyPair
    {
        public string Name { get; }
        public int Price { get; private set; }
        public event Action<int, bool, CurrencyPair> ChangePriceEvent;
        private int numInSeries;            //number of operation in series
        private int isfallsOrRisesSeries;   // 0< Rises || <0 Fall || 0 - None
        public CurrencyPair(string name, int price)
        {
            Name = name;
            Price = price;
            numInSeries = 0;
            isfallsOrRisesSeries = 0;
        }
        public void ChangePrice(int newPrice)
        {
            Console.WriteLine($"Pair {Name}, old price - {Price}, New price - {newPrice}");
            if (isfallsOrRisesSeries == 0)      //Якщо торги лише почалися і динаміки не було
            {
                numInSeries = 1;
                isfallsOrRisesSeries = newPrice < Price ? -1 : 1;
            }
            else if (newPrice < Price) //Якщо ціна падає
            {
                if (isfallsOrRisesSeries < 0)   //Якщо серія продовжується
                    ++numInSeries;              //Збільшуємо серію
                else if (0 < isfallsOrRisesSeries)  //Якщо динаміка пішла в протилежний бік
                {
                    numInSeries = 1;
                    isfallsOrRisesSeries = -1;
                }

            }
            else if (Price < newPrice) //Якщо ціна росте
            {
                if (0 < isfallsOrRisesSeries)   //Якщо серія продовжується
                    ++numInSeries;              //Збільшуємо серію
                else if (isfallsOrRisesSeries < 0)  //Якщо динаміка пішла в протилежний бік
                {
                    numInSeries = 1;
                    isfallsOrRisesSeries = 1;
                }
            }
            //Якщо ціна та сама, то результати серії не змінюємо
            Price = newPrice;
            if (3 <= numInSeries)   //Якщо в серії є 3 зміни в один бік, то обнуляємо лік, та викликаємо івент
            {
                numInSeries = 0;
                ChangePriceEvent?.Invoke(Price, (0 < isfallsOrRisesSeries) ? true : false, this);
            }
        }
    }
}
