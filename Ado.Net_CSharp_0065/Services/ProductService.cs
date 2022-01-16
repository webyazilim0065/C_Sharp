using Ado.Net_CSharp_0065.Models;
using Ado.Net_CSharp_0065.Services.Base;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ado.Net_CSharp_0065.Services
{
    public class ProductService : ApplicationBaseService
    {
        public List<Products> GetProducts()
        {
            string command = "Select ProductName,UnitPrice from Products";
            SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            List<Products> products = new List<Products>();
            while (reader.Read())
            {
                var product = new Products();
                product.ProductName = reader.GetString(0);
                product.UnitPrice = reader.GetDecimal(1);
                products.Add(product);
            }
            sqlConnection.Close();
            return products;
        }

        public List<Products> GetProductsByCategory(int categoryId)
        {         
            string command = "Select ProductName,UnitPrice from Products where CategoryId=@categoryId";
            SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@categoryId", categoryId);
            var reader = sqlCommand.ExecuteReader();
            List<Products> products = new List<Products>();
            while (reader.Read())
            {
                var product = new Products();
                product.ProductName = reader.GetString(0);
                product.UnitPrice = reader.GetDecimal(1);
                products.Add(product);
            }
            sqlConnection.Close();
            return products;
        }
    }
}
