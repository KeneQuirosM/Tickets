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
             Connection = new SqlConnection("Data Source=DESKTOP-4U3QFV7\\KENEQMMSSQLSVR;Initial Catalog=WayF_Tickets;User ID=sa;Password=Morrish0803");
            //conexion = new SqlConnection("Data Source=DESKTOP-08DF72E;Initial Catalog=Prestamos;User ID=sa;Password=Morrish0803");
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
