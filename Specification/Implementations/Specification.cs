using System;
using System.Collections.Generic;
using System.Linq;

namespace Specification.Implementations
{
    public class Specification<T>
    {
        private readonly IList<Func<T, bool>> _Rules;

        protected internal Specification()
        {
            this._Rules = new List<Func<T, bool>>();
        }

        protected internal Specification<T> AddRule(Func<T, bool> rule)
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
