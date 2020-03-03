using AbstractFactoryExample.abstractProp;
using AbstractFactoryExample.rus;

namespace AbstractFactoryExample
{
    /// <summary>
    /// Класс-фабрика параметров для России
    /// </summary>
    public class RusPropFactory : IRegionPropFactory
    {
        /// <summary>
        /// метод, создающий параметр "десятичный разделитель" для России
        /// </summary>
        public DecimalSeparatorProp decimalSeparatorCreator()
        {
            return new DecimalSeparatorPropRus();
        }
        /// <summary>
        /// метод, создающий параметр "домен" для России
        /// </summary>
        public DomainProp domainCreator()
        {
            return new DomainPropRus();
        }

        /// <summary>
        /// метод, создающий параметр "первый день в неделе" для России
        /// </summary>
        public FirstDayOfTheWeekProp firstDayOfTheWeekCreator()
        {
            return new FirstDayOfTheWeekPropRus();
        }

        /// <summary>
        /// метод, создающий параметр "шрифт" для России
        /// </summary>
        public FontProp fontCreator()
        {
            return new FontPropRus();
        }

        /// <summary>
        /// метод, создающий параметр "иконка с флагом страны" для России
        /// </summary>
        public IconCountryProp iconCountryCreator()
        {
            return new IconCountryPropRus();
        }

        /// <summary>
        /// метод, создающий параметр "язык" для России
        /// </summary>
        public LanguageProp languageCreator()
        {
            return new LanguagePropRus();
        }

        /// <summary>
        /// метод, создающий параметр "основная иконка приложения" для России
        /// </summary>
        public MainIconProp mainIconCreator()
        {
            return new MainIconPropRus();
        }

        /// <summary>
        /// метод, создающий параметр "телефонный код" для России
        /// </summary>
        public TelephoneCodeProp telephoneCodeCreator()
        {
            return new TelephoneCodePropRus();
        }

        /// <summary>
        /// метод, создающий параметр "временаая зона по столице" для России
        /// </summary>
        public CapitalTimeZoneProp capitalTimeZoneCreator()
        {
            return new CapitalTimeZonePropRus();
        }

        /// <summary>
        /// метод, создающий параметр "валюта" для России
        /// </summary>
        public CurrencyProp currencyCreator()
        {
            return new CurrencyPropRus();
        }
    }
}