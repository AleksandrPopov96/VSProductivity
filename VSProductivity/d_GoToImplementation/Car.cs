using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotKeys.GoToImplementation
{
    public class Car : IHasEngine
    {
        // Перейти к интерфейсу - F12
        public void StartEngine()
        {
            Console.WriteLine("Whom-Whom");
        }

        public void StopEngine()
        {
            Console.WriteLine("Tr-tr-tr");
        }
    }
}
