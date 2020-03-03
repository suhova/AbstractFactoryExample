using AbstractFactoryExample.abstractProp;

namespace AbstractFactoryExample.deu
{
    /// <summary>
    /// Конкретный параметр Первый день в неделе для Германии
    /// </summary>
    public class FirstDayOfTheWeekPropDeu : FirstDayOfTheWeekProp
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