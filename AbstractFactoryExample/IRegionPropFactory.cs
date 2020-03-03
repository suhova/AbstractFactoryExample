using AbstractFactoryExample.abstractProp;

namespace AbstractFactoryExample
{
    public interface IRegionPropFactory
    {
        DecimalSeparatorProp decimalSeparatorCreator();
        DomainProp domainCreator();
        FirstDayOfTheWeekProp firstDayOfTheWeekCreator();
        FontProp fontCreator();
        IconCountryProp iconCountryCreator();
        LanguageProp languageCreator();
        MainIconProp mainIconCreator();
        TelephoneCodeProp telephoneCodeCreator();
        CapitalTimeZoneProp capitalTimeZoneCreator();
        CurrencyProp currencyCreator();
    }
}