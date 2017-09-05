using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWork.Items;
using System.Collections.Specialized;
using UnitOfWork.Repository;

namespace UnitOfWork
{
    class Program
    {
        static void Main(string[] args)
        {
            var filteredElementCollectorResult = new List<RevitFamily>()
            {
                new RevitFamily() { Id = 1, Name = "L1" },
                new RevitFamily() { Id = 2, Name = "L2" },
                new RevitFamily() { Id = 3, Name = "L3" },
            };
            var unitOfWork = new UnitOfWork.UnitOfWork(filteredElementCollectorResult);
            unitOfWork.Commit();
        }
    }
}
