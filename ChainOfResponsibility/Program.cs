using ChainOfResponsibility.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            var testable = new Testable();

            var specificaitonChain =
                new SpecificationAny(e => false,
                    new SpecificationAny(e => false,
                        new SpecificationAny(e => false
                            )));

            var meetsSpecificaiton = testable.MeetsSpecification(specificaitonChain);
        }
    }
}
