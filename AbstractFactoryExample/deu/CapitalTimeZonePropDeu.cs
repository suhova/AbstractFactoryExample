using AbstractFactoryExample.abstractProp;

namespace AbstractFactoryExample.deu
{
    public class CapitalTimeZonePropDeu : CapitalTimeZoneProp
    {
        private static int timeZone=1;
        public int getTimeZone()
        {
            return timeZone;
        }
    }
}