using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace FactoryDesignExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger.GetInstance.SaveInToLogFile("-Main Function-");
            ProductStrategy strategy = new ProductStrategy();
            while (true)
            {
                Console.WriteLine("1) Car \n2) Air \n3) Activity \n4) Hotel \n5) Exit");
                Console.WriteLine("Enter Product Name");
                string productName = Console.ReadLine();
                IProduct product = strategy.GetProduct(productName);
                Services serve = new Services();
                Repository database = new Repository();
                if (product != null)
                {
                    Console.WriteLine("1) Book Product \n2) Save Product");
                    int Option = Convert.ToInt32(Console.ReadLine());
                    if (Option == 1)
                    {
                        serve.Book(product);
                    }
                    else if (Option == 2)
                    {
                        serve.Save(product);
                        database.SaveInTextFile(product);
                    }

                    Console.WriteLine("1) SQLDatabase \n2) TextFile");
                    int BackupType = Convert.ToInt32(Console.ReadLine());
                    if (BackupType == 1)
                    {
                        database.SaveInToDatabse(product);
                    }
                    else if (BackupType == 2)
                    {
                        database.SaveInTextFile(product);
                        Console.WriteLine("File Created!!");
                    }
                    else if (BackupType == 3)
                    {
                        database.SaveInToDatabse(product);
                        database.SaveInTextFile(product);
                    }
                }
            }

        }
    }
}
