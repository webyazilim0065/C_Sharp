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
    public class CategoryService : ApplicationBaseService
    {
        public List<Categories> GetCategories()
        {
            string commandText = "select * from Categories";
            SqlCommand sqlCommand = new SqlCommand(commandText, sqlConnection);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            List<Categories> categoriesList = new List<Categories>();
            while (reader.Read())
            {
                Categories categories = new Categories();
                categories.Id = reader.GetInt32(0);
                categories.Name = reader.GetString(1);
                categories.Description = reader.GetString(2);
                categoriesList.Add(categories);
            }
            sqlConnection.Close();
            return categoriesList;
        }
    }
}
