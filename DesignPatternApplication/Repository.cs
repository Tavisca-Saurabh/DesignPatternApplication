using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignExample
{
    class Repository : IRepository
    {
        public void SaveInToDatabse(IProduct product)
        {
            Logger.GetInstance.SaveInToLogFile("-In Database Function-");
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Data Source=TAVDESK005;Initial Catalog=Products;User ID=sa;Password=test123!@#";
            connection.Open();
            SqlCommand command = new SqlCommand("insert into " + product.ProductType + "Product values(@ID,@Name,@Description,@IsBook)", connection);
            command.Parameters.AddWithValue("@ID", product.ProductId);
            command.Parameters.AddWithValue("@Name", product.ProductName);
            command.Parameters.AddWithValue("@Description", product.ProductDescription);
            command.Parameters.AddWithValue("@IsBook", product.IsBooked);
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void SaveInTextFile(IProduct product)
        {
            Logger.GetInstance.SaveInToLogFile("-In Save Function-");
            File.AppendAllText("C:/Users/smanchanda/Desktop/saveData.txt", "ID: " + product.ProductId + "Name: " + product.ProductName + "Description: " + product.ProductDescription + "isBooked: " + product.IsBooked);
        }

    }
}
