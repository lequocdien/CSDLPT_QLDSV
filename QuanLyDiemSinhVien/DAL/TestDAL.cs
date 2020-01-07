using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TestDAL
    {
        public static void GetValue()
        {
            try
            {
                string strConnectionString = @"Server = DIEN-PC; Database = CSDLPT_QLDSV; User Id = sa; Password = 0000";
                SqlConnection objConnection = new SqlConnection(strConnectionString);
                objConnection.Open();
                string strCommandText = "EXEC sp_test";
                SqlCommand objCommand = new SqlCommand(strCommandText, objConnection);
                int nRes = objCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
