using System.Linq;

namespace SimpleFactory.Items
{
    public abstract class BaseItem : IItem
    {
        public int SampleParameter { get; set; }

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
