using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotKeys.GoToImplementation
{
    /*
     * Включение отображнения иерархии наследования:
     * Текстовый редактор -> C# -> Дополнительно -> Показать границу насследования
     */

    // Перейти к реализации(-ям) - Ctrl+F12
    public interface IHasEngine
    {
        void StartEngine();
        void StopEngine();
    }
}
