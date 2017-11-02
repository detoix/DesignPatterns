using Specification.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Specification
{
    class Program
    {
        static void Main(string[] args)
        {
            var t = new Testable();


            var ll = new List<Specification<Testable>>()
            {
                new SpecificationForTestableA(),
                new SpecificationForTestableB(),
            };

            var rt = ll.FirstOrDefault(e => e.IsSatisfiedBy(t)) ?? new SpecificationVoid();
        }
    }
}
