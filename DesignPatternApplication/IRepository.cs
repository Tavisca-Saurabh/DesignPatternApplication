using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignExample
{
    interface IRepository
    {
        void SaveInToDatabse(IProduct product);
        void SaveInTextFile(IProduct product);
    }
}
