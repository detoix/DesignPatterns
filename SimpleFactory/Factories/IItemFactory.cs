using SimpleFactory.Items;
using System.Collections.Generic;

namespace SimpleFactory.Factories
{
    public interface IItemFactory
    {
        IDictionary<ItemType, IItem> AvailableObjects { get; set; }

        IItem Build(ItemType request);
        IItem Build(ItemType request, int arg);
    }
}
