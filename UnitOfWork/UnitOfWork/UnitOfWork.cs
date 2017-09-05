using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWork.Items;
using UnitOfWork.Repository;

namespace UnitOfWork.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork<RevitFamily>
    {
        public IRepository<RevitFamily> Repository { get; set; }

        public UnitOfWork(IEnumerable<RevitFamily> families)
        {
            this.Repository = new FamilyRespository(families);           
        }

        public void Foo()
        {
            var f = new RevitFamily();
            this.Repository.Add(f);

            var items = this.Repository.Items
                .Where(i => i.Key < 4);

            this.Repository.Delete(2);
        }

        public void Commit()
        {
            //foreach (var item in this.Repository)
            //{

            //}
        }
    }
}
