using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.IO;
namespace BLL
{
   public class Usuario
    {
        public string AltaUsuario(string xUsuario, string xEmail)
        {
            DAL.Acceso Acceso = new DAL.Acceso();
            BE.Usuario Usuario = new BE.Usuario();
            BLL.Encriptar Encripta = new BLL.Encriptar();
            BLL.DigitoVerificador Dv = new BLL.DigitoVerificador();

            if (xUsuario == "")
            {
                return "Usuario en blanco";
            }

            if (xEmail == "")
            {
                return "Email en blanco";
            }

            string xConsulta = "SELECT USUARIO FROM USUARIO WHERE USUARIO = '" + Encripta.encriptar(true,xUsuario) + "' ";
            DataTable dt = Acceso.ExecuteReader(xConsulta);

            if(dt.Rows.Count != 0)
            {
                return "El usuario ya existe";
                  
            }
            else
            {
              

                Usuario.usuario = Encripta.encriptar(true, xUsuario);
                Usuario.email = xEmail;
                Usuario.contador = 0;
                Usuario.estado = "ACTIVO";
                string xPassword = GeneraClave();
                Usuario.contrasena = Encripta.encriptar(false, xPassword);
                Usuario.DVH = Dv.CalcularDV("usuario", Usuario);

                string xConsulta1 = "INSERT INTO Usuario (usuario,contrasena,contador,estado,email,DVH) " +
                                     "VALUES ('"+ Usuario.usuario + "', '" + Usuario.contrasena + "', " + Usuario.contador + ", '" + Usuario.estado + "" +
                                     "', '" + Usuario.email + "' , " + Usuario.DVH + ")";

                EnviaMailClave(xUsuario, xPassword);

                BLL.Bitacora bitacora = new BLL.Bitacora();
                string xbit = bitacora.registrarBitacora(Usuario, "Se ha dado de alta un nuevo usuario: "+ xUsuario, 2, DateTime.Now).ToString();
                return Acceso.ExecutenonQuery(xConsulta1);
                
            }
        }


        public string CambiarContrasena(string xUsuario)
        {
            if (xUsuario == "")
            {
                return "Usuario en blanco";
            }

            DAL.Acceso Acceso = new DAL.Acceso();
            BE.Usuario Usuario = new BE.Usuario();
            BLL.Encriptar Encripta = new BLL.Encriptar();
            BLL.DigitoVerificador Dv = new BLL.DigitoVerificador();

            string xConsulta = "SELECT * FROM USUARIO WHERE USUARIO = '" + Encripta.encriptar(true, xUsuario) + "' AND estado = 'ACTIVO' ";
            DataTable dt = Acceso.ExecuteReader(xConsulta);


            if (dt.Rows.Count == 0)
            {
                return "El usuario no existe o esta dado de baja";

            }
            else
            {
                Usuario.id_usuario = int.Parse(dt.Rows[0]["id_usuario"].ToString());
                Usuario.usuario = dt.Rows[0]["usuario"].ToString();
                Usuario.contador = 0;
                Usuario.estado = dt.Rows[0]["estado"].ToString();
                Usuario.email = dt.Rows[0]["email"].ToString();
                string xPassword = GeneraClave();
                Usuario.contrasena = Encripta.encriptar(false, xPassword);
                Usuario.DVH = Dv.CalcularDV("usuario", Usuario);

                EnviaMailClave(xUsuario, xPassword);

                string xConsulta1 = "update usuario set contrasena = '"+Usuario.contrasena+"' , DVH = "+ Usuario.DVH + " where id_usuario = "+Usuario.id_usuario+" ";

                BLL.Bitacora bitacora = new BLL.Bitacora();
                string xbit = bitacora.registrarBitacora(Usuario, "Se ha Cambiado la contraseña del usuario: " + Encripta.descencriptar(Usuario.usuario), 2, DateTime.Now).ToString();
                return Acceso.ExecutenonQuery(xConsulta1);
            }
        }

        public string BajaUsuario(string xUsuario)
        {
            if (xUsuario == "")
            {
                return "Usuario en blanco";
            }

            DAL.Acceso Acceso = new DAL.Acceso();
            BLL.Encriptar Encripta = new BLL.Encriptar();
            BE.Usuario Usuario = new BE.Usuario();
            BLL.DigitoVerificador Dv = new BLL.DigitoVerificador();

            string xConsulta = "SELECT * FROM USUARIO WHERE USUARIO = '" + Encripta.encriptar(true, xUsuario) + "' AND estado = 'ACTIVO' ";
            DataTable dt = Acceso.ExecuteReader(xConsulta);


            if (dt.Rows.Count == 0)
            {
                return "El usuario no existe o esta dado de baja";

            }

            Usuario.id_usuario = int.Parse(dt.Rows[0]["id_usuario"].ToString());
            Usuario.usuario = dt.Rows[0]["usuario"].ToString();
            Usuario.contador = 0;
            Usuario.estado = "BAJA";
            Usuario.email = dt.Rows[0]["email"].ToString();
            Usuario.contrasena = dt.Rows[0]["contrasena"].ToString();
            Usuario.DVH = Dv.CalcularDV("usuario", Usuario);


            string xConsulta1 = "update usuario set estado = '" + Usuario.estado + "' , DVH = " + Usuario.DVH + " where id_usuario = " + Usuario.id_usuario + " ";

            BLL.Bitacora bitacora = new BLL.Bitacora();
            string xbit = bitacora.registrarBitacora(Usuario, "Se ha dado de baja el usuario: " + Encripta.descencriptar(Usuario.usuario), 2, DateTime.Now).ToString();
            return Acceso.ExecutenonQuery(xConsulta1);

           

        }
        private string GeneraClave()
        {
            Random rdn = new Random();
            string caracteres = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            int longitud = caracteres.Length;
            char letra;
            int longitudContrasenia = 8;
            string Password = "";
            for (int i = 0; i < longitudContrasenia; i++)
            {
                letra = caracteres[rdn.Next(longitud)];
                Password += letra.ToString();
            }
            return Password;
        }
        private void EnviaMailClave(string xUsuario, string xPassword)
        {
            
            string texto = "Contraseña: " + xPassword;

            StreamWriter fichero; //Clase que representa un fichero
            fichero = File.CreateText("C:\\" +xUsuario + ".txt"); //Creamos un fichero
            fichero.WriteLine(texto); // Lo mismo que cuando escribimos por consola
            fichero.Close();


        }

        public List<BE.Usuario> Listar()
        {
            List<BE.Usuario> ListaUsuario = new List<BE.Usuario>();
            DAL.Acceso Acceso = new DAL.Acceso();
            DataTable dt = new DataTable();
            BLL.Encriptar Encriptar = new BLL.Encriptar();
            string xConsulta = "Select usuario, estado from usuario";
            dt = Acceso.ExecuteReader(xConsulta);
            foreach (DataRow fila in dt.Rows)
            {
                BE.Usuario Usu = new BE.Usuario();
                Usu.usuario = Encriptar.descencriptar(fila[0].ToString());
                Usu.estado = fila[1].ToString();
                ListaUsuario.Add(Usu);
            }

            return ListaUsuario;
        }


    }
}
