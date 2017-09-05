using static SimpleFactory.Factories.ItemFactory;
using System;

namespace SimpleFactory.Items
{
    public class ConcreteItemB : BaseItem, IItem
    {
        public ConcreteItemB(int arg) : base(arg)
        {

        }

        public ConcreteItemB(int arg, string str) : base(arg)
        {

        }

        public override void SampleMethod()
        {
            throw new NotImplementedException();
        }
    }
}
