namespace MainApp.ChildForms
{
    partial class Materias
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlMenor = new System.Windows.Forms.Panel();
            this.pnlControles = new System.Windows.Forms.Panel();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnAñadir = new FontAwesome.Sharp.IconButton();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnColor = new FontAwesome.Sharp.IconButton();
            this.btnGuardar = new FontAwesome.Sharp.IconButton();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnEliminar = new FontAwesome.Sharp.IconButton();
            this.pnlMaterias = new System.Windows.Forms.Panel();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.pnlMayor = new System.Windows.Forms.Panel();
            this.lblAyudaMaterias = new System.Windows.Forms.Label();
            this.lblMaterias = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlMenor.SuspendLayout();
            this.pnlControles.SuspendLayout();
            this.pnlMayor.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenor
            // 
            this.pnlMenor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.pnlMenor.Controls.Add(this.pnlControles);
            this.pnlMenor.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlMenor.Location = new System.Drawing.Point(0, 311);
            this.pnlMenor.Margin = new System.Windows.Forms.Padding(0);
            this.pnlMenor.MinimumSize = new System.Drawing.Size(0, 139);
            this.pnlMenor.Name = "pnlMenor";
            this.pnlMenor.Size = new System.Drawing.Size(800, 139);
            this.pnlMenor.TabIndex = 4;
            this.pnlMenor.Click += new System.EventHandler(this.RC2);
            // 
            // pnlControles
            // 
            this.pnlControles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlControles.Controls.Add(this.lblColor);
            this.pnlControles.Controls.Add(this.lblNombre);
            this.pnlControles.Controls.Add(this.btnAñadir);
            this.pnlControles.Controls.Add(this.lblInfo);
            this.pnlControles.Controls.Add(this.btnColor);
            this.pnlControles.Controls.Add(this.btnGuardar);
            this.pnlControles.Controls.Add(this.txtNombre);
            this.pnlControles.Controls.Add(this.btnEliminar);
            this.pnlControles.Location = new System.Drawing.Point(25, 25);
            this.pnlControles.Margin = new System.Windows.Forms.Padding(0);
            this.pnlControles.Name = "pnlControles";
            this.pnlControles.Size = new System.Drawing.Size(750, 89);
            this.pnlControles.TabIndex = 6;
            // 
            // lblColor
            // 
            this.lblColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblColor.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor.ForeColor = System.Drawing.Color.White;
            this.lblColor.Location = new System.Drawing.Point(422, 31);
            this.lblColor.Margin = new System.Windows.Forms.Padding(0);
            this.lblColor.Name = "lblColor";
            this.lblColor.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblColor.Size = new System.Drawing.Size(156, 29);
            this.lblColor.TabIndex = 0;
            this.lblColor.Text = "COLOR";
            this.lblColor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblNombre.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(0, 31);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblNombre.Size = new System.Drawing.Size(417, 29);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "NOMBRE DE MATERIA";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnAñadir
            // 
            this.btnAñadir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAñadir.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAñadir.FlatAppearance.BorderSize = 0;
            this.btnAñadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAñadir.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnAñadir.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAñadir.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAñadir.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAñadir.IconColor = System.Drawing.Color.White;
            this.btnAñadir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAñadir.IconSize = 22;
            this.btnAñadir.Location = new System.Drawing.Point(584, 0);
            this.btnAñadir.Margin = new System.Windows.Forms.Padding(0);
            this.btnAñadir.MaximumSize = new System.Drawing.Size(166, 89);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Rotation = 0D;
            this.btnAñadir.Size = new System.Drawing.Size(166, 89);
            this.btnAñadir.TabIndex = 5;
            this.btnAñadir.Text = "AÑADIR";
            this.btnAñadir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAñadir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAñadir.UseVisualStyleBackColor = false;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.lblInfo.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.Color.Silver;
            this.lblInfo.Location = new System.Drawing.Point(0, 0);
            this.lblInfo.Margin = new System.Windows.Forms.Padding(0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(578, 26);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "PARA AGREGAR UNA MATERIA, INGRESA NOMBRE Y SELECCIONA UN COLOR";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnColor
            // 
            this.btnColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnColor.BackColor = System.Drawing.Color.White;
            this.btnColor.FlatAppearance.BorderSize = 0;
            this.btnColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColor.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnColor.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnColor.IconColor = System.Drawing.Color.Black;
            this.btnColor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnColor.IconSize = 48;
            this.btnColor.Location = new System.Drawing.Point(422, 60);
            this.btnColor.Margin = new System.Windows.Forms.Padding(0);
            this.btnColor.Name = "btnColor";
            this.btnColor.Rotation = 0D;
            this.btnColor.Size = new System.Drawing.Size(156, 29);
            this.btnColor.TabIndex = 1;
            this.btnColor.Text = "SIN SELECCIONAR";
            this.btnColor.UseVisualStyleBackColor = false;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnGuardar.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnGuardar.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.btnGuardar.IconColor = System.Drawing.Color.White;
            this.btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardar.IconSize = 22;
            this.btnGuardar.Location = new System.Drawing.Point(584, 0);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(0);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Rotation = 0D;
            this.btnGuardar.Size = new System.Drawing.Size(166, 41);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(0, 60);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(0);
            this.txtNombre.MinimumSize = new System.Drawing.Size(2, 20);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(417, 29);
            this.txtNombre.TabIndex = 3;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.BackColor = System.Drawing.Color.Red;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnEliminar.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEliminar.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnEliminar.IconColor = System.Drawing.Color.White;
            this.btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminar.IconSize = 22;
            this.btnEliminar.Location = new System.Drawing.Point(584, 48);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(0);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Rotation = 0D;
            this.btnEliminar.Size = new System.Drawing.Size(166, 41);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // pnlMaterias
            // 
            this.pnlMaterias.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMaterias.AutoScroll = true;
            this.pnlMaterias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.pnlMaterias.Location = new System.Drawing.Point(25, 49);
            this.pnlMaterias.Margin = new System.Windows.Forms.Padding(0);
            this.pnlMaterias.Name = "pnlMaterias";
            this.pnlMaterias.Size = new System.Drawing.Size(750, 262);
            this.pnlMaterias.TabIndex = 2;
            // 
            // pnlMayor
            // 
            this.pnlMayor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.pnlMayor.Controls.Add(this.lblAyudaMaterias);
            this.pnlMayor.Controls.Add(this.lblMaterias);
            this.pnlMayor.Controls.Add(this.pnlMaterias);
            this.pnlMayor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMayor.Location = new System.Drawing.Point(0, 0);
            this.pnlMayor.Name = "pnlMayor";
            this.pnlMayor.Size = new System.Drawing.Size(800, 311);
            this.pnlMayor.TabIndex = 5;
            this.pnlMayor.Click += new System.EventHandler(this.RC2);
            // 
            // lblAyudaMaterias
            // 
            this.lblAyudaMaterias.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAyudaMaterias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblAyudaMaterias.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAyudaMaterias.ForeColor = System.Drawing.Color.Silver;
            this.lblAyudaMaterias.Location = new System.Drawing.Point(441, 20);
            this.lblAyudaMaterias.Margin = new System.Windows.Forms.Padding(0);
            this.lblAyudaMaterias.Name = "lblAyudaMaterias";
            this.lblAyudaMaterias.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.lblAyudaMaterias.Size = new System.Drawing.Size(334, 29);
            this.lblAyudaMaterias.TabIndex = 0;
            this.lblAyudaMaterias.Text = "[CLICK PARA EDITAR - DOBLE CLICK PARA INGRESAR]";
            this.lblAyudaMaterias.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMaterias
            // 
            this.lblMaterias.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMaterias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblMaterias.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaterias.ForeColor = System.Drawing.Color.White;
            this.lblMaterias.Location = new System.Drawing.Point(25, 20);
            this.lblMaterias.Margin = new System.Windows.Forms.Padding(0);
            this.lblMaterias.Name = "lblMaterias";
            this.lblMaterias.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblMaterias.Size = new System.Drawing.Size(416, 29);
            this.lblMaterias.TabIndex = 0;
            this.lblMaterias.Text = "MATERIAS ";
            this.lblMaterias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 700;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Materias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlMayor);
            this.Controls.Add(this.pnlMenor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Materias";
            this.Text = "Materias";
            this.Load += new System.EventHandler(this.Materias_Load);
            this.pnlMenor.ResumeLayout(false);
            this.pnlControles.ResumeLayout(false);
            this.pnlControles.PerformLayout();
            this.pnlMayor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private FontAwesome.Sharp.IconButton btnGuardar;
        private System.Windows.Forms.Panel pnlMenor;
        private System.Windows.Forms.TextBox txtNombre;
        private FontAwesome.Sharp.IconButton btnColor;
        private System.Windows.Forms.Label lblNombre;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private System.Windows.Forms.Panel pnlMaterias;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Panel pnlControles;
        private System.Windows.Forms.Label lblColor;
        private FontAwesome.Sharp.IconButton btnAñadir;
        private System.Windows.Forms.Panel pnlMayor;
        private System.Windows.Forms.Label lblAyudaMaterias;
        private System.Windows.Forms.Label lblMaterias;
        private System.Windows.Forms.Timer timer1;
    }
}