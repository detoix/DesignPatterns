using SimpleFactory.Objects;
using System.Collections.Generic;

namespace SimpleFactory.Factories
{
    public interface IObjectFactory
    {
        IDictionary<ObjectType, IObject> AvailableObjects { get; set; }

        IObject Build(ObjectType request);
        IObject Build(ObjectType request, int arg);
    }
}
