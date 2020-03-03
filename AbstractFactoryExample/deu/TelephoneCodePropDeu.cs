using AbstractFactoryExample.abstractProp;

namespace AbstractFactoryExample.deu
{
    /// <summary>
    /// Конкретный параметр Телефонный код для Германии
    /// </summary>
    public class TelephoneCodePropDeu : TelephoneCodeProp
    {
        private int code = 49;
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