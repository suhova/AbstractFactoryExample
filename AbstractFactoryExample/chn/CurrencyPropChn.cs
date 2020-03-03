using AbstractFactoryExample.abstractProp;

namespace AbstractFactoryExample.chn
{
    public class CurrencyPropChn : CurrencyProp
    {
        private static string currency="yuan";

        public string getCurrency()
        {
            return currency;
        }
    }
}