namespace AbstractFactoryExample.abstractProp
{
    /// <summary>
    /// Параметр Шрифт
    /// </summary>
    public interface FontProp
    {
        /// <summary>
        /// Абстракный метод, который возвращает ссылку на шрифт
        /// </summary>
        /// <returns>строка с ссылкой на шрифт</returns>
        string getFont();
    }
}