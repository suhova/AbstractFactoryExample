using AbstractFactoryExample.abstractProp;

namespace AbstractFactoryExample.rus
{
    public class CapitalTimeZonePropRus : CapitalTimeZoneProp
    {
        private static int timeZone=3;
        public int getTimeZone()
        {
            return timeZone;
        }
    }
}