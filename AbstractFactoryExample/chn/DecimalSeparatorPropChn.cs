using AbstractFactoryExample.abstractProp;

namespace AbstractFactoryExample.chn
{
    public class DecimalSeparatorPropChn : DecimalSeparatorProp
    {
        private static char separator = '.';
        public char getSeparator()
        {
            return separator;
        }
    }
}