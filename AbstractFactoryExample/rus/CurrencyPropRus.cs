using AbstractFactoryExample.abstractProp;

namespace AbstractFactoryExample.rus
{
    public class CurrencyPropRus : CurrencyProp
    {
        private static string currency="руб";

        public string getCurrency()
        {
            return currency;
        }
    }
}