using AbstractFactoryExample.abstractProp;

namespace AbstractFactoryExample.chn
{
    /// <summary>
    /// Конкретный параметр Десятичный разделитель для Китая
    /// </summary>
    public class DecimalSeparatorPropChn : DecimalSeparatorProp
    {
        private static char separator = '.';
        /// <summary>
        /// Метод, который возвращает символ разделителя для Китая
        /// </summary>
        /// <returns>символ разделителя</returns>
        public char getSeparator()
        {
            return separator;
        }
    }
}