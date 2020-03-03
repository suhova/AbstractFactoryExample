using AbstractFactoryExample.abstractProp;
using AbstractFactoryExample.rus;

namespace AbstractFactoryExample
{
    public class RusPropFactory : IRegionPropFactory
    {
        public DecimalSeparatorProp decimalSeparatorCreator()
        {
            return new DecimalSeparatorPropRus();
        }

        public DomainProp domainCreator()
        {
            return new DomainPropRus();
        }

        public FirstDayOfTheWeekProp firstDayOfTheWeekCreator()
        {
            return new FirstDayOfTheWeekPropRus();
        }

        public FontProp fontCreator()
        {
            return new FontPropRus();
        }

        public IconCountryProp iconCountryCreator()
        {
            return new IconCountryPropRus();
        }

        public LanguageProp languageCreator()
        {
            return new LanguagePropRus();
        }

        public MainIconProp mainIconCreator()
        {
            return new MainIconPropRus();
        }

        public TelephoneCodeProp telephoneCodeCreator()
        {
            return new TelephoneCodePropRus();
        }

        public CapitalTimeZoneProp capitalTimeZoneCreator()
        {
            return new CapitalTimeZonePropRus();
        }

        public CurrencyProp currencyCreator()
        {
            return new CurrencyPropRus();
        }
    }
}