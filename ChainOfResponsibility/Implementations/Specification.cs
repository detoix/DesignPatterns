using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Implementations
{
    public class SpecificationAny
    {
        SpecificationAny Next { get; }
        Func<Testable, bool> Rule { get; }

        public SpecificationAny(Func<Testable, bool> rule)
        {
            this.Rule = rule;
        }

        public SpecificationAny(Func<Testable,bool> rule, SpecificationAny next)
        {
            this.Rule = rule;
            this.Next = next;
        }

        public bool IsSatisfiedBy(Testable item)
        {
            return this.Rule(item) || this.Next.IsSatisfiedBy(item);
        }
    }
}
