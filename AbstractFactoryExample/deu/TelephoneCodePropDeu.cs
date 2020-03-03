using AbstractFactoryExample.abstractProp;

namespace AbstractFactoryExample.deu
{
    public class TelephoneCodePropDeu : TelephoneCodeProp
    {
        private int code = 49;

        public int getCode()
        {
            return code;
        }
    }
}