using AbstractFactoryExample.abstractProp;

namespace AbstractFactoryExample.chn
{
    /// <summary>
    /// Конкретный параметр Телефонный код для Китая
    /// </summary>
    public class TelephoneCodePropChn : TelephoneCodeProp
    {
        private int code = 86;
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