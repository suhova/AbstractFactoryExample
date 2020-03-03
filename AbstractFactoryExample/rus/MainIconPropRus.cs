using AbstractFactoryExample.abstractProp;

namespace AbstractFactoryExample.rus
{
    public class MainIconPropRus : MainIconProp
    {
        private static string icon = "*путь к российской версии иконки приложения*";
        public string getMainIcon()
        {
            return icon;
        }
    }
}