using System;

namespace SimpleFactory.Objects
{
    public class ConcreteObjectB : BaseObject, IObject
    {
        public override void SampleMethod()
        {
            throw new NotImplementedException();
        }
    }
}
