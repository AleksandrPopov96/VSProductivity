using System;
using System.Collections.Generic;
using System.Linq;

namespace VSProductivity
{

    // Полный список всех сочетаний клавиш
    // https://docs.microsoft.com/ru-ru/visualstudio/ide/default-keyboard-shortcuts-in-visual-studio?view=vs-2019

    public interface IInterface
    {
        void RemoveById(string id);
    }

    public class General : IInterface
    {
        private double measureValue;

        // Поиск - Ctrl+F
        public enum HugeEnum
        {
            MeasureOne = 25,
            MeasureTwo = 27,
            MeasureThree = 49,
            MeasureTwentyOne = 125
        }

        //Свернуть/Развернуть сегмент - Ctrl+M, Ctrl+M
        //Свернуть все - Ctrl+M, Ctrl+O
        //Развернуть все - Ctrl+M, Ctrl+L
        public long Version { get; set; }
        public double Percent
        {
            get
            {
                return measureValue * 100;
            }
            set
            {
                measureValue = value / 100;
            }
        }


        public void RemoveById(string id)
        {
            // Закоментировать выделенное - Ctrl+K, Ctrl+C
            // Раскомментировать выделеное - Ctrl+K, Ctrl+U
            // Буфер обмена - Ctrl + Shift + V
            // Переместить блок кода - Alt + стрелка           
            // Перемещение между вкладками -  Ctrl + Tab
            Console.WriteLine("Removed");
        }

        // Добавить строку выше - Ctrl+Enter
        // Добавить строку ниже - Shift+Enter

        /// <summary>
        /// Получить по предикату
        /// </summary>
        /// <param name="predicate">Predicate</param>
        /// <returns>Массив object <see cref="Program"/></returns>
        public IEnumerable<object> GetByPredicate(Func<object, bool> predicate)
        {
            return Enumerable.Empty<object>();
        }

        // Создание summary для всего - ///
        public void UpdateById(string id, object item)
        {

        }

        // Добавление тела блока (скобочки { }) - shift + enter

    }
}
