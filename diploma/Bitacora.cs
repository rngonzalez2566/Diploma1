using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace UI
{
    public partial class Bitacora : Form
    {
        public Bitacora()
        {
            InitializeComponent();
        }

        private void Bitacora_Load(object sender, EventArgs e)
        {
            BLL.Bitacora bitacora = new BLL.Bitacora();

            DataTable dt = new DataTable();
            dt = bitacora.ListarUsuarios();
            cmbUsuario.DataSource = dt;
            cmbUsuario.DisplayMember = "USUARIO";
            cmbUsuario.ValueMember = "ID";
            cmbUsuario.SelectedItem = null;

            DataTable dt1 = new DataTable();
            dt1 = bitacora.ListarCriticidad();
            cmbCriticidad.DataSource = dt1;
            cmbCriticidad.DisplayMember = "CRITICIDAD";
            cmbCriticidad.ValueMember = "CRITICIDAD";
            cmbCriticidad.SelectedItem = null;

           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fltUsuario = " 1 = 1 ";
            string fltFechaD = " AND 1 = 1 ";
            string fltFechaH = " AND 1 = 1 ";
            string fltCriticidad = " AND 1 = 1 ";

            if(ftUsuario.Checked == true && cmbUsuario.SelectedValue == null )
            {
                MessageBox.Show("Debe seleccionar un usuario");
                return;
            }

            if (ftCriticidad.Checked == true && cmbCriticidad.SelectedValue == null)
            {
                MessageBox.Show("Debe seleccionar una criticidad");
                return;
            }

            if (ftfecha.Checked == true)
            {
                //dc.ColumnName.ToString().Substring(0, 3)
                
                 if (int.Parse(dpd.Value.ToString("yyyyMMdd")) > int.Parse(dph.Value.ToString("yyyyMMdd")))
                {
                    MessageBox.Show("La fecha desde no puede ser mayor a la fecha Hasta");
                    return;
                }
                
            }

            if (ftCriticidad.Checked == true)
            {
                fltCriticidad = " and b.criticidad = '" + cmbCriticidad.Text + "' ";
            }

            if (ftUsuario.Checked == true)
            {
                fltUsuario = "U.usuario = '"+ cmbUsuario.Text + "' "; 
            }

            if(ftfecha.Checked == true)
            {
                fltFechaD = "and SUBSTRING(b.Fecha_movimiento, 1, 8) >= '"+ dpd.Value.ToString("yyyyMMdd") + "'  ";
                fltFechaH = "and SUBSTRING(b.Fecha_movimiento, 1, 8) <= '" + dph.Value.ToString("yyyyMMdd") + "'  ";
            }

            BLL.Bitacora Bitacora = new BLL.Bitacora();
            List<BE.BitacoraBE> ListaBitacora = new List<BE.BitacoraBE>();
            ListaBitacora = Bitacora.Busqueda(fltUsuario,fltFechaD,fltFechaH,fltCriticidad);

            dataGridView1.DataSource = null;
            dataGridView1.Columns.Clear();

            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Name = "Fecha";
            dataGridView1.Columns[1].Name = "Usuario";
            dataGridView1.Columns[2].Name = "Descripcion";
            dataGridView1.Columns[3].Name = "Criticidad";

            
            foreach (BE.BitacoraBE lista in ListaBitacora)
            {
                DateTime xFecha = DateTime.ParseExact(lista.fechammovimiento, "yyyyMMddHHmmss", null);
                //dataGridView1.Rows.Add(xFecha.ToString("dd/mm/yyyy"), lista.fk_usuario, lista.descripcion, lista.criticidad);
                dataGridView1.Rows.Add(xFecha, lista.fk_usuario, lista.descripcion, lista.criticidad);
            }
            

        }
    }
}
