using AbstractFactoryExample.abstractProp;

namespace AbstractFactoryExample.rus
{
    /// <summary>
    /// Конкретный параметр Язык для России
    /// </summary>
    public class LanguagePropRus : LanguageProp
    {
        private static string language = "russian";
        /// <summary>
        /// Метод, который возвращает язык приложения
        /// </summary>
        /// <returns>строка с названием языка</returns>
        public string getLanguage()
        {
            return language;
        }
    }
}