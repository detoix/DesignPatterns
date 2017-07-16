using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitOfWork.Items
{
    public class Family : IFamily
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
