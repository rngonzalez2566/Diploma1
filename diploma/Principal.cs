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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void altaUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaUsuario bit = new AltaUsuario();
            bit.Show();
        }

        private void bajaUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BajaUsuario bit = new BajaUsuario();
            bit.Show();
        }

        private void cambioDePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModificarContrasena bit = new ModificarContrasena();
            bit.Show();
        }

        private void bitacoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitacora bit = new Bitacora();
            bit.Show();
        }
    }
}
