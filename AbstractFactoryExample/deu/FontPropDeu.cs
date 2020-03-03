using AbstractFactoryExample.abstractProp;

namespace AbstractFactoryExample.deu
{
    public class FontPropDeu : FontProp
    {
        private static string font = "https://fonts.googleapis.com/css?family=Open+Sans&display=swap";
        public string getFont()
        {
            return font;
        }
    }
}