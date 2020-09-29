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
    public partial class BajaUsuario : Form
    {
        public BajaUsuario()
        {
            InitializeComponent();
        }

        private void BajaUsuario_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUsuario.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BLL.Usuario usuario = new BLL.Usuario();
            string xMensaje = usuario.BajaUsuario(txtUsuario.Text);
            MessageBox.Show(xMensaje);
            cargar();
        }

        private void cargar()
        {
            BLL.Usuario Usuario = new BLL.Usuario();
            List<BE.Usuario> ListaUsuario = new List<BE.Usuario>();
            ListaUsuario = Usuario.Listar();

            dataGridView1.DataSource = null;
            dataGridView1.Columns.Clear();

            dataGridView1.ColumnCount = 2;
            dataGridView1.Columns[0].Name = "Usuario";
            dataGridView1.Columns[1].Name = "Estado";

            foreach (BE.Usuario lista in ListaUsuario)
            {
                dataGridView1.Rows.Add(lista.usuario, lista.estado);
            }
        }
    }
}
