using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
   public class Usuario
    {
        private int _id_usurio;
        public int id_usuario
        {
            get { return _id_usurio; }
            set { _id_usurio = value; }
        }

        private string _usuario;
        public string usuario
        {
            get { return _usuario; }
            set { _usuario = value; }
        }

        private string _contrasena;
        public string contrasena
        {
            get { return _contrasena; }
            set { _contrasena = value; }
        }

        private int _contador;
        public int contador
        {
            get { return _contador; }
            set { _contador = value; }
        }

        private string _estado;
        public string estado
        {
            get { return _estado; }
            set { _estado = value; }
        }

        private string _email;
        public string email
        {
            get { return _email; }
            set { _email = value; }
        }

        private int _DVH;
        public int DVH
        {
            get { return _DVH; }
            set { _DVH = value; }
        }
    }
}
