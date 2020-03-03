namespace AbstractFactoryExample.abstractProp
{
    /// <summary>
    /// Параметр Телефонный код страны
    /// </summary>
    public interface TelephoneCodeProp
    {
        /// <summary>
        /// Абстракный метод, который возвращает телефонный код страны
        /// </summary>
        /// <returns>число - телефонный код</returns>
        int getCode();
    }
}