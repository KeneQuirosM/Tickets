using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Way_Fit_Tickets.clases
{
    //Stored procedure for system management
    class BD_Movements
    {
        Database Connect = new Database();

        // stored procedure to save users
        public bool Save_Users(string name, string lastname,string telefono)
        {
            bool insertok = false;
            try
            {
                SqlConnection conn = new SqlConnection();
                conn = Connect.Connect_DB();
                SqlCommand InsertStockInformation = new SqlCommand("Insert_Users", conn);
                InsertStockInformation.CommandType = CommandType.StoredProcedure;
                InsertStockInformation.Parameters.Add("@Name", SqlDbType.NVarChar, 50).Value = name;
                InsertStockInformation.Parameters.Add("@LastN", SqlDbType.NVarChar, 50).Value = lastname;
                InsertStockInformation.Parameters.Add("@Tel", SqlDbType.NVarChar, 50).Value = telefono;
                InsertStockInformation.ExecuteNonQuery();
                insertok = true;
                conn.Close();
            }
            catch (Exception)
            {
                insertok = false;
            }

            return insertok;
        }

        // stored procedure for updating users
        public bool Update_Users(int id,string name, string lastname,string telefono)
        {
            bool updateok = false;
            try
            {
                SqlConnection conn = new SqlConnection();
                conn = Connect.Connect_DB();
                SqlCommand InsertStockInformation = new SqlCommand("Update_Users", conn);
                InsertStockInformation.CommandType = CommandType.StoredProcedure;
                InsertStockInformation.Parameters.Add("@Id", SqlDbType.Int).Value = id;
                InsertStockInformation.Parameters.Add("@Name", SqlDbType.NVarChar, 50).Value = name;
                InsertStockInformation.Parameters.Add("@Last", SqlDbType.NVarChar, 50).Value = lastname;
                InsertStockInformation.Parameters.Add("@Cel", SqlDbType.NVarChar, 50).Value = telefono;
                InsertStockInformation.ExecuteNonQuery();
                updateok = true;
                conn.Close();
            }
            catch (Exception)
            {
                updateok = false;
            }

            return updateok;
        }

        // stored procedure for delete users
        public bool Delete_Users(int id)
        {
            bool deleteok = false;
            try
            {
                SqlConnection conn = new SqlConnection();
                conn = Connect.Connect_DB();
                SqlCommand InsertStockInformation = new SqlCommand("Delete_Users", conn);
                InsertStockInformation.CommandType = CommandType.StoredProcedure;
                InsertStockInformation.Parameters.Add("@Id", SqlDbType.Int).Value = id;
                InsertStockInformation.ExecuteNonQuery();
                deleteok = true;
                conn.Close();
            }
            catch (Exception)
            {
                deleteok = false;
            }

            return deleteok;
        }


        // stored procedure to save services
        public bool Save_Services(string name, string price)
        {
            bool insertok = false;
            try
            {
                SqlConnection conn = new SqlConnection();
                conn = Connect.Connect_DB();
                SqlCommand InsertStockInformation = new SqlCommand("Insert_services", conn);
                InsertStockInformation.CommandType = CommandType.StoredProcedure;
                InsertStockInformation.Parameters.Add("@Name", SqlDbType.NVarChar, 50).Value = name;
                InsertStockInformation.Parameters.Add("@Price", SqlDbType.NVarChar, 50).Value = price;
                InsertStockInformation.ExecuteNonQuery();
                insertok = true;
                conn.Close();
            }
            catch (Exception)
            {
                insertok = false;
            }

            return insertok;
        }

        // stored procedure for updating services
        public bool Update_services(int id, string name, string price)
        {
            bool updateok = false;
            try
            {
                SqlConnection conn = new SqlConnection();
                conn = Connect.Connect_DB();
                SqlCommand InsertStockInformation = new SqlCommand("Update_services", conn);
                InsertStockInformation.CommandType = CommandType.StoredProcedure;
                InsertStockInformation.Parameters.Add("@Id", SqlDbType.Int).Value = id;
                InsertStockInformation.Parameters.Add("@Name", SqlDbType.NVarChar, 50).Value = name;
                InsertStockInformation.Parameters.Add("@Price", SqlDbType.Money).Value = price;
                InsertStockInformation.ExecuteNonQuery();
                updateok = true;
                conn.Close();
            }
            catch (Exception)
            {
                updateok = false;
            }

            return updateok;
        }

        // stored procedure for delete services
        public bool Delete_Services(int id)
        {
            bool deleteok = false;
            try
            {
                SqlConnection conn = new SqlConnection();
                conn = Connect.Connect_DB();
                SqlCommand InsertStockInformation = new SqlCommand("Delete_services", conn);
                InsertStockInformation.CommandType = CommandType.StoredProcedure;
                InsertStockInformation.Parameters.Add("@Id", SqlDbType.Int).Value = id;
                InsertStockInformation.ExecuteNonQuery();
                deleteok = true;
                conn.Close();
            }
            catch (Exception)
            {
                deleteok = false;
            }

            return deleteok;
        }


        public DataSet Search_Users(string tel)
        {
            try
            {
                SqlConnection conn = new SqlConnection();
                conn = Connect.Connect_DB();
                SqlCommand InsertStockInformation = new SqlCommand("Search_Users", conn);
                InsertStockInformation.CommandType = CommandType.StoredProcedure;
                InsertStockInformation.Parameters.Add("@Tel", SqlDbType.NVarChar, 50).Value = tel;
                InsertStockInformation.ExecuteNonQuery();
                DataSet ds = new DataSet();
                SqlDataAdapter adaptador2 = new SqlDataAdapter(InsertStockInformation);
                adaptador2.Fill(ds);
                conn.Close();
                
                return (ds);
                
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        // stored procedure for delete services
        public bool Insert_Rercord(string user,string services)
        {
            bool deleteok = false;
            try
            {
                SqlConnection conn = new SqlConnection();
                conn = Connect.Connect_DB();
                SqlCommand InsertStockInformation = new SqlCommand("Insert_Record", conn);
                InsertStockInformation.CommandType = CommandType.StoredProcedure;
                InsertStockInformation.Parameters.Add("@Id_user", SqlDbType.Int).Value = Convert.ToInt32(user);
                InsertStockInformation.Parameters.Add("@Id_services", SqlDbType.Int).Value = Convert.ToInt32(services);
                InsertStockInformation.ExecuteNonQuery();
                deleteok = true;
                conn.Close();
            }
            catch (Exception)
            {
                deleteok = false;
            }

            return deleteok;
        }



        public DataTable ViewClientes()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlConnection conn = new SqlConnection();
                SqlDataAdapter da = new SqlDataAdapter();
                conn = Connect.Connect_DB();
                SqlCommand cmd = new SqlCommand();
                cmd = new SqlCommand("ViewClients", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                da.SelectCommand = cmd;
                da.Fill(dt);
                conn.Close();
            }
            catch (Exception)
            {
                throw;
            }
            return dt;
        }

        public DataTable ViewServices()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlConnection conn = new SqlConnection();
                SqlDataAdapter da = new SqlDataAdapter();
                conn = Connect.Connect_DB();
                SqlCommand cmd = new SqlCommand();
                cmd = new SqlCommand("ViewServices", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                da.SelectCommand = cmd;
                da.Fill(dt);
                conn.Close();
            }
            catch (Exception)
            {
                throw;
            }
            return dt;
        }


        public DataSet Search_Price(string id)
        {
            try
            {
                SqlConnection conn = new SqlConnection();
                conn = Connect.Connect_DB();
                SqlCommand InsertStockInformation = new SqlCommand("Prices", conn);
                InsertStockInformation.CommandType = CommandType.StoredProcedure;
                InsertStockInformation.Parameters.Add("@Id", SqlDbType.Int).Value = id;
                InsertStockInformation.ExecuteNonQuery();
                DataSet ds = new DataSet();
                SqlDataAdapter adaptador2 = new SqlDataAdapter(InsertStockInformation);
                adaptador2.Fill(ds);
                conn.Close();

                return (ds);

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
