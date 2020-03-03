using AbstractFactoryExample.abstractProp;

namespace AbstractFactoryExample
{
    /// <summary>
    /// Абстрактная фабрика настроек приложения
    /// </summary>
    public interface IRegionPropFactory
    {
        /// <summary>
        /// фабричный метод, создающий параметр "десятичный разделитель"
        /// </summary>
        DecimalSeparatorProp decimalSeparatorCreator();
        /// <summary>
        /// фабричный метод, создающий параметр "домен"
        /// </summary>
        DomainProp domainCreator();
        /// <summary>
        /// фабричный метод, создающий параметр "первый день недели"
        /// </summary>
        FirstDayOfTheWeekProp firstDayOfTheWeekCreator();
        /// <summary>
        /// фабричный метод, создающий параметр "шрифт"
        /// </summary>
        FontProp fontCreator();
        /// <summary>
        /// фабричный метод, создающий параметр "иконка с флагом страны"
        /// </summary>
        IconCountryProp iconCountryCreator();
        /// <summary>
        /// фабричный метод, создающий параметр "язык"
        /// </summary>
        LanguageProp languageCreator();
        /// <summary>
        /// фабричный метод, создающий параметр "иконка приложения"
        /// </summary>
        MainIconProp mainIconCreator();
        /// <summary>
        /// фабричный метод, создающий параметр "телефонный код"
        /// </summary>
        TelephoneCodeProp telephoneCodeCreator();
        /// <summary>
        /// фабричный метод, создающий параметр "часовой пояс по столице"
        /// </summary>
        CapitalTimeZoneProp capitalTimeZoneCreator();
        /// <summary>
        /// фабричный метод, создающий параметр "валюта"
        /// </summary>
        CurrencyProp currencyCreator();
    }
}