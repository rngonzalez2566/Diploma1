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

namespace diploma
{
    public partial class Login : Form
    {
       
        public SqlConnection instancia;
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            BLL.ConexionBLL conex = new BLL.ConexionBLL();
            instancia = conex.conectar();

            if(instancia == null)

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

        private void button1_Click(object sender, EventArgs e)
        {
            BLL.Encriptar enc = new BLL.Encriptar();
            textBox1.Text = enc.encriptar(true,textBox2.Text);
            textBox3.Text = enc.descencriptar(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BLL.Encriptar enc = new BLL.Encriptar();
            textBox1.Text = enc.encriptar(false, textBox2.Text);
          

        }

        private void button3_Click(object sender, EventArgs e)
        {
            BLL.Bitacora bitacora = new BLL.Bitacora();
            BE.Usuario usuario = new BE.Usuario();
            usuario.id_usuario = 1;
            usuario.usuario = "pepe";
            
           MessageBox.Show(bitacora.registrarBitacora(usuario, "dasdas",2,dt.Value).ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }
    }
}
