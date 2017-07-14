using SimpleFactory.Factories;
using System;

namespace SimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var objA = new ObjectFactory().Build(ObjectType.ConcreteObjectA);
            var objB = new ObjectFactory().Build(ObjectType.ConcreteObjectB, 0);
            objA.SampleMethod();
            Console.Read();
        }
    }
}
