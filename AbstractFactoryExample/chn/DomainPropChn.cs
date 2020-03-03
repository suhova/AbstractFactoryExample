using AbstractFactoryExample.abstractProp;

namespace AbstractFactoryExample.chn
{
    public class DomainPropChn : DomainProp
    {
        private static string domain = "cn";
        public string getDomain()
        {
            return domain;
        }
    }
}