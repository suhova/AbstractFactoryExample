using AbstractFactoryExample.abstractProp;

namespace AbstractFactoryExample.chn
{
    public class MainIconPropChn : MainIconProp
    {
        private static string icon = "*путь к китайской версии иконки приложения*";
        public string getMainIcon()
        {
            return icon;
        }
    }
}