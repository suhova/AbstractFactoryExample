using AbstractFactoryExample.abstractProp;
using AbstractFactoryExample.chn;

namespace AbstractFactoryExample
{
    public class ChnPropFactory : IRegionPropFactory
    {
        public DecimalSeparatorProp decimalSeparatorCreator()
        {
            return new DecimalSeparatorPropChn();
        }

        public DomainProp domainCreator()
        {
            return new DomainPropChn();
        }

        public FirstDayOfTheWeekProp firstDayOfTheWeekCreator()
        {
            return new FirstDayOfTheWeekPropChn();
        }

        public FontProp fontCreator()
        {
            return new FontPropChn();
        }

        public IconCountryProp iconCountryCreator()
        {
            return new IconCountryPropChn();
        }

        public LanguageProp languageCreator()
        {
           return new LanguagePropChn();
        }

        public MainIconProp mainIconCreator()
        {
            return new MainIconPropChn();
        }

        public TelephoneCodeProp telephoneCodeCreator()
        {
            return new TelephoneCodePropChn();
        }

        public CapitalTimeZoneProp capitalTimeZoneCreator()
        {
            return new CapitalTimeZonePropChn();
        }

        public CurrencyProp currencyCreator()
        {
            return new CurrencyPropChn();
        }
    }
}