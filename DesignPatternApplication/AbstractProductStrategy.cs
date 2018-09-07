using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignExample
{
    abstract class AbstractProductStrategy
    {
        public abstract IProduct GetProduct(string productName);
    }
}
