using AbstractFactoryExample.abstractProp;

namespace AbstractFactoryExample.chn
{
    public class IconCountryPropChn : IconCountryProp
    {
        private static string icon = "https://img.icons8.com/doodle/48/000000/china.png";
        public string getIconCountry()
        {
            return icon;
        }
    }
}