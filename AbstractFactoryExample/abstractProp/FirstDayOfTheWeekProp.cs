namespace AbstractFactoryExample.abstractProp
{
    /// <summary>
    /// Параметр Первый день в неделе
    /// </summary>
    public interface FirstDayOfTheWeekProp
    {
        /// <summary>
        /// Абстрактный метод, который возвращает первый день в неделе в стране
        /// </summary>
        /// <returns>строку с первым днём в неделе</returns>
        string getFirstDayOfTheWeek();
    }
}