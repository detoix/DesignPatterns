using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWork.Repository;

namespace UnitOfWork.UnitOfWork
{
    public interface IUnitOfWork
    {
        IFamilyRepository Families { get; set; }
        void Commit();
    }
}
