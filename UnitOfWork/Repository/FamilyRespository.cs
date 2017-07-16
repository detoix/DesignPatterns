using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWork.Items;

namespace UnitOfWork.Repository
{
    public class FamilyRespository : IFamilyRepository
    {
        public IList<IFamily> Families { get; set; }

        public FamilyRespository(IEnumerable<IFamily> families)
        {
            this.Families = families.ToList();
        }

        public void Add(IFamily family)
        {
            this.Families.Add(family);
        }

        public void Delete(IFamily family)
        {
            this.Families.Remove(family);
        }

        public void RemoveAt(int id)
        {
            this.Families.RemoveAt(id);
            this.Refresh();
        }

        public void InsertAt(int id)
        {
            this.Families.Insert(id, new Family() { Id = 1, Name = "L1" });
            this.Refresh();
        }

        public IFamily Find(int id)
        {
            return this.Families.ElementAt(id);
        }

        public IEnumerable<IFamily> GetFamilies()
        {
            return this.Families;
        }

        public void Update(IFamily family)
        {
            if (this.Families.Contains(family))
            {
                //update
            }
            else
            {

            }
        }

        public void Refresh()
        {
            int i = 1;
            foreach (var family in this.Families)
            {
                family.Name = "L" + i.ToString();
                i++;
            }
        }
    }
}
