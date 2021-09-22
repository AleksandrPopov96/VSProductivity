using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CodeSnippetsAndSpecialCapabilities
{
    public class SpecialCapabilities
    {
        public void GetDay()
        {
            // Множественный курсор - Alt + Shift + выделение мышкой нужных строк
            var days = new List<DayOfWeek>
            {
                DayOfWeek.Monday,
                DayOfWeek.Tuesday,
                DayOfWeek.Wednesday,
                DayOfWeek.Thursday,
                DayOfWeek.Friday,
                DayOfWeek.Saturday,
                DayOfWeek.Sunday
            };

            Task t = Task.CompletedTask;
            // Включить вставку отсутствующих директив using при вставке кода из сторонних классов:
            // Текстовый редактор -> C# -> Дополнительно -> Директивы using -> Добавить недостающие директивы using при вставке

            // Включение перехода к декомпилированным источникам:
            // Текстовый редактор -> C# -> Дополнительно -> Анализ -> Включить переход к декомпилированным источникам

        }

    }
}
