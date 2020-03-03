using AbstractFactoryExample.abstractProp;

namespace AbstractFactoryExample.deu
{
    /// <summary>
    /// Конкретный параметр Основная иконка приложения для Германии
    /// </summary>
    public class MainIconPropDeu : MainIconProp
    {
        private static string icon = "*путь к немецкой версии иконки приложения*";
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