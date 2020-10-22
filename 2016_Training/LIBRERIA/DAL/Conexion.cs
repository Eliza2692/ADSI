using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;


namespace DAL
{
    public class Conexion
    {
        private SqlConnection con;
        private SqlCommand cmd;
        private string cad;

        public Conexion()
        {
            try
            {
                cad = "Server=.;Database=LibreriaBD;Trusted_Connection=True;";
                con = new SqlConnection(cad);
                con.Open();
                con.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void ExecuteNonQuery(string sql)
        {
            try
            {
                using (con = new SqlConnection(cad))
                {
                    con.Open();
                    cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    con.Close();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public DataTable ExecuteQuery(string sql)
        {
            try
            {
                using (con = new SqlConnection(cad))
                {
                    con.Open();
                    cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = sql;
                    SqlDataAdapter da = new SqlDataAdapter();
                    DataTable dt = new DataTable();
                    da.SelectCommand = cmd;
                    da.Fill(dt);
                    da.Dispose();
                    cmd.Dispose();
                    con.Close();
                    return dt;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }


    }
}
