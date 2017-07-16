using Specification.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Specification.Implementations
{
    public abstract class Component : IComponent
    {
        public int Parameter { get; set; }
        public ISpecification<IComponent> Specification { get; protected internal set; }
        public bool IsValid
        {
            get
            {
                return this.Specification.IsSatisfiedBy(this);
            }
        }

        public Component(ISpecification<IComponent> specification)
        {
            this.Specification = specification;
        }
    }

    public class Component35 : Component, IComponent
    {
        public Component35(ISpecification<IComponent> specification) : base(specification)
        {

        }
    }

    public class Component60 : Component, IComponent
    {
        public Component60(ISpecification<IComponent> specification) : base(specification)
        {

        }
    }
}
