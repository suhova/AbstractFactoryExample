using AbstractFactoryExample.abstractProp;

namespace AbstractFactoryExample.rus
{
    public class TelephoneCodePropRus : TelephoneCodeProp
    {
        private int code = 7;

        public int getCode()
        {
            return code;
        }
    }
}