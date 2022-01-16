using Ado.Net_CSharp_0065.Models;
using Ado.Net_CSharp_0065.Services;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ado.Net_CSharp_0065
{
    class Program
    {
        static void Main(string[] args)
        {
            #region AdoNet
            //    //string connectionString = "Data source=DESKTOP-6VC48K2; Initial Catalog=NORTHWND; Integrated Security=True"; //Windows auth
            //    string connectionString = "Data source=DESKTOP-6VC48K2; Initial Catalog=NORTHWND; User Id=northwnduser; Password=123"; //Sql server auth
            //    SqlConnection sqlConnection = new SqlConnection(connectionString);
            //    sqlConnection.Open();
            //    string command = "Select ProductName,UnitPrice from Products";
            //    SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
            //    SqlDataReader reader = sqlCommand.ExecuteReader();
            //    List<Products> products = new List<Products>();
            //    while (reader.Read())
            //    {
            //        var product = new Products();
            //        product.ProductName = reader.GetString(0);
            //        product.UnitPrice = reader.GetDecimal(1);
            //        products.Add(product);
            //        //Console.WriteLine($"{reader.GetString(0)} - {reader.GetDecimal(1)}");
            //    }
            //    sqlConnection.Close();
            //
            #endregion

            #region AdoNet-2
            //Özel karakterleri devre dışı bırakmak için @ işareti kullanılır.
            //string @string = "Test";
            //string connectionString = "Data source=DESKTOP-6VC48K2; Initial Catalog=NORTHWND; Integrated Security=true";
            //SqlConnection connection = new SqlConnection(connectionString);
            //connection.Open();
            //string commandText = "select * from Categories";
            //SqlCommand sqlCommand = new SqlCommand(commandText, connection);
            //SqlDataReader reader = sqlCommand.ExecuteReader();
            //List<Categories> categoriesList = new List<Categories>();
            //while (reader.Read())
            //{
            //    Categories categories = new Categories();
            //    categories.Id = reader.GetInt32(0);
            //    categories.Name = reader.GetString(1);
            //    categories.Description = reader.GetString(2);
            //    categoriesList.Add(categories);
            //}
            //connection.Close();

            //Console.WriteLine("Kategori numarası giriniz");
            //string categoryId = Console.ReadLine();

            //connection.Open();
            //string command = "Select ProductName,UnitPrice from Products where CategoryId=@categoryId";
            //sqlCommand = new SqlCommand(command, connection);
            //sqlCommand.Parameters.AddWithValue("@categoryId", categoryId);
            //reader = sqlCommand.ExecuteReader();
            //List<Products> products = new List<Products>();
            //while (reader.Read())
            //{
            //    //var product = new Products();
            //    //product.ProductName = reader.GetString(0);
            //    //product.UnitPrice = reader.GetDecimal(1);
            //    //products.Add(product);
            //    Console.WriteLine($"{reader.GetString(0)} - {reader.GetDecimal(1)}");
            //}
            //connection.Close();
            #endregion

            CategoryService categoryService = new CategoryService();
            var categories = categoryService.GetCategories();

            ProductService productService = new ProductService();
            productService.GetProductsByCategory(1);
        }
    }
}
