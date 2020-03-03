using AbstractFactoryExample.abstractProp;

namespace AbstractFactoryExample.chn
{
    public class LanguagePropChn : LanguageProp
    {
        private static string language = "chinese";
        public string getLanguage()
        {
            return language;
        }
    }
}