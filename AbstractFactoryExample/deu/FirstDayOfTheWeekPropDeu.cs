using AbstractFactoryExample.abstractProp;

namespace AbstractFactoryExample.deu
{
    public class FirstDayOfTheWeekPropDeu : FirstDayOfTheWeekProp
    {
        private static string day = "mo";
        public string getFirstDayOfTheWeek()
        {
            return day;
        }
    }
}