using SimpleFactory.Factories;
using System;

namespace SimpleFactory.Items
{
    public class ConcreteItemA : BaseItem, IItem
    {
        public ConcreteItemA(ItemArguments arg) : base(arg)
        {

        }

        public override void SampleMethod()
        {
            throw new NotImplementedException();
        }
    }
}
