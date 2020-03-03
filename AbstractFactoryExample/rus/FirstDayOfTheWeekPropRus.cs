using AbstractFactoryExample.abstractProp;

namespace AbstractFactoryExample.rus
{
    /// <summary>
    /// Конкретный параметр Первый день в неделе для России
    /// </summary>
    public class FirstDayOfTheWeekPropRus : FirstDayOfTheWeekProp
    {
        private static string day = "mo";
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