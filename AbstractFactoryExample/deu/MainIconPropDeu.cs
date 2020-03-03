using AbstractFactoryExample.abstractProp;

namespace AbstractFactoryExample.deu
{
    public class MainIconPropDeu : MainIconProp
    {
        private static string icon = "*путь к немецкой версии иконки приложения*";
        public string getMainIcon()
        {
            return icon;
        }
    }
}