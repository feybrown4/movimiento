using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using movimientoDL;

namespace MovimientoBL
{
    public static class AdminDB
    {


        public static void InsertAdmin(Admin admin)
        {
            SqlConnection myConn = AdminDL.GetConnection();
            string sql = "INSERT INTO [dbo].[Admin] ([email], [firstname], [lastname], [password]) VALUES (@email, @firstname, @lastname, @password)";
            try
            {
                myConn.Open();
                SqlCommand cmd = new SqlCommand(sql, myConn);

                //populate the parameters
                cmd.Parameters.AddWithValue("@email", admin.Email);
                cmd.Parameters.AddWithValue("@firstname", admin.Firstname);
                cmd.Parameters.AddWithValue("@lastname", admin.Lastname);
                cmd.Parameters.AddWithValue("@password", admin.Password);

                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw new Exception("Error inserting product: " + ex.Message);
            }
            finally
            {
                myConn.Close();
            }


        
        }





    }
}
