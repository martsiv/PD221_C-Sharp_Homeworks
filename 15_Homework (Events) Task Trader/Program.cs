namespace _15_Homework__Events__Task_Trader
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Exchange exchange = new Exchange();
            Trader Tom = new Trader("Tom");
            Trader Grar = new Trader("Grar");
            Trader Lin = new Trader("Lin");
            CurrencyPair USD_UAH = new CurrencyPair("USD_UAH", 38);
            USD_UAH.ChangePriceEvent += Tom.Trade;
            USD_UAH.ChangePriceEvent += Lin.Trade;
            CurrencyPair EUR_UAH = new CurrencyPair("EUR_UAH", 41);
            EUR_UAH.ChangePriceEvent += Grar.Trade;
            EUR_UAH.ChangePriceEvent += Lin.Trade;
            CurrencyPair CAD_UAH = new CurrencyPair("CAD_UAH", 31);
            EUR_UAH.ChangePriceEvent += Grar.Trade;
            EUR_UAH.ChangePriceEvent += Tom.Trade;
            exchange.AddCurrencyPair(USD_UAH);
            exchange.AddCurrencyPair(EUR_UAH);
            exchange.AddCurrencyPair(CAD_UAH);
            for (int i = 0; i < 15; i++)
            {
                exchange.StartTrade();

            }
        }
    }
}