using static SimpleFactory.Factories.ItemFactory;
using System.Linq;

namespace SimpleFactory.Items
{
    public abstract class BaseItem : IItem
    {
        public int Parameter { get; }

        public BaseItem()
        {

        }

        public BaseItem(int arg)
        {
            this.Parameter = arg;
        }

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
