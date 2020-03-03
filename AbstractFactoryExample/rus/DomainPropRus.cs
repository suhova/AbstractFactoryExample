using AbstractFactoryExample.abstractProp;

namespace AbstractFactoryExample.rus
{
    public class DomainPropRus : DomainProp
    {
        private static string domain = "ru";
        public string getDomain()
        {
            return domain;
        }
    }
}