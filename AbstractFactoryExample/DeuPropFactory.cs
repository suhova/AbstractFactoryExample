using AbstractFactoryExample.abstractProp;
using AbstractFactoryExample.deu;

namespace AbstractFactoryExample
{
    /// <summary>
    /// Класс-фабрика параметров для Германии
    /// </summary>
    public class DeuPropFactory : IRegionPropFactory
    {
        /// <summary>
        /// метод, создающий параметр "десятичный разделитель" для Германии
        /// </summary>
        public DecimalSeparatorProp decimalSeparatorCreator()
        {
            return new DecimalSeparatorPropDeu();
        }
        /// <summary>
        /// метод, создающий параметр "домен" для Германии
        /// </summary>
        public DomainProp domainCreator()
        {
            return new DomainPropDeu();
        }
        /// <summary>
        /// метод, создающий параметр "первый день недели" для Германии
        /// </summary>
        public FirstDayOfTheWeekProp firstDayOfTheWeekCreator()
        {
            return new FirstDayOfTheWeekPropDeu();
        }
        /// <summary>
        /// метод, создающий параметр "шрифт" для Германии
        /// </summary>
        public FontProp fontCreator()
        {
           return new FontPropDeu();
        }
        /// <summary>
        /// метод, создающий параметр "икнока с флагом страны" для Германии
        /// </summary>
        public IconCountryProp iconCountryCreator()
        {
            return new IconCountryPropDeu();
        }
        /// <summary>
        /// метод, создающий параметр "язык" для Германии
        /// </summary>
        public LanguageProp languageCreator()
        {
            return new LanguagePropDeu();
        }
        /// <summary>
        /// метод, создающий параметр "основаня икнка приложения" для Германии
        /// </summary>
        public MainIconProp mainIconCreator()
        {
            return new MainIconPropDeu();
        }
        /// <summary>
        /// метод, создающий параметр "телефонный код" для Германии
        /// </summary>
        public TelephoneCodeProp telephoneCodeCreator()
        {
            return new TelephoneCodePropDeu();
        }
        /// <summary>
        /// метод, создающий параметр "временная зона по столице" для Германии
        /// </summary>
        public CapitalTimeZoneProp capitalTimeZoneCreator()
        {
            return new CapitalTimeZonePropDeu();
        }
        /// <summary>
        /// метод, создающий параметр "валюта" для Германии
        /// </summary>
        public CurrencyProp currencyCreator()
        {
            return new CurrencyPropDeu();
        }
    }
}