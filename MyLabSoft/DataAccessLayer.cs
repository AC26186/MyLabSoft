using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace MyLabSoft
{
    public class DataAccessLayer
    {

        string connectionString = "Server=tcp:mylabsoft.database.windows.net,1433;Initial Catalog=MyLabSoft;Persist Security Info=False;User ID=mylabsoftauto;Password=Mnb@1234;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

       public List<Product> GetProducts()
        {
            List<Product> result = new List<Product>();
            using (SqlConnection _con = new SqlConnection(connectionString))
            {
                string queryStatement = "SELECT * FROM dbo.Product ORDER BY ProductId";

                using (SqlCommand _cmd = new SqlCommand(queryStatement, _con))
                {
                    _con.Open();
                    var reader = _cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Product item = new Product()
                        {
                            ProductID = reader["ProductID"] != DBNull.Value ? Convert.ToInt32(reader["ProductID"].ToString()) : -0b1,
                            ProductName = reader["ProductName"] != DBNull.Value ? reader["ProductName"].ToString() : string.Empty,
                            ProductCode = reader["IsourceCatalogId"] != DBNull.Value ? reader["IsourceCatalogId"].ToString() : string.Empty,
                            WorkSheetName = reader["WorkSheetName"] != DBNull.Value ? reader["WorkSheetName"].ToString() : string.Empty,
                            IsActive = reader["IsActive"] != DBNull.Value ? (bool)reader["IsActive"] : false,
                            CreateId = reader["CreateId"] != DBNull.Value ? reader["CreateId"].ToString() : string.Empty,
                            CreateDate = reader["CreateDate"] != DBNull.Value ? (DateTime)reader["CreateDate"] : DateTime.Now,
                        };
                        result.Add(item);
                    }
                    _con.Close();
                }
            }

            return result;
        }

    }
}
