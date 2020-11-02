using Backend;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainApp.ChildForms
{
    public partial class Materias : Form
    {
        ControlBotones Botones = new ControlBotones();
        private string materiaSeleccionada = "";
        private bool doubleClickReady;

        public Materias()
        {
            InitializeComponent();
        }

        private void Materias_Load(object sender, EventArgs e)
        {
            CargarBotones();
            ReiniciarControles();
        }

        //Selector de color
        private void btnColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                btnColor.BackColor = colorDialog1.Color;
                btnColor.Text = "";
            }
        }

        //Metodos de Añadir, Editar, y Eliminar materias
        private void btnAñadir_Click(object sender, EventArgs e)
        {

            if (txtNombre.Text.ToLower() != "materias" && (txtNombre.Text != "" && Botones.listMat.NoCoincide(txtNombre.Text.ToLower()) == true && btnColor.Text != "SIN SELECCIONAR"))
            {
                Button Temp = Botones.CrearBoton(
                    pnlMaterias.Width,
                    txtNombre.Text,
                    btnColor.BackColor.A,
                    btnColor.BackColor.R,
                    btnColor.BackColor.G,
                    btnColor.BackColor.B);

                Botones.listMat.Guardar(
                    txtNombre.Text.ToLower(),
                    btnColor.BackColor.A,
                    btnColor.BackColor.R,
                    btnColor.BackColor.G,
                    btnColor.BackColor.B);

                MostrarBoton(Temp);
                ReiniciarControles();
            }
            else
            {
                if (txtNombre.Text == "" || btnColor.Text == "SIN SELECCIONAR")
                {
                    lblInfo.Text = "[DEBES INGRESAR UN NOMBRE Y SELECCIONAR UN COLOR PARA LA MATERIA]";
                    lblInfo.ForeColor = Color.Red;
                }
                else
                {
                    if (txtNombre.Text.ToLower()=="materias")
                    {
                        lblInfo.Text = "[NO PUEDES UTILIZAR ESE NOMBRE. INGRESA OTRO]";
                        lblInfo.ForeColor = Color.Red;
                    }
                    else
                    {
                        lblInfo.Text = "[YA EXISTE UNA MATERIA CON ESE NOMBRE. INGRESA OTRO]";
                        lblInfo.ForeColor = Color.Red;
                    }
                }
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "")
            {
                bool cambioExitoso = Botones.listMat.Editar(
                    materiaSeleccionada,
                    txtNombre.Text.ToLower(),
                    Convert.ToInt32(btnColor.BackColor.A),
                    Convert.ToInt32(btnColor.BackColor.R),
                    Convert.ToInt32(btnColor.BackColor.G),
                    Convert.ToInt32(btnColor.BackColor.B));

                if (cambioExitoso == true)
                {
                    pnlMaterias.Controls.Clear();
                    CargarBotones();
                    ReiniciarControles();
                }
                else
                {
                    lblInfo.Text = "[NO PUEDEN EXISTIR DOS MATERIAS CON EL MISMO NOMBRE. INTENTA NUEVAMENTE]";
                    lblInfo.ForeColor = Color.Red;
                }

            }
            else
            {
                lblInfo.Text = "[DEBES INDICAR EL NOMBRE DE LA MATERIA A EDITAR]";
                lblInfo.ForeColor = Color.Red;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Botones.listMat.Eliminar(txtNombre.Text.ToLower()) == true)
            {
                CargarBotones();
                ReiniciarControles();
            }
            else
            {
                lblInfo.Text = "[NO SE ENCUENTRA LA MATERIA QUE QUIERES ELIMINAR]";
                lblInfo.ForeColor = Color.Red;
            }
        }

        //Metodos complementarios
        private void ReiniciarControles()
        {
            lblInfo.Text = "PARA AGREGAR UNA MATERIA, INGRESA NOMBRE Y SELECCIONA UN COLOR";
            lblInfo.ForeColor = Color.Silver;

            txtNombre.Text = "";

            btnColor.BackColor = Color.White;
            btnColor.Text = "SIN SELECCIONAR";

            btnAñadir.Visible = true;
        }

        public void SeleccionarMateria(object sender, EventArgs e) 
        {
            if (materiaSeleccionada == ((Button)sender).Text.ToLower() && doubleClickReady == true)
            {
                RegistroMS registro = new RegistroMS();
                registro.ActivarRegistro(materiaSeleccionada);
                this.Close();
                
            }
            else
            {
                doubleClickReady = true;
                materiaSeleccionada = ((Button)sender).Text.ToLower();
                txtNombre.Text = materiaSeleccionada;
                btnColor.BackColor = ((Button)sender).BackColor;
                btnColor.Text = "";
                lblInfo.Text = "MODIFICA LO QUE QUIERAS CAMBIAR, O SELECCIONA ELIMINAR PARA QUITARLO DE LA LISTA.";
                lblInfo.ForeColor = Color.Silver;
                btnAñadir.Visible = false;
            }
        }

        public void CargarBotones()
        {
            pnlMaterias.Controls.Clear();
            Botones.ReiniciarPosicion();
            for (int i = 0; i < Botones.listMat.Lista.Rows.Count; i++)
            {
                Button Temp = Botones.CrearBoton(
                    pnlMaterias.Width,
                    Botones.listMat.Lista.Rows[i]["Nombre"].ToString(),
                    Convert.ToInt32(Botones.listMat.Lista.Rows[i]["A"]),
                    Convert.ToInt32(Botones.listMat.Lista.Rows[i]["R"]),
                    Convert.ToInt32(Botones.listMat.Lista.Rows[i]["G"]),
                    Convert.ToInt32(Botones.listMat.Lista.Rows[i]["B"]));
                MostrarBoton(Temp);
            }
        }

        public void MostrarBoton(Button boton) 
        {
            boton.Click += new EventHandler(SeleccionarMateria);
            pnlMaterias.Controls.Add(boton);
        }

        private void RC2(object sender, EventArgs e)
        {
            ReiniciarControles();
        }

        //Timer - margen de tiempo para hacer doble click en materia
        private void timer1_Tick(object sender, EventArgs e)
        {
            doubleClickReady = false;
        }
    }
}
