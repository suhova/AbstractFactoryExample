using AbstractFactoryExample.abstractProp;

namespace AbstractFactoryExample.deu
{
    public class CurrencyPropDeu : CurrencyProp
    {
        private static string currency="euro";

        public string getCurrency()
        {
            return currency;
        }
    }
}