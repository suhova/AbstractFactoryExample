using AbstractFactoryExample.abstractProp;

namespace AbstractFactoryExample.deu
{
    /// <summary>
    /// Конкретный параметр Иконка с флагом для Германии
    /// </summary>
    public class IconCountryPropDeu : IconCountryProp
    {
        private static string icon = "https://img.icons8.com/doodle/48/000000/germany.png";
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