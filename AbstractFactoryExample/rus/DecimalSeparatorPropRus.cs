using AbstractFactoryExample.abstractProp;

namespace AbstractFactoryExample.rus
{
    public class DecimalSeparatorPropRus : DecimalSeparatorProp
    {
        private static char separator = ',';
        public char getSeparator()
        {
            return separator;
        }
    }
}