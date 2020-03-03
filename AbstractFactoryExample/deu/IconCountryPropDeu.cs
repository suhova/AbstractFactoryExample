using AbstractFactoryExample.abstractProp;

namespace AbstractFactoryExample.deu
{
    public class IconCountryPropDeu : IconCountryProp
    {
        private static string icon = "https://img.icons8.com/doodle/48/000000/germany.png";
        public string getIconCountry()
        {
            return icon;
        }
    }
}