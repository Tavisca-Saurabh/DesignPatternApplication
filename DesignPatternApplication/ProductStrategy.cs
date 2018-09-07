using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignExample
{
    class ProductStrategy : AbstractProductStrategy
    {
        public override IProduct GetProduct(string productName)
        {
            //switch (desc)
            //{
            //    case 1:
            //        return new CarProduct();
            //    case 2:
            //        return new AirProduct();
            //    case 3:
            //        return new ActivityProduct();
            //    case 4:
            //        return new HotelProduct();
            //    default:
            //        return new Default();
            //}
            //History.Instance.AddToLogFile("returning the instance dynamically.");
            try
            {
                System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
                var productType = assembly.GetTypes().FirstOrDefault(t => t.Name == productName + "Product");
                return (IProduct)Activator.CreateInstance(productType);
            }
            catch
            {
                Console.WriteLine("Wrong Input");
            }
            return null;
        }
    }
}
