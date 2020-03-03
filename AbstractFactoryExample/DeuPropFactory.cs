using AbstractFactoryExample.abstractProp;
using AbstractFactoryExample.deu;

namespace AbstractFactoryExample
{
    public class DeuPropFactory : IRegionPropFactory
    {
        public DecimalSeparatorProp decimalSeparatorCreator()
        {
            return new DecimalSeparatorPropDeu();
        }

        public DomainProp domainCreator()
        {
            return new DomainPropDeu();
        }

        public FirstDayOfTheWeekProp firstDayOfTheWeekCreator()
        {
            return new FirstDayOfTheWeekPropDeu();
        }

        public FontProp fontCreator()
        {
           return new FontPropDeu();
        }

        public IconCountryProp iconCountryCreator()
        {
            return new IconCountryPropDeu();
        }

        public LanguageProp languageCreator()
        {
            return new LanguagePropDeu();
        }

        public MainIconProp mainIconCreator()
        {
            return new MainIconPropDeu();
        }

        public TelephoneCodeProp telephoneCodeCreator()
        {
            return new TelephoneCodePropDeu();
        }

        public CapitalTimeZoneProp capitalTimeZoneCreator()
        {
            return new CapitalTimeZonePropDeu();
        }

        public CurrencyProp currencyCreator()
        {
            return new CurrencyPropDeu();
        }
    }
}