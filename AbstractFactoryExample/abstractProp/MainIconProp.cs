namespace AbstractFactoryExample.abstractProp
{
    /// <summary>
    /// Параметр Иконка приложения
    /// </summary>
    public interface MainIconProp
    {
        /// <summary>
        /// Абстрактный метод, который возвращает путь к иконке приложения
        /// </summary>
        /// <returns>строка - путь к иконке приложения</returns>
        string getMainIcon();
    }
}