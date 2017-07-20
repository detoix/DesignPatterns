using SimpleFactory.Factories;
using System;

namespace SimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var itemA = new ItemFactory().Build(ItemType.ConcreteObjectA);
            var itemB = new ItemFactory().Build(ItemType.ConcreteObjectB, 0, string.Empty);
            itemA.SampleMethod();
            Console.Read();
        }
    }
}
