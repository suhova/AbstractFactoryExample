using AbstractFactoryExample.abstractProp;

namespace AbstractFactoryExample.deu
{
    /// <summary>
    /// Конкретный параметр Часовой пояс по столице для Германии
    /// </summary>
    public class CapitalTimeZonePropDeu : CapitalTimeZoneProp
    {
        private static int timeZone=1;
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