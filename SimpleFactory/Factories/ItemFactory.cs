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

    public enum System
    {
        _35,
        _60,
    }

    public class ItemFactory : IItemFactory
    {
        private static IItemFactory _Instance;
        public static IItemFactory Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new ItemFactory();

                return _Instance;
            }
        }

        private ItemFactory()
        {

        }

        public IItem Build(ItemType request, int arg)
        {
            switch (request)
            {
                case ItemType.ConcreteObjectA:
                    return new ConcreteItemA(arg);
                case ItemType.ConcreteObjectB:
                    return new ConcreteItemB(arg);
                default:
                    return new EmptyItem(arg);
            }
        }

        public IItem Build(ItemType request, int arg, string str)
        {
            switch (request)
            {
                case ItemType.ConcreteObjectA:
                    return new ConcreteItemA(arg, str);
                case ItemType.ConcreteObjectB:
                    return new ConcreteItemB(arg, str);
                default:
                    return new EmptyItem(arg, str);
            }
        }
    }
}