using AbstractFactoryExample.abstractProp;

namespace AbstractFactoryExample.chn
{
    /// <summary>
    /// Конкретный параметр Шрифт для Китая
    /// </summary>
    public class FontPropChn : FontProp
    {
        private static string font = "https://fonts.googleapis.com/css?family=Noto+Sans+TC&display=swap";
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