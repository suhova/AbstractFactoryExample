using AbstractFactoryExample.abstractProp;

namespace AbstractFactoryExample.chn
{
    /// <summary>
    /// Конкретный параметр Домен для Китая
    /// </summary>
    public class DomainPropChn : DomainProp
    {
        private static string domain = "cn";
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