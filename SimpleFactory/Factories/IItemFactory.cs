using SimpleFactory.Items;
using System;
using System.Collections.Generic;
using static SimpleFactory.Factories.ItemFactory;

namespace SimpleFactory.Factories
{
    public interface IItemFactory
    {
        IItem Build(ItemType request, int arg);
    }
}
