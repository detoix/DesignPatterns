using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWork.Items;

namespace UnitOfWork.Repository
{
    public interface IFamilyRepository
    {
        IEnumerable<IFamily> GetFamilies();
        IFamily Find(int id);
        void Add(IFamily family);
        void Delete(IFamily family);
        void Update(IFamily family);
        void RemoveAt(int id);
        void InsertAt(int id);
        void Refresh();
    }
}
