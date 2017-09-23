using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Implementations
{
    public class Testable
    {
        public bool MeetsSpecification(SpecificationAny specificationChain)
        {
            return specificationChain.IsSatisfiedBy(this);
        }
    }
}
