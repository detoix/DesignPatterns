using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Specification.Implementations
{
    public enum ItemType
    {
        ConcreteObjectA,
        ConcreteObjectB
    }

    public class SpecificationForTestableA : Specification<Testable>
    {
        private static SpecificationForTestableA _Instance;
        public static SpecificationForTestableA Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new SpecificationForTestableA();
                }
                return _Instance;
            }
        }

        private const double _MinValue = 5;
        private const double _MaxValue = 10;

        public SpecificationForTestableA() : base()
        {
            var pathToXml = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            var xElement = XElement.Load(pathToXml + "\\Resources\\resources.xml");

            this.AddRule(e => e != null)
                .AddRule(e => !e.Number.Equals(0))
                .AddRule(e => e.Number >= Double.Parse(xElement.Element("Minimum").Value))
                .AddRule(e => e.Number <= _MaxValue);
        }
    }

    public class SpecificationForTestableB : Specification<Testable>
    {
        private const double _MinValue = 10;
        private const double _MaxValue = 5;

        public SpecificationForTestableB() : base()
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
