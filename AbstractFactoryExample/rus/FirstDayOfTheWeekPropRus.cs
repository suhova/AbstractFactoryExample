using AbstractFactoryExample.abstractProp;

namespace AbstractFactoryExample.rus
{
    public class FirstDayOfTheWeekPropRus : FirstDayOfTheWeekProp
    {
        private static string day = "mo";
        public string getFirstDayOfTheWeek()
        {
            return day;
        }
    }
}