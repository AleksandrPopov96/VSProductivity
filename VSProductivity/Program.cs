using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace HotKeys
{
    public class Program
    {
        public static void Main()
        {
            // Окно просмотра состояния в дебаге - Shift + F9
            // Позволяет выполнять команды, например LINQ, вызов методов, сериализацию и т.п.
            
            
            var numbers = Enumerable
                .Range(1, 10000)
                .ToList();           

            Console.ReadLine();
            Console.WriteLine("234");
            Console.WriteLine();
            Console.WriteLine();

            Task t = Task.CompletedTask;
        }
    }
}
