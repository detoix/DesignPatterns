using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitOfWork.Items
{
    public interface IFamily
    {
        int Id { get; set; }
        bool Edited { get; set; }
        RevitFamily RevitFamily { get; set; }
    }
}
