using Ado.Net_CSharp_0065.Models;
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
            //string connectionString = "Data source=DESKTOP-6VC48K2; Initial Catalog=NORTHWND; Integrated Security=True"; //Windows auth
            string connectionString = "Data source=DESKTOP-6VC48K2; Initial Catalog=NORTHWND; User Id=northwnduser; Password=123"; //Sql server auth
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
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
                //Console.WriteLine($"{reader.GetString(0)} - {reader.GetDecimal(1)}");
            }
            sqlConnection.Close();
        }
    }
}
