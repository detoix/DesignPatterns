using System;
using System.IO;
using System.Reflection;
using System.Xml.Linq;

namespace Specification.Implementations
{
    public class StaticSpecificationForTestable : StaticSpecification<Testable>
    {
        private const double _MinValue = 5;
        private const double _MaxValue = 10;

        private static StaticSpecificationForTestable _Instance;
        public static StaticSpecificationForTestable Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new StaticSpecificationForTestable();
                }
                return _Instance;
            }
        }

        private StaticSpecificationForTestable() : base()
        {
            var pathToXml = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            var xElement = XElement.Load(pathToXml + "\\Resources\\resources.xml");

            this.AddRule(e => e != null)
                .AddRule(e => !e.Number.Equals(0))
                .AddRule(e => e.Number >= Double.Parse(xElement.Element("Minimum").Value))
                .AddRule(e => e.Number <= _MaxValue);
        }
    }
}
