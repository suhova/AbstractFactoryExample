using AbstractFactoryExample.abstractProp;

namespace AbstractFactoryExample.rus
{
    public class FontPropRus : FontProp
    {
        private static string font = "https://fonts.googleapis.com/css?family=Roboto&display=swap";
        public string getFont()
        {
            return font;
        }
    }
}