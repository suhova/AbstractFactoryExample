using AbstractFactoryExample.abstractProp;

namespace AbstractFactoryExample.rus
{
    /// <summary>
    /// Конкретный параметр Иконка с флагом для России
    /// </summary>
    public class IconCountryPropRus : IconCountryProp
    {
        private static string icon = "https://img.icons8.com/doodle/48/000000/russian-federation.png";
        /// <summary>
        /// Метод, который возвращает ссылку на икноку с флагом страны
        /// </summary>
        /// <returns>строка с ссылкой на иконку с флагом</returns>
        public string getIconCountry()
        {
            return icon;
        }
    }
}