using SimpleFactory.Factories;
using System.Linq;

namespace SimpleFactory.Items
{
    public abstract class BaseItem : IItem
    {
        public int IntParameter { get; set; }
        public string StringParameter { get; set; }

        public BaseItem(ItemArguments arg)
        {
            this.IntParameter = arg.IntArg;
            this.StringParameter = arg.StringArg;
        }

        public abstract void SampleMethod();

        /// <summary>
        /// Get class name without namespace
        /// </summary>
        /// <returns>Class name without namespace</returns>
        public override string ToString()
        {
            return base.ToString().Split('.').Last();
        }
    }
}
