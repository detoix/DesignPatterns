using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            string sth = ComponentNameBuilder
                .Component
                .WithName("X")
                .ProducedBy("Y")
                .Build();
            Console.WriteLine(sth);
            Console.Read();
        }
    }

    public interface INameHolder
    {
        IProducerHolder WithName(string name);
    }

    public interface IProducerHolder
    {
        IComponentNameBuilder ProducedBy(string producer);
    }

    public interface IComponentNameBuilder
    {
        string Build();
    }

    class ComponentNameBuilder: INameHolder, IProducerHolder, IComponentNameBuilder
    {
        private string _Name;
        private string _Producer;

        private ComponentNameBuilder() { }

        public static INameHolder Component
        {
            get { return new ComponentNameBuilder(); }
        }

        public IProducerHolder WithName(string name)
        {
            this._Name = name;
            return this;
        }

        public IComponentNameBuilder ProducedBy(string producer)
        {
            this._Producer = producer;
            return this;
        }

        public string Build()
        {
            return string.Format("Name: {0}, Producer: {1}", this._Name, this._Producer);
        }
    }
}
