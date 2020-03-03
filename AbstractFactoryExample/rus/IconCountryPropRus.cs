using AbstractFactoryExample.abstractProp;

namespace AbstractFactoryExample.rus
{
    public class IconCountryPropRus : IconCountryProp
    {
        private static string icon = "https://img.icons8.com/doodle/48/000000/russian-federation.png";
        public string getIconCountry()
        {
            return icon;
        }
    }
}