using AbstractFactoryExample.abstractProp;

namespace AbstractFactoryExample.deu
{
    /// <summary>
    /// Конкретный параметр Шрифт для Германии
    /// </summary>
    public class FontPropDeu : FontProp
    {
        private static string font = "https://fonts.googleapis.com/css?family=Open+Sans&display=swap";
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