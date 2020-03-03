using AbstractFactoryExample.abstractProp;

namespace AbstractFactoryExample.chn
{
    public class TelephoneCodePropChn : TelephoneCodeProp
    {
        private int code = 86;

        public int getCode()
        {
            return code;
        }
    }
}