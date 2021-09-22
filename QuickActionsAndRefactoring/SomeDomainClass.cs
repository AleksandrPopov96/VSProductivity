using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickActionsAndRefactoring
{

    public class SomeDomainClass
    {
        public SomeDomainClass(int myPropertyOne, string myPropertyTwo, double myPropertyThree)
        {
            MyPropertyOne = myPropertyOne;
            MyPropertyTwo = myPropertyTwo;
            MyPropertyThree = myPropertyThree;
        }

        public int MyPropertyOne { get; set; }
        public string MyPropertyTwo { get; set; }
        public double MyPropertyThree { get; set; }

        public override bool Equals(object obj)
        {
            return obj is SomeDomainClass @class &&
                   MyPropertyOne == @class.MyPropertyOne &&
                   MyPropertyTwo == @class.MyPropertyTwo &&
                   MyPropertyThree == @class.MyPropertyThree;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(MyPropertyOne, MyPropertyTwo, MyPropertyThree);
        }
    }

    public struct SomeDomainStruct : IFoo, IEquatable<SomeDomainStruct>
    {
        private const int gfdhgs = 100;

        public SomeDomainStruct(int id)
        {
            Id = id;
        }
        public int MyPropertyOne { get; set; }
        public string MyPropertyTwo { get; set; }
        public double MyPropertyThree { get; set; }
        public int Id { get; }

        public void DisplayProperties(SomeDomainClass someClassFirst, SomeDomainClass someClassSecond)
        {
            if (someClassFirst is null)
            {
                throw new ArgumentNullException(nameof(someClassFirst));
            }

            if (someClassSecond is null)
            {
                throw new ArgumentNullException(nameof(someClassSecond));
            }

            Console.WriteLine(someClassFirst.MyPropertyOne);
            Console.WriteLine(someClassFirst.MyPropertyTwo);
            Console.WriteLine(someClassFirst.MyPropertyThree);
            MyMethod(someClassSecond);
        }

        private static void MyMethod(SomeDomainClass someClassSecond)
        {

            //Автодополнение кода - Ctrl+Space
            Console.WriteLine(someClassSecond.MyPropertyOne);

            var ids = Enumerable.Range(1, 10).ToList();
            for (int i = 0; i < ids.Count; i++)
            {
                Console.WriteLine(ids[i]);
            }
        }

        public long DivideByConstant(long number)
        {
            if (DateTime.IsLeapYear(DateTime.Now.Year) || DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month) == 31)
                return number / gfdhgs;

            return number;
        }

        public long FabricMethod(string key)
        {
            switch (key)
            {
                case "one": return 1;
                case "two": return 2;
                case "three": return 3;
                default: throw new NotImplementedException();
            }
        }

        public override bool Equals(object obj)
        {
            return obj is SomeDomainStruct @struct && Equals(@struct);
        }

        public bool Equals(SomeDomainStruct other)
        {
            return MyPropertyOne == other.MyPropertyOne &&
                   MyPropertyTwo == other.MyPropertyTwo &&
                   MyPropertyThree == other.MyPropertyThree &&
                   Id == other.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(MyPropertyOne, MyPropertyTwo, MyPropertyThree, Id);
        }

        public static bool operator ==(SomeDomainStruct left, SomeDomainStruct right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(SomeDomainStruct left, SomeDomainStruct right)
        {
            return !(left == right);
        }
    }
}
