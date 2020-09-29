using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Data.SqlClient;
using System.Data;
using System.Globalization;
namespace BLL
{
   public class DigitoVerificador
    {

        public string VerificarDV()
        {
            BE.Usuario usuario = new BE.Usuario();
            usuario.id_usuario = 1;
            usuario.usuario = "Sistema";

            string xMensaje = "";
            string xConsulta = "SELECT D.nombre_tabla TABLA, D.valorDVV DV FROM DigitoVerificador D";
            DAL.Acceso acceso = new DAL.Acceso();
            DataTable tb = acceso.ExecuteReader(xConsulta);
            foreach (DataRow fila in tb.Rows)
            {                
                int xDV = int.Parse(fila[1].ToString());
                string xTabla = fila[0].ToString();

                string xConsulta1 = "SELECT ISNULL(SUM(DVH),0) DVH FROM "+xTabla+" ";
                DataTable tb1 = acceso.ExecuteReader(xConsulta1);
                int xValor = int.Parse(tb1.Rows[0]["DVH"].ToString());

                if(xValor != xDV)
                {
                    xMensaje = "Error en la integridad de la base de datos";
                    BLL.Bitacora bitacora = new BLL.Bitacora();
                    string xM = bitacora.registrarBitacora(usuario,"Error en la validacion de la suma de digitos horizontales con el Digito Vertical de la tabla: " + xTabla, 1, DateTime.Now);
                }

                string xConsulta2 = "SELECT * FROM " + xTabla + " ";
                DataTable table = new DataTable();
                table = acceso.ExecuteReader(xConsulta2);
                
                foreach (DataRow fila1 in table.Rows)
                {
                    int xDVH = 0;
                    int dvhFila = 0;

                    foreach (DataColumn dc in table.Columns)
                    {
                        if(dc.ColumnName.ToString().Substring(0, 3).ToUpper() != "ID_")
                        {
                            if (dc.ColumnName.ToString().ToUpper() != "DVH")
                            {
                                string field1 = fila1[dc].ToString();
                                //DateTime s1 = DateTime.ParseExact(field1, "yyyy-MM-dd HH:mm tt", CultureInfo.InvariantCulture);
                                for (int i = 0; i < fila1[dc].ToString().Length; i++)
                                {
                                    byte[] bytes = Encoding.ASCII.GetBytes(fila1[dc].ToString().Substring(i, 1));
                                    int result = bytes[0];
                                    dvhFila = dvhFila + (result * (i + 1));

                                }
                            }
                            else
                            {
                                xDVH = int.Parse(fila1[dc].ToString());
                            }
                        }
                    }
                    if (xDVH != dvhFila)
                    {
                        xMensaje = "Error en la integridad de la base de datos";
                        BLL.Bitacora bitacora = new BLL.Bitacora();
                        string xM = bitacora.registrarBitacora(usuario, "Error en la validacion de la suma de digitos horizontales con el guardado en la tabla: " + xTabla  , 1, DateTime.Now);
                    }
                       
                }
           

            }
            return xMensaje;
        }

        public int CalcularDV(string xTabla,object xObjeto)
        {
            int DVH = 0;
            int xID = 0;
            string xNombreID = "";
            Type t = xObjeto.GetType();
            PropertyInfo[] props = t.GetProperties();
            foreach (var prop in props)
            {

                if (prop.Name.Substring(0, 3).ToUpper() != "ID_")
                {
                    if (prop.Name.ToUpper() != "DVH")
                    {
                        string xAtributo = prop.GetValue(xObjeto).ToString();
                        for (int i = 0; i < xAtributo.Length; i++)
                        {
                            byte[] bytes = Encoding.ASCII.GetBytes(xAtributo.Substring(i, 1));
                            int result = bytes[0];
                            DVH = DVH + (result * (i + 1));

                        }
                    }
                }
                else
                {
                     xNombreID = prop.Name.ToUpper();
                     xID = int.Parse(prop.GetValue(xObjeto).ToString());
                }
        }

            string xConsulta = "SELECT ISNULL(SUM(DVH),0) DVH FROM " + xTabla + " WHERE "+ xNombreID + " <> " + xID + " ";
            DAL.Acceso acceso = new DAL.Acceso();
            DataTable dt = acceso.ExecuteReader(xConsulta);
            int dv = int.Parse(dt.Rows[0]["DVH"].ToString()) + DVH;
            string xDVV = "UPDATE DigitoVerificador set valorDVV = " + dv + " where nombre_tabla = '" + xTabla + "' ";
            string msg = acceso.ExecutenonQuery(xDVV);
            return DVH;
        }
    }
}
