using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWork.Items;
using UnitOfWork.RevitUtils;

namespace UnitOfWork.Repository
{
    public class FamilyRespository : IRepository<RevitFamily>
    {
        public IEnumerable<RevitFamily> RevitItems { get; set; }
        public IDictionary<int, RevitFamily> Items { get; set; }
        public IList<RevitFamily> AddedItems { get; set; }
        public IList<RevitFamily> EditedItems { get; set; }
        public IList<RevitFamily> DeletedItems { get; set; }

        public FamilyRespository(IEnumerable<RevitFamily> revitItems)
        {
            this.RevitItems = revitItems;
        }

        public void Add(RevitFamily family)
        {
            this.AddedItems.Add(family);
        }

        public void Delete(int id)
        {
            //this.DeletedItems.Add();
        }

        public RevitFamily Find(int id)
        {
            if (!this.Items.ContainsKey(id))
            {
                this.Items[id] = DocumentDB.GetElementById(id);
            }
            return this.Items[id];
        }
    }
}
