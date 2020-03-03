using AbstractFactoryExample.abstractProp;

namespace AbstractFactoryExample.rus
{
    /// <summary>
    /// Конкретный параметр Волюта для России
    /// </summary>
    public class CurrencyPropRus : CurrencyProp
    {
        private static string currency="руб";
        /// <summary>
        /// Метод, который возвращает название валюты
        /// </summary>
        /// <returns>строка с названием валюты</returns>
        public string getCurrency()
        {
            return currency;
        }
    }
}