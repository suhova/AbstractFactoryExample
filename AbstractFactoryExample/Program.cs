using System;

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

            Application application = new Application(prop.languageCreator().getLanguage(),
                prop.domainCreator().getDomain(),
                prop.fontCreator().getFont(),
                prop.telephoneCodeCreator().getCode().ToString(),
                prop.decimalSeparatorCreator().getSeparator().ToString(),
                prop.currencyCreator().getCurrency(),
                prop.capitalTimeZoneCreator().getTimeZone().ToString(),
                prop.firstDayOfTheWeekCreator().getFirstDayOfTheWeek(),
                prop.mainIconCreator().getMainIcon(),
                prop.iconCountryCreator().getIconCountry());

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
                application.lang,
                application.domain,
                application.font,
                application.telCode,
                application.currency,
                application.separator,
                application.tz,
                application.firstDay,
                application.mainIcon,
                application.iconCountry);
        }
    }

    /// <summary>
    /// Класс - модель приложения для демонстрации
    /// </summary>
    class Application
    {
        public string lang;
        public string domain;
        public string font;
        public string telCode;
        public string separator;
        public string currency;
        public string tz;
        public string firstDay;
        public string mainIcon;
        public string iconCountry;

        /// <summary>
        /// Конструктор класса Application
        /// </summary>
        public Application(string lang, string domain, string font, string telCode, string separator, string currency,
            string tz, string firstDay, string mainIcon, string iconCountry)
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