using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Backend;

namespace MainApp.ChildForms
{
    public partial class Notas : Form
    {
        TablaNotas notas = new TablaNotas();
        RegistroMS materia = new RegistroMS(); 

        public Notas()
        {
            InitializeComponent();
        }

        private void Notas_Load(object sender, EventArgs e)
        {
            dgvNotas.DataSource = notas.CargarTabla(materia.Nombre());
            dgvNotas.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvNotas.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvNotas.Columns[1].Width = 135;
            lblMateria.Text = materia.Nombre().ToUpper();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtDetalle.Text != "")
            {
                lblDetalle.Text = "DETALLE";
                lblDetalle.ForeColor = Color.White;
                notas.GuardarNota(txtDetalle.Text, dtpFecha.Text, materia.Nombre());
            }
            else
            {
                lblDetalle.Text = "[NO PUEDES AÑADIR UNA NOTA VACÍA. DESCRIBE LA NOTA/MEMO.]";
                lblDetalle.ForeColor = Color.Red;
            }
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvNotas.SelectedRows.Count != 0)
            {
                notas.EliminarNota(dgvNotas.SelectedRows[0].Index, materia.Nombre());
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
