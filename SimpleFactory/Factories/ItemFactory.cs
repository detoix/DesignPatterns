using SimpleFactory.Items;
using System.Collections.Generic;

namespace SimpleFactory.Factories
{
    public enum ItemType
    {
        ConcreteObjectA,
        ConcreteObjectB
    }

    public class ItemFactory : IItemFactory
    {
        public IDictionary<ItemType, IItem> AvailableObjects { get; set; }
        public int SampleParameter { get; set; }
        

        public ItemFactory()
        {
            this.AvailableObjects = new Dictionary<ItemType, IItem>()
                {
                    { ItemType.ConcreteObjectA, new ConcreteItemA() },
                    { ItemType.ConcreteObjectB, new ConcreteItemB() },
                };
        }

        public IItem Build(ItemType request)
        {
            return this.AvailableObjects[request];
        }

        public IItem Build(ItemType request, int arg)
        {
            var obj = this.AvailableObjects[request];
                obj.SampleParameter = arg;
            return obj;
        }
    }
}
