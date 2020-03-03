using AbstractFactoryExample.abstractProp;

namespace AbstractFactoryExample.rus
{
    /// <summary>
    /// Конкретный параметр Шрифт для России
    /// </summary>
    public class FontPropRus : FontProp
    {
        private static string font = "https://fonts.googleapis.com/css?family=Roboto&display=swap";
        /// <summary>
        /// Метод, который возвращает ссылку на шрифт
        /// </summary>
        /// <returns>строка с ссылкой на шрифт</returns>
        public string getFont()
        {
            return font;
        }
    }
}