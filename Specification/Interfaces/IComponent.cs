using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Specification.Interfaces
{
    public interface IComponent
    {
        int Parameter { get; set; }
        bool IsValid { get; }
    }
}