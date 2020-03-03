using AbstractFactoryExample.abstractProp;

namespace AbstractFactoryExample.chn
{
    public class FirstDayOfTheWeekPropChn : FirstDayOfTheWeekProp
    {
        private static string day = "su";
        public string getFirstDayOfTheWeek()
        {
            return day;
        }
    }
}