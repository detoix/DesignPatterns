using SimpleFactory.Items;
using System;
using System.Collections.Generic;

namespace SimpleFactory.Factories
{
    public enum ItemType
    {
        ConcreteObjectA,
        ConcreteObjectB
    }

    public struct ItemArguments
    {
        public int IntArg { get; set; }
        public string StringArg { get; set; }
    }

    public class ItemFactory : IItemFactory
    {
        public IDictionary<ItemType, Func<ItemArguments, IItem>> AvailableObjects { get; set; }

        public ItemFactory()
        {
            this.AvailableObjects = new Dictionary<ItemType, Func<ItemArguments, IItem>>()
            {
                { ItemType.ConcreteObjectA, arg => new ConcreteItemA(arg) },
                { ItemType.ConcreteObjectB, arg => new ConcreteItemB(arg) },
            };
        }

        public IItem Build(ItemType request)
        {
            return this.AvailableObjects[request](
                new ItemArguments());
        }

        public IItem Build(ItemType request, int intArg, string stringArg)
        {
            return this.AvailableObjects[request](
                new ItemArguments()
                {
                    IntArg = intArg,
                    StringArg = stringArg
                });
        }
    }
}