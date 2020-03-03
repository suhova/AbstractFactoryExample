using AbstractFactoryExample.abstractProp;

namespace AbstractFactoryExample.deu
{
    /// <summary>
    /// Конкретный параметр Десятичный разделитель для Германии
    /// </summary>
    public class DecimalSeparatorPropDeu : DecimalSeparatorProp
    {
        private static char separator = ',';
        /// <summary>
        /// Абстракный метод, который возвращает символ разделителя для Германии
        /// </summary>
        /// <returns>символ разделителя</returns>
        public char getSeparator()
        {
            return separator;
        }
    }
}