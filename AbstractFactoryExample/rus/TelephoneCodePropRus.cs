using AbstractFactoryExample.abstractProp;

namespace AbstractFactoryExample.rus
{
    /// <summary>
    /// Конкретный параметр Телефонный код для России
    /// </summary>
    public class TelephoneCodePropRus : TelephoneCodeProp
    {
        private int code = 7;
        /// <summary>
        /// Метод, который возвращает телефонный код страны
        /// </summary>
        /// <returns>число - телефонный код</returns>

        public int getCode()
        {
            return code;
        }
    }
}