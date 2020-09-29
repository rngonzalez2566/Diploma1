using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BLL
{
   public class ConexionBLL
    {
        
        public SqlConnection instancia;
        public SqlConnection  conectar()
        {
            DAL.Conexion Conex = new DAL.Conexion();

            return instancia = Conex.conectar();
           
        }
    }
}
