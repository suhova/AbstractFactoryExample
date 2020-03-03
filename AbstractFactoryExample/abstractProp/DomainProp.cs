namespace AbstractFactoryExample.abstractProp
{
    /// <summary>
    /// Параметр Домен
    /// </summary>
    public interface DomainProp
    {
        /// <summary>
        /// Абстракный метод, который возвращает домен страны
        /// </summary>
        /// <returns>строка - домен</returns>
        string getDomain();
    }
}