using SimpleFactory.Factories;
using System;

namespace SimpleFactory.Items
{
    public class ConcreteItemB : BaseItem, IItem
    {
        public ConcreteItemB(ItemArguments arg) : base(arg)
        {

        }

        public override void SampleMethod()
        {
            throw new NotImplementedException();
        }
    }
}
