using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWork.Items;

namespace UnitOfWork.Repository
{
    public interface IRepository<T>
    {
        #region Properties
        IEnumerable<T> RevitItems { get; set; }
        IDictionary<int,T> Items { get; set; }
        #endregion

        #region Methods
        void Add(T family);
        void Delete(int id);
        T Find(int id);
        #endregion
    }
}
