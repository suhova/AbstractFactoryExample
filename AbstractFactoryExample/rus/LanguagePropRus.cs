using AbstractFactoryExample.abstractProp;

namespace AbstractFactoryExample.rus
{
    public class LanguagePropRus : LanguageProp
    {
        private static string language = "russian";
        public string getLanguage()
        {
            return language;
        }
    }
}