using System;

namespace SimpleFactory.Items
{
    public class ConcreteItemA : BaseItem, IItem
    {
        public override void SampleMethod()
        {
            throw new NotImplementedException();
        }
    }
}
