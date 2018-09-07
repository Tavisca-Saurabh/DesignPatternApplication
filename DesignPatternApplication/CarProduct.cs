using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FactoryDesignExample
{
    class CarProduct:IProduct
    {
        public string Name = "Audi";
        public string Id = "A1";
        public string description = "Car Product";
        public bool isBook = false;
        public string prodtype = "Car";
        public int fare = 20;
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
