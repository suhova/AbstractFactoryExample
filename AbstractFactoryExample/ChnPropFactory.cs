using AbstractFactoryExample.abstractProp;
using AbstractFactoryExample.chn;

namespace AbstractFactoryExample
{
    /// <summary>
    /// Класс-фабрика параметров для Китая
    /// </summary>
    public class ChnPropFactory : IRegionPropFactory
    {
        /// <summary>
        /// метод, создающий параметр "десятичный разделитель" для Китая
        /// </summary>
        public DecimalSeparatorProp decimalSeparatorCreator()
        {
            return new DecimalSeparatorPropChn();
        }
        /// <summary>
        /// метод, создающий параметр "домен" для Китая
        /// </summary>
        public DomainProp domainCreator()
        {
            return new DomainPropChn();
        }

        /// <summary>
        /// метод, создающий параметр "первый день в неделе" для Китая
        /// </summary>
        public FirstDayOfTheWeekProp firstDayOfTheWeekCreator()
        {
            return new FirstDayOfTheWeekPropChn();
        }

        /// <summary>
        /// метод, создающий параметр "шрифт" для Китая
        /// </summary>
        public FontProp fontCreator()
        {
            return new FontPropChn();
        }

        /// <summary>
        /// метод, создающий параметр "иконка с флагом страны" для Китая
        /// </summary>
        public IconCountryProp iconCountryCreator()
        {
            return new IconCountryPropChn();
        }

        /// <summary>
        /// метод, создающий параметр "язык" для Китая
        /// </summary>
        public LanguageProp languageCreator()
        {
            return new LanguagePropChn();
        }

        /// <summary>
        /// метод, создающий параметр "основная иконка приложения" для Китая
        /// </summary>
        public MainIconProp mainIconCreator()
        {
            return new MainIconPropChn();
        }

        /// <summary>
        /// метод, создающий параметр "телефонный код" для Китая
        /// </summary>
        public TelephoneCodeProp telephoneCodeCreator()
        {
            return new TelephoneCodePropChn();
        }

        /// <summary>
        /// метод, создающий параметр "временаая зона по столице" для Китая
        /// </summary>
        public CapitalTimeZoneProp capitalTimeZoneCreator()
        {
            return new CapitalTimeZonePropChn();
        }

        /// <summary>
        /// метод, создающий параметр "валюта" для Китая
        /// </summary>
        public CurrencyProp currencyCreator()
        {
            return new CurrencyPropChn();
        }
    }
}