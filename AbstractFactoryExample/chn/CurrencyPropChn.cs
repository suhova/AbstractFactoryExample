using AbstractFactoryExample.abstractProp;

namespace AbstractFactoryExample.chn
{
    /// <summary>
    /// Конкретный параметр Волюта для Китая
    /// </summary>
    public class CurrencyPropChn : CurrencyProp
    {
        private static string currency="yuan";
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