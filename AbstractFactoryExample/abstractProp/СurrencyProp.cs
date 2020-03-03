namespace AbstractFactoryExample.abstractProp
{
    /// <summary>
    /// Параметр Валюта
    /// </summary>
    public interface CurrencyProp
    {
        /// <summary>
        /// Абстрактный метод, который возвращает название валюты
        /// </summary>
        /// <returns>строка с названием валюты</returns>
        string getCurrency();
    }
}