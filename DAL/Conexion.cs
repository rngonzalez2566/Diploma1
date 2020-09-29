using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
   public class Conexion
    {


        private static SqlConnection instancia = null;
        public static object _Lock = new object();
        private static SqlConnection getInstancia()
        {

            if (instancia == null)
            {
                instancia = new SqlConnection();
                instancia.ConnectionString = "Data Source=NTBK_013\\SQLEXPRESS;Initial Catalog=Diploma;Integrated Security=True";
                //instancia.ConnectionString = "Data Source=DESKTOP-AKO4OKS\\SQLEXPRESS;Initial Catalog=Diploma;Integrated Security=True";
                
            }

            return instancia;
        }

        public SqlConnection conectar()
        {
            instancia = getInstancia();

              lock(_Lock)
                {
                    
                    if (instancia.State == System.Data.ConnectionState.Closed)
                      {   
                        try
                         {
                           instancia.Open();
                         }
                        catch(Exception)
                         {
                           return instancia = null;
                         }

                      }
                }
            return instancia;
        }

        public void desconectar()
        {
            instancia = getInstancia();
            if (instancia.State == System.Data.ConnectionState.Open)
            {

                instancia.Close();
            }
        }
    }
}
