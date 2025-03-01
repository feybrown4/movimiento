using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;



namespace movimientoDL
{
    
    
    public static class AdminDL
    {
        public static SqlConnection GetConnection()
        {

            string  myConnectionString  = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\ITPA\Year_2\fall\Employment_Strategies\project\netprojects\movimiento\movimientoDL\AdminDB.mdf;Integrated Security=True");

            SqlConnection mySqlConnection = new SqlConnection(myConnectionString);
            return mySqlConnection;



        }

        
    }
}
