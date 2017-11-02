using SimpleFactory.Factories;
using SimpleFactory.Items;
using System;
using System.Collections.Generic;

namespace SimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var itemA = ItemFactory.Instance.Build(ItemType.ConcreteObjectA, 12);
            var itemB = ItemFactory.Instance.Build(ItemType.ConcreteObjectB, 10);

            var dd = DictionaryFactory.Builder[Factories.System._35][ItemType.ConcreteObjectA](40);

            Console.Read();            
        }
    }
}
