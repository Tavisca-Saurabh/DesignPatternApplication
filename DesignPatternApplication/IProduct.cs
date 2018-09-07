using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignExample
{
    interface IProduct
    {
        string ProductType { get; set; }
        string ProductId { get; set; }
        string ProductName { get; set; }
        string ProductDescription { get; set; }
        int ProductPrice { get; set; }
        bool IsBooked { get; set; }
        int Fare { get; set; }
    }
}
