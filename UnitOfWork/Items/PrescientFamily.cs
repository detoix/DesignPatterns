using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitOfWork.Items
{
    public class PrescientFamily : IFamily
    {
        public int Id { get; set; }
        public bool Edited { get; set; }
        public RevitFamily RevitFamily { get; set; }

        public PrescientFamily(RevitFamily revitFamily)
        {
            this.Id = revitFamily.Id;
            this.Edited = false;
            this.RevitFamily = revitFamily;
        }
    }
}
