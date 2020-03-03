using AbstractFactoryExample.abstractProp;

namespace AbstractFactoryExample.rus
{
    /// <summary>
    /// Конкретный параметр Домен для России
    /// </summary>
    public class DomainPropRus : DomainProp
    {
        private static string domain = "ru";
        /// <summary>
        /// Метод, который возвращает домен страны
        /// </summary>
        /// <returns>строка - домен</returns>
        public string getDomain()
        {
            return domain;
        }
    }
}