using static SimpleFactory.Factories.ItemFactory;
using System;

namespace SimpleFactory.Items
{
    public class ConcreteItemA : BaseItem, IItem
    {
        public ConcreteItemA() : base()
        {

        }

        public ConcreteItemA(int arg) : base(arg)
        {

        }

        public ConcreteItemA(int arg, string str) : base(arg)
        {

        }
    }
}
