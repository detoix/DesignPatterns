using Strategy.Strategies;
using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Context context;

                context = new Context(new ConcreteStrategyA());
                context.ContextInterface();

                context = new Context(new ConcreteStrategyB());
                context.ContextInterface();

                Console.ReadKey();
            }
        }
    }

    public class Context
    {
        public IStrategy Strategy { get; }

        public Context(IStrategy strategy)
        {
            this.Strategy = strategy;
        }

        public void ContextInterface()
        {
            this.Strategy.AlgorithmInterface();
        }
    }
}