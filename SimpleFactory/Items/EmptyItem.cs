using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SimpleFactory.Factories.ItemFactory;

namespace SimpleFactory.Items
{
    public class EmptyItem : BaseItem, IItem
    {
        public EmptyItem(int arg) : base(arg)
        {

        }

        public EmptyItem(int arg, string str) : base(arg)
        {

        }

        public override void SampleMethod()
        {
            
        }
    }
}
