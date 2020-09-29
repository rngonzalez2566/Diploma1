using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class ModificarContrasena : Form
    {
        public ModificarContrasena()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BLL.Usuario usuario = new BLL.Usuario();
            string xMensaje = usuario.CambiarContrasena(txtUsuario.Text);
            MessageBox.Show(xMensaje);
        }
    }
}
