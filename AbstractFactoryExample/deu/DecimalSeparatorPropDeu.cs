using AbstractFactoryExample.abstractProp;

namespace AbstractFactoryExample.deu
{
    public class DecimalSeparatorPropDeu : DecimalSeparatorProp
    {
        private static char separator = ',';
        public char getSeparator()
        {
            return separator;
        }
    }
}