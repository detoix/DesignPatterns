using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWork.Items;
using UnitOfWork.Repository;

namespace UnitOfWork.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        public Context Context { get; set; }
        public IFamilyRepository Families { get; set; }

        public UnitOfWork(Context context)
        {
            this.Context = context;
            this.Families = new FamilyRespository(context.Families);           
        }

        public void Commit()
        {
            var newCollection = new List<IFamily>()
            {
                new Family() { Id = 1, Name = "L1" },
                new Family() { Id = 2, Name = "L2" },
                new Family() { Id = 3, Name = "L3" },
                new Family() { Id = 3, Name = "L4" },
            };

            var toDelete = this.Families.GetFamilies().Where(e => !newCollection.Contains(e));
            var toAdd = newCollection.Where(e => !this.Families.GetFamilies().Contains(e));

            foreach (var item in toDelete)
            {
                this.Families.Delete(item);
            }

            foreach (var item in this.Families.GetFamilies())
            {
                var toModify = newCollection.First(e => e.Id == item.Id);
            }

            int i = 0;
            foreach (var item in toAdd)
            {
                this.Families.InsertAt(i);
                i++;
            }

            this.Families.Refresh();
        }
    }
}
