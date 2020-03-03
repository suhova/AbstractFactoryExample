using AbstractFactoryExample.abstractProp;

namespace AbstractFactoryExample.rus
{
    /// <summary>
    /// Конкретный параметр Основная иконка приложения для России
    /// </summary>
    public class MainIconPropRus : MainIconProp
    {
        private static string icon = "*путь к российской версии иконки приложения*";
        /// <summary>
        /// Метод, который возвращает путь к иконке приложения
        /// </summary>
        /// <returns>строка - путь к иконке приложения</returns>
        public string getMainIcon()
        {
            return icon;
        }
    }
}