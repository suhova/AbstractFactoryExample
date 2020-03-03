using AbstractFactoryExample.abstractProp;

namespace AbstractFactoryExample.chn
{
    /// <summary>
    /// Конкретный параметр Первый день в неделе для Китая
    /// </summary>
    public class FirstDayOfTheWeekPropChn : FirstDayOfTheWeekProp
    {
        private static string day = "su";
        /// <summary>
        /// Метод, который возвращает первый день в неделе в стране
        /// </summary>
        /// <returns>строку с первым днём в неделе</returns>
        public string getFirstDayOfTheWeek()
        {
            return day;
        }
    }
}