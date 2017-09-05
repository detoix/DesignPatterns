using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWork.Items;

namespace UnitOfWork.RevitUtils
{
    public static class DocumentDB
    {
        public static RevitFamily GetElementById(int id)
        {
            return new RevitFamily();
        }
        public static RevitFamily Create()
        {
            return new RevitFamily();
        }
    }
}
