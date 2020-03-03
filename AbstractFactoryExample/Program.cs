using System;

namespace AbstractFactoryExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите страну: (ru - Россия, cn - Китай, de - Германия)");
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
            Console.WriteLine("Язык: {0}\n" +
                              "Домен: {1}\n" +
                              "Шрифт: {2}\n" +
                              "Телефонный код: {3}\n" +
                              "Десятичный разделитель: {4}\n" +
                              "Валюта: {5}\n" +
                              "Часовой пояс (по столице): {6}:00\n" +
                              "Первый день недели: {7}\n" +
                              "Основная иконка: {8}\n" +
                              "Иконка флага: {9}\n",
                prop.languageCreator().getLanguage(),
                prop.domainCreator().getDomain(),
                prop.fontCreator().getFont(),
                prop.telephoneCodeCreator().getCode(),
                prop.decimalSeparatorCreator().getSeparator(),
                prop.currencyCreator().getCurrency(),
                prop.capitalTimeZoneCreator().getTimeZone(),
                prop.firstDayOfTheWeekCreator().getFirstDayOfTheWeek(),
                prop.mainIconCreator().getMainIcon(),
                prop.iconCountryCreator().getIconCountry());
        }
    }
}

