using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignExample
{
    class AirProduct:IProduct
    {
        public string Name = "Air";
        public string Id = "Ar1";
        public string description = "Air Product";
        public bool isBook = false;
        public string prodtype = "Air";
        public int fare = 40;
        public int price = 100;

        public int ProductPrice { get { return price; } set { price = value; } }
        public int Fare { get { return fare; } set { fare = value; } }
        public string ProductType { get { return prodtype; } set { prodtype = value; } }
        public string ProductId { get { return Id; } set { Id = value; } }
        public string ProductName { get { return Name; } set { Name = value; } }
        public string ProductDescription { get { return description; } set { description = value; } }
        public bool IsBooked { get { return isBook; } set { isBook = value; } }
    }
}
