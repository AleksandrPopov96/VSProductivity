using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickActionsAndRefactoring
{
    public abstract class SomeAbstractClass
    {
        private string PrivateField { get; }

        protected SomeAbstractClass(string privateField)
        {
            PrivateField = privateField;
        }

        protected abstract string Foo { get; }

        protected abstract string DoAction();
    }

    // Настройка заполнения свойств по-умолчанию при реализации абстрактного класса или интерфейса:
    // Текстовый редактор -> C# -> Дополнительно -> Реализовать интерфейс или абстрактный класс
}
