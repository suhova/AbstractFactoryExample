using AbstractFactoryExample.abstractProp;

namespace AbstractFactoryExample.rus
{
    /// <summary>
    /// Конкретный параметр Часоовой пояс по столице для России
    /// </summary>
    public class CapitalTimeZonePropRus : CapitalTimeZoneProp
    {
        private static int timeZone=3;
        /// <summary>
        /// Метод, который возвращает часовой пояс по столице
        /// </summary>
        /// <returns>число - часовой пояс</returns>
        public int getTimeZone()
        {
            return timeZone;
        }
    }
}