using SimpleFactory.Items;
using System;
using System.Collections.Generic;

namespace SimpleFactory.Factories
{
    public interface IItemFactory
    {
        IDictionary<ItemType, Func<ItemArguments, IItem>> AvailableObjects { get; set; }

        IItem Build(ItemType request, int intArg, string stringArg);
    }
}
