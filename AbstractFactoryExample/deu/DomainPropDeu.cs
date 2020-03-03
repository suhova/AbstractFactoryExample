using AbstractFactoryExample.abstractProp;

namespace AbstractFactoryExample.deu
{
    /// <summary>
    /// Конкретный параметр Домен для Германии
    /// </summary>
    public class DomainPropDeu : DomainProp
    {
        private static string domain = "de";
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