using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ado.Net_CSharp_0065.Services.Base
{
    public class ApplicationBaseService
    {
        string connectionString = "Data source=DESKTOP-6VC48K2; Initial Catalog=NORTHWND; User Id=northwnduser; Password=123"; //Sql server auth
        protected readonly SqlConnection sqlConnection;
        public ApplicationBaseService()
        {
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
        }
    }
}
