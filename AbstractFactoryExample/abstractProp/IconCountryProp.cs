namespace AbstractFactoryExample.abstractProp
{
    /// <summary>
    /// Параметр Иконка с флагом страны
    /// </summary>
    public interface IconCountryProp
    {
        /// <summary>
        /// Абстрактный метод, который возвращает ссылку на икноку с флагом страны
        /// </summary>
        /// <returns>строка с ссылкой на иконку с флагом</returns>
        string getIconCountry();
    }
}