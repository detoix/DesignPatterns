using System;

namespace SimpleFactory.Items
{
    public class ConcreteItemB : BaseItem, IItem
    {
        public override void SampleMethod()
        {
            throw new NotImplementedException();
        }
    }
}
