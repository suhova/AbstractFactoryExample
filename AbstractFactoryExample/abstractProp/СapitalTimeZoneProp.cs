namespace AbstractFactoryExample.abstractProp
{
    /// <summary>
    /// Параметр Часовой пояс по столице
    /// </summary>
    public interface CapitalTimeZoneProp
    {
        /// <summary>
        /// Абстрактный метод, который возвращает часовой пояс по столице
        /// </summary>
        /// <returns>число - часовой пояс</returns>
        int getTimeZone();
    }
}