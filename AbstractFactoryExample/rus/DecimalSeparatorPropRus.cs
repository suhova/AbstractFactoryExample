using AbstractFactoryExample.abstractProp;

namespace AbstractFactoryExample.rus
{
    /// <summary>
    /// Конкретный параметр Десятичный разделитель для России
    /// </summary>
    public class DecimalSeparatorPropRus : DecimalSeparatorProp
    {
        private static char separator = ',';
        /// <summary>
        /// Метод, который возвращает символ разделителя для России
        /// </summary>
        /// <returns>символ разделителя</returns>
        public char getSeparator()
        {
            return separator;
        }
    }
}