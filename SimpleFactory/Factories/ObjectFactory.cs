using SimpleFactory.Objects;
using System.Collections.Generic;

namespace SimpleFactory.Factories
{
    public enum ObjectType
    {
        ConcreteObjectA,
        ConcreteObjectB
    }

    public class ObjectFactory : IObjectFactory
    {
        public IDictionary<ObjectType, IObject> AvailableObjects { get; set; }
        public int SampleParameter { get; set; }
        

        public ObjectFactory()
        {
            this.AvailableObjects = new Dictionary<ObjectType, IObject>()
                {
                    { ObjectType.ConcreteObjectA, new ConcreteObjectA() },
                    { ObjectType.ConcreteObjectB, new ConcreteObjectB() },
                };
        }

        public IObject Build(ObjectType request)
        {
            return this.AvailableObjects[request];
        }

        public IObject Build(ObjectType request, int arg)
        {
            var obj = this.AvailableObjects[request];
                obj.SampleParameter = arg;
            return obj;
        }
    }
}
