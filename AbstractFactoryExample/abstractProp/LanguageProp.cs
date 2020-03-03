namespace AbstractFactoryExample.abstractProp
{
    /// <summary>
    /// Параметр Язык
    /// </summary>
    public interface LanguageProp
    {
        /// <summary>
        /// Абстрактный метод, который возвращает язык приложения
        /// </summary>
        /// <returns>строка с названием языка</returns>
        string getLanguage();
    }
}