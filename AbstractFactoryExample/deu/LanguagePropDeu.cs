using AbstractFactoryExample.abstractProp;

namespace AbstractFactoryExample.deu
{
    public class LanguagePropDeu : LanguageProp
    {
        private static string language = "german";
        public string getLanguage()
        {
            return language;
        }
    }
}