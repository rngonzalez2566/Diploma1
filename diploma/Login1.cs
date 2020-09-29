using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace UI
{
    public partial class Login1 : Form
    {
        public SqlConnection instancia;
        public Login1()
        {
            InitializeComponent();
        }

        private void Login1_Load(object sender, EventArgs e)
        {
            BLL.ConexionBLL conex = new BLL.ConexionBLL();
            instancia = conex.conectar();

            if (instancia == null)

            {
                MessageBox.Show("PROBLEMAS CON LA BASE DE DATOS, CONTACTESE CON EL ADMINISTRADOR");
                Application.Exit();
            }
            BLL.DigitoVerificador dv = new BLL.DigitoVerificador();
            String xMensaje = dv.VerificarDV();
            if (xMensaje != "")
            {
                MessageBox.Show(xMensaje);
            }
        }

      

        private void da_Click(object sender, EventArgs e)
        {
            Bitacora bit = new Bitacora();
            bit.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AltaUsuario bit = new AltaUsuario();
            bit.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BajaUsuario bit = new BajaUsuario();
            bit.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ModificarContrasena bit = new ModificarContrasena();
            bit.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Principal bit = new Principal();
            bit.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
