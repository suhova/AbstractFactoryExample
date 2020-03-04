using System;
using AbstractFactoryExample.abstractProp;

namespace AbstractFactoryExample
{
    /// <summary>
    /// Класс для демонстрации параметров
    /// </summary>
    /// /// <remarks>
    /// Пользоваель вводит через консоль желаемую страну (ru - Россия, cn - Китай, de - Германия)
    /// </remarks>
    class Program
    {
        /// <summary>
        /// Точка входа в программу
        /// </summary>
        static void Main(string[] args)
        {
            Console.WriteLine("Введите страну: (ru - Россия, cn - Китай, de - Германия)\n");
            string country = Console.ReadLine()?.ToLower();
            IRegionPropFactory prop;
            switch (country)
            {
                case "cn":
                    prop = new ChnPropFactory();
                    break;
                case "de":
                    prop = new DeuPropFactory();
                    break;
                default:
                    prop = new RusPropFactory();
                    break;
            }

            Application application = new Application(prop.languageCreator(),
                prop.domainCreator(),
                prop.fontCreator(),
                prop.telephoneCodeCreator(),
                prop.decimalSeparatorCreator(),
                prop.currencyCreator(),
                prop.capitalTimeZoneCreator(),
                prop.firstDayOfTheWeekCreator(),
                prop.mainIconCreator(),
                prop.iconCountryCreator());

            Console.WriteLine("Язык: {0}\n" +
                              "Домен: {1}\n" +
                              "Шрифт: {2}\n" +
                              "Телефонный код: {3}\n" +
                              "Десятичный разделитель: {4}\n" +
                              "Валюта: {5}\n" +
                              "Часовой пояс (по столице): +{6}:00\n" +
                              "Первый день недели: {7}\n" +
                              "Основная иконка: {8}\n" +
                              "Иконка флага: {9}\n",
                application.lang.getLanguage(),
                application.domain.getDomain(),
                application.font.getFont(),
                application.telCode.getCode(),
                application.currency.getCurrency(),
                application.separator.getSeparator(),
                application.tz.getTimeZone(),
                application.firstDay.getFirstDayOfTheWeek(),
                application.mainIcon.getMainIcon(),
                application.iconCountry.getIconCountry());
        }
    }

    /// <summary>
    /// Класс - модель приложения для демонстрации
    /// </summary>
    class Application
    {
        public LanguageProp lang;
        public DomainProp domain;
        public FontProp font;
        public TelephoneCodeProp telCode;
        public DecimalSeparatorProp separator;
        public CurrencyProp currency;
        public CapitalTimeZoneProp tz;
        public FirstDayOfTheWeekProp firstDay;
        public MainIconProp mainIcon;
        public IconCountryProp iconCountry;

        /// <summary>
        /// Конструктор класса Application
        /// </summary>
        public Application(LanguageProp lang, DomainProp domain, FontProp font, TelephoneCodeProp telCode,
            DecimalSeparatorProp separator, CurrencyProp currency, CapitalTimeZoneProp tz,
            FirstDayOfTheWeekProp firstDay, MainIconProp mainIcon, IconCountryProp iconCountry)
        {
            this.lang = lang;
            this.domain = domain;
            this.font = font;
            this.telCode = telCode;
            this.separator = separator;
            this.currency = currency;
            this.tz = tz;
            this.firstDay = firstDay;
            this.mainIcon = mainIcon;
            this.iconCountry = iconCountry;
        }
    }
}