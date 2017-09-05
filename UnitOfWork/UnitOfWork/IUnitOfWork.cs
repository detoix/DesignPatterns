using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWork.Items;
using UnitOfWork.Repository;

namespace UnitOfWork.UnitOfWork
{
    public interface IUnitOfWork<T>
    {
        IRepository<T> Repository { get; set; }
        void Commit();
    }
}
