using AbstractFactoryExample.abstractProp;

namespace AbstractFactoryExample.chn
{
    /// <summary>
    /// Конкретный параметр Язык для Китая
    /// </summary>
    public class LanguagePropChn : LanguageProp
    {
        private static string language = "chinese";
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