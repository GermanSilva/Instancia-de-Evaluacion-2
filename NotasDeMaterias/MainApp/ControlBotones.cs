using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Backend;
using MainApp.ChildForms;

namespace MainApp
{
    public class ControlBotones
    {
        public ListaMaterias listMat = new ListaMaterias();
        int posicionY = 0;
        int listCount = 0;

        public ControlBotones()
        {

        }

        public Button CrearBoton(int ancho, String nombre, int a, int r, int g, int b)
        {
            Button temp = new Button();

            //Propiedades del botón
            temp.BackColor = Color.FromArgb(a, r, g, b);
            temp.FlatAppearance.BorderSize = 0;
            temp.FlatStyle = FlatStyle.Flat;
            temp.Font = new Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            temp.Location = new Point(0, posicionY);
            temp.Margin = new Padding(0, 0, 0, 20);
            temp.Name = "btnMat" + listCount + nombre;
            temp.Size = new Size(ancho, 40);
            temp.Anchor = ((AnchorStyles)(((AnchorStyles.Top | AnchorStyles.Left)| AnchorStyles.Right)));
            temp.Text = nombre.ToUpper();
            temp.UseVisualStyleBackColor = false;

            posicionY += 50;
            listCount++;

            return temp;
        }

        public void ReiniciarPosicion() 
        {
            posicionY = 0;
            listCount = 0;
        }


    }
}
