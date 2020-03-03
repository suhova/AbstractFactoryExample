using AbstractFactoryExample.abstractProp;

namespace AbstractFactoryExample.deu
{
    public class DomainPropDeu : DomainProp
    {
        private static string domain = "de";
        public string getDomain()
        {
            return domain;
        }
    }
}