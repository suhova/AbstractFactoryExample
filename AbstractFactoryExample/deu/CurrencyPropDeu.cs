using AbstractFactoryExample.abstractProp;

namespace AbstractFactoryExample.deu
{
    /// <summary>
    /// Конкретный параметр Волюта для Германии
    /// </summary>
    public class CurrencyPropDeu : CurrencyProp
    {
        private static string currency="euro";
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