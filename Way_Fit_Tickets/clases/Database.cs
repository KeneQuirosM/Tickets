using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Way_Fit_Tickets
{
    class Database
    {
        public SqlConnection Connection = new SqlConnection();

        public SqlConnection Connect_DB()
        {
             Connection = new SqlConnection("Data Source=DESKTOP-4U3QFV7\\KENEQMMSSQLSVR;Initial Catalog=WayF_Tickets;User ID=sa;Password=Pass");
            try
            {
                Connection.Open();
                return Connection;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public bool Disconnect_DB()
        {
            Connection.Close();
            return true;
        }

    }

    
}
