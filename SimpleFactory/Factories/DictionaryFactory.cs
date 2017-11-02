using SimpleFactory.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory.Factories
{
    public class DictionaryFactory
    {
        private static IDictionary<ItemType, IItem> _Instance;

        public static IDictionary<ItemType, IItem> Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new Dictionary<ItemType, IItem>
                    {
                        { ItemType.ConcreteObjectA, new ConcreteItemA() },
                        { ItemType.ConcreteObjectB, new ConcreteItemB() },
                    };
                }
                return _Instance;
            }
        }

        private static IDictionary<System, IDictionary<ItemType, Func<int,IItem>>> _DictionaryFactory;

        public static IDictionary<System, IDictionary<ItemType, Func<int, IItem>>> Builder
        {
            get
            {
                if (_DictionaryFactory == null)
                {
                    var d1 = new Dictionary<ItemType, Func<int, IItem>>
                    {
                        { ItemType.ConcreteObjectA, e => new ConcreteItemA(e) },
                        { ItemType.ConcreteObjectB, e => new ConcreteItemB(e) },
                    };
                    var d2 = new Dictionary<ItemType, Func<int, IItem>>
                    {
                        { ItemType.ConcreteObjectA, e => new ConcreteItemA(e) },
                        { ItemType.ConcreteObjectB, e => new ConcreteItemB(e) },
                    };
                    _DictionaryFactory = new Dictionary<System, IDictionary<ItemType, Func<int, IItem>>>
                    {
                        { System._35, d1 },
                        { System._60, d2 },
                    };
                }
                return _DictionaryFactory;
            }
        }
    }
}
