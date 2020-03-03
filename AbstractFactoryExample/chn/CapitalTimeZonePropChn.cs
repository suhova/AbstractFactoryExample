using AbstractFactoryExample.abstractProp;

namespace AbstractFactoryExample.chn
{
    /// <summary>
    /// Конкретный параметр Часовой пояс по столице для Китая
    /// </summary>
    public class CapitalTimeZonePropChn : CapitalTimeZoneProp
    {
        private static int timeZone=8;
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