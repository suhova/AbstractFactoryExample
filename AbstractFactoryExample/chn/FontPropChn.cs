using AbstractFactoryExample.abstractProp;

namespace AbstractFactoryExample.chn
{
    public class FontPropChn : FontProp
    {
        private static string font = "https://fonts.googleapis.com/css?family=Noto+Sans+TC&display=swap";
        public string getFont()
        {
            return font;
        }
    }
}