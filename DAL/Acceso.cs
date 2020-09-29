using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Acceso
    {
        private string _error;

        public string Error
        {
            get { return _error; }
            set { _error = value; }
        }
        public string ExecutenonQuery(string query)
        {
            DAL.Conexion con = new Conexion();
            SqlCommand comando = new SqlCommand(query, con.conectar());
            int r = 0;
            try
            {
               
                r = comando.ExecuteNonQuery();
                return r.ToString();
            }
            catch (SqlException e)
            {
                _error = e.ToString();
                return _error;
                
            }
            finally
            {
                con.desconectar();
            }
           
        }

        public DataTable ExecuteReader(string xConsulta)
        {
            SqlDataReader dr;
            DataTable dt = new DataTable();
            DAL.Conexion con = new Conexion();
            SqlCommand comando = new SqlCommand(xConsulta, con.conectar());
            dr = comando.ExecuteReader();
            dt.Load(dr);
            con.desconectar();
            return dt;
        }
    }
}
