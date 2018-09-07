using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignExample
{
    class Services
    {
        public void Book(IProduct product)
        {
            Logger.GetInstance.SaveInToLogFile("-In Book "+product.ProductType+" Function-");
            product.IsBooked = true;
            product.ProductPrice += product.Fare;
            Console.WriteLine("ID: " + product.ProductId + "Name: " + product.ProductName + "Description: " + product.ProductDescription + product.ProductPrice);
            Console.WriteLine(product.ProductType + " Booked Successfully!!");
        }

        public void Save(IProduct product)
        {
            Logger.GetInstance.SaveInToLogFile("-In Save " + product.ProductType + " Function-");
            Console.WriteLine("Save");
            Console.WriteLine("ID: " + product.ProductId + "Name: " + product.ProductName + "Description: " + product.ProductDescription);
        }
    }
}
