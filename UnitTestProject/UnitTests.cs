using Microsoft.VisualStudio.TestTools.UnitTesting;
using Specification.Implementations;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ConcreteSpecification_GivenItemOfValue10_ReturnsTrue()
        {
            var testable = new Testable { Number = 10 };
            var result = SpecificationForTestable.Instance.IsSatisfiedBy(testable);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ConcreteSpecification_GivenItemOfValue11_ReturnsFalse()
        {
            var testable = new Testable { Number = 11 };
            var result = SpecificationForTestable.Instance.IsSatisfiedBy(testable);
            Assert.IsFalse(result);
        }
    }
}
