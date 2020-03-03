using AbstractFactoryExample.abstractProp;

namespace AbstractFactoryExample.chn
{
    public class CapitalTimeZonePropChn : CapitalTimeZoneProp
    {
        private static int timeZone=8;
        public int getTimeZone()
        {
            return timeZone;
        }
    }
}