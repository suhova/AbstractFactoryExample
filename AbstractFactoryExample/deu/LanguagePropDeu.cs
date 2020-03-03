using AbstractFactoryExample.abstractProp;

namespace AbstractFactoryExample.deu
{
    /// <summary>
    /// Конкретный параметр Язык для Германии
    /// </summary>
    public class LanguagePropDeu : LanguageProp
    {
        private static string language = "german";
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