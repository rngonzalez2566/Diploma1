using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
   public class BitacoraBE
    {
        private int _id_bitacora;
        public int id_Bitacora
        {
            get { return _id_bitacora; }
            set { _id_bitacora = value; }
        }

        private int _fk_usuario;
        public int fk_usuario
        {
            get { return _fk_usuario; }
            set { _fk_usuario = value; }
        }

        private string _descripcion;
        public string descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        private int _criticidad;
        public int criticidad
        {
            get { return _criticidad; }
            set { _criticidad = value; }
        }

        private string _fechamovimiento;
        public string fechammovimiento
        {
            get { return _fechamovimiento; }
            set { _fechamovimiento = value; }
        }

        private int _dvh;
        public int dvh
        {
            get { return _dvh; }
            set { _dvh = value; }
        }
    }
}
