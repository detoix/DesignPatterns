using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWork.Items;
using System.Collections.Specialized;
using CommonGenius.Collections;
using UnitOfWork.Repository;

namespace UnitOfWork
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new Context(new List<Family>()
            {
                new Family() { Id = 1, Name = "L1" },
                new Family() { Id = 2, Name = "L2" },
                new Family() { Id = 3, Name = "L3" },
            });
            var unit = new UnitOfWork.UnitOfWork(context);
            unit.Commit();
            //OrderedDictionary myOrderedDictionary = new OrderedDictionary();
            //myOrderedDictionary.Add("testKey1", "testValue1");
            //myOrderedDictionary.Add("testKey2", "testValue2");
            //myOrderedDictionary.Add("keyToDelete", "valueToDelete");
            //myOrderedDictionary.Add("testKey3", "testValue3");
            //myOrderedDictionary.Remove("keyToDelete");
            //myOrderedDictionary.Add("keyToDelete", "valueToDelete");
            //myOrderedDictionary["testKey1"] = "saw";
            //myOrderedDictionary.Add("testKey1", "testValue1");
            Console.Read();
        }
    }

    public class Context
    {
        public IEnumerable<Family> Families { get; set; }

        public Context(IEnumerable<Family> families)
        {
            this.Families = families;
        }
    }
}
