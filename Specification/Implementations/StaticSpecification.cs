using System;
using System.Collections.Generic;
using System.Linq;

namespace Specification.Implementations
{
    public class StaticSpecification<T>
    {
        private readonly IList<Func<T, bool>> _Rules;

        protected internal StaticSpecification()
        {
            this._Rules = new List<Func<T, bool>>();
        }

        protected internal StaticSpecification<T> AddRule(Func<T, bool> rule)
        {
            this._Rules.Add(rule);
            return this;
        }

        public bool IsSatisfiedBy(T testable)
        {
            return this._Rules.All(r => r.Invoke(testable));
        }
    }
}
