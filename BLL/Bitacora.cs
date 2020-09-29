using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BLL
{
    public class Bitacora
    {

        public string registrarBitacora(BE.Usuario usuario, string descripcion, int criticidad, DateTime fechamov)
        {
            BE.BitacoraBE bitacora = new BE.BitacoraBE();
            BLL.DigitoVerificador Dv = new BLL.DigitoVerificador();
            BLL.Encriptar Encripta = new BLL.Encriptar();
            bitacora.fk_usuario = usuario.id_usuario;
            bitacora.descripcion = Encripta.encriptar(true,descripcion);
            bitacora.criticidad = criticidad;
            bitacora.fechammovimiento = fechamov.ToString("yyyyMMddHHmmss");
            bitacora.dvh = Dv.CalcularDV("bitacora", bitacora);
            string xConsulta = "insert into Bitacora(fk_usuario,Descripcion,Criticidad,Fecha_movimiento,DVH) values("+ usuario.id_usuario+ ", '"+ bitacora.descripcion + "',"+ bitacora.criticidad + " , '"+ bitacora.fechammovimiento.ToString() + "', "+bitacora.dvh+")";
            DAL.Acceso Acceso = new DAL.Acceso();
            
            return   Acceso.ExecutenonQuery(xConsulta);
        }

        public DataTable ListarUsuarios()
        {
            DataTable dt = new DataTable();
            DAL.Acceso acceso = new DAL.Acceso();
            dt = acceso.ExecuteReader("SELECT U.id_usuario ID, U.usuario USUARIO FROM Usuario U " +
                                     "INNER JOIN Bitacora B ON B.FK_USUARIO = U.id_usuario " +
                                     "WHERE id_usuario <> 1" +
                                     "GROUP BY U.usuario, U.id_usuario");
            return dt;
        }

        public DataTable ListarCriticidad()
        {
            DataTable dt = new DataTable();
            DAL.Acceso acceso = new DAL.Acceso();
            dt = acceso.ExecuteReader("SELECT  B.Criticidad CRITICIDAD FROM Bitacora B GROUP BY B.Criticidad");
            return dt;
        }

        public List<BE.BitacoraBE> Busqueda (string xUsuario, string xFechaD, string xFechaH, string xCriticidad)
        {
            List<BE.BitacoraBE> ListaBitacora = new List<BE.BitacoraBE>();
            DAL.Acceso Acceso = new DAL.Acceso();
            DataTable dt = new DataTable();
            BLL.Encriptar Encriptar = new BLL.Encriptar();
            string xConsulta = "SELECT B.Fecha_movimiento fecha, b.fk_usuario usuario, "+
                               "b.Descripcion, b.Criticidad "+
                               "FROM Bitacora B "+
                               "WHERE "+xUsuario+xFechaD+xFechaH+xCriticidad+" "+
                               "order by b.Fecha_movimiento";
            dt = Acceso.ExecuteReader(xConsulta);
            foreach (DataRow fila in dt.Rows)
            {
                BE.BitacoraBE Bit = new BE.BitacoraBE();
                Bit.fechammovimiento = fila[0].ToString();
                Bit.fk_usuario = int.Parse(fila[1].ToString());
                Bit.descripcion = Encriptar.descencriptar(fila[2].ToString());
                Bit.criticidad = int.Parse(fila[3].ToString());
                ListaBitacora.Add(Bit);
            }
            
            return ListaBitacora;
         }
    }
}
