using SimpleFactory.Factories;
using System;

namespace SimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var itemA = ItemFactory.Instance.Build(ItemType.ConcreteObjectA, 12);
            var itemB = ItemFactory.Instance.Build(ItemType.ConcreteObjectB, 10);
            itemA.SampleMethod();
            Console.Read();
        }
    }
}
