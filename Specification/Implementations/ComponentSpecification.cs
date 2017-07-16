using Specification.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Specification.Implementations
{
    public abstract class ComponentSpecification : ISpecification<IComponent>
    {
        public int MinimumValue { get; protected internal set; }
        public int MaximumValue { get; protected internal set; }

        public bool IsSatisfiedBy(IComponent obj)
        {
            if (this.MinimumValue < obj.Parameter && obj.Parameter < this.MaximumValue)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    public class ComponentSpecification35 : ComponentSpecification, ISpecification<IComponent>
    {
        public ComponentSpecification35()
        {
            this.MinimumValue = 0;
            this.MaximumValue = 10;
        }
    }

    public class ComponentSpecification60 : ComponentSpecification, ISpecification<IComponent>
    {
        public ComponentSpecification60()
        {
            this.MinimumValue = 10;
            this.MaximumValue = 20;
        }
    }
}
