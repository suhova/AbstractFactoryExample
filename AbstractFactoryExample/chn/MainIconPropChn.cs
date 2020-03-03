using AbstractFactoryExample.abstractProp;

namespace AbstractFactoryExample.chn
{
    /// <summary>
    /// Конкретный параметр Основная иконка приложения для Китая
    /// </summary>
    public class MainIconPropChn : MainIconProp
    {
        private static string icon = "*путь к китайской версии иконки приложения*";
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