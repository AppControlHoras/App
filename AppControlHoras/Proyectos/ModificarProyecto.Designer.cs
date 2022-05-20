namespace AppControlHoras.Proyectos
{
    partial class ModificarProyecto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarProyecto));
            this.lblProyecto = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.btBuscar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btCambiar = new System.Windows.Forms.Button();
            this.tbNuevoNombre = new System.Windows.Forms.TextBox();
            this.lblNuevoNombre = new System.Windows.Forms.Label();
            this.lblIDProyecto = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblProyecto
            // 
            this.lblProyecto.AutoSize = true;
            this.lblProyecto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProyecto.Location = new System.Drawing.Point(3, 21);
            this.lblProyecto.Name = "lblProyecto";
            this.lblProyecto.Size = new System.Drawing.Size(92, 13);
            this.lblProyecto.TabIndex = 1;
            this.lblProyecto.Text = "Nombre Proyecto:";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(101, 18);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(114, 20);
            this.tbNombre.TabIndex = 2;
            // 
            // btBuscar
            // 
            this.btBuscar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBuscar.Location = new System.Drawing.Point(68, 47);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(75, 23);
            this.btBuscar.TabIndex = 3;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AppControlHoras.Properties.Resources.CodiceTitulo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblProyecto);
            this.panel1.Controls.Add(this.btBuscar);
            this.panel1.Controls.Add(this.tbNombre);
            this.panel1.Location = new System.Drawing.Point(49, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(218, 82);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btCambiar);
            this.panel2.Controls.Add(this.tbNuevoNombre);
            this.panel2.Controls.Add(this.lblNuevoNombre);
            this.panel2.Controls.Add(this.lblIDProyecto);
            this.panel2.Controls.Add(this.lblID);
            this.panel2.Location = new System.Drawing.Point(49, 163);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(218, 113);
            this.panel2.TabIndex = 5;
            this.panel2.Visible = false;
            // 
            // btCambiar
            // 
            this.btCambiar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btCambiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCambiar.Location = new System.Drawing.Point(68, 71);
            this.btCambiar.Name = "btCambiar";
            this.btCambiar.Size = new System.Drawing.Size(75, 23);
            this.btCambiar.TabIndex = 4;
            this.btCambiar.Text = "Cambiar";
            this.btCambiar.UseVisualStyleBackColor = true;
            this.btCambiar.Click += new System.EventHandler(this.btCambiar_Click);
            // 
            // tbNuevoNombre
            // 
            this.tbNuevoNombre.Location = new System.Drawing.Point(98, 45);
            this.tbNuevoNombre.Name = "tbNuevoNombre";
            this.tbNuevoNombre.Size = new System.Drawing.Size(114, 20);
            this.tbNuevoNombre.TabIndex = 4;
            // 
            // lblNuevoNombre
            // 
            this.lblNuevoNombre.AutoSize = true;
            this.lblNuevoNombre.Location = new System.Drawing.Point(6, 48);
            this.lblNuevoNombre.Name = "lblNuevoNombre";
            this.lblNuevoNombre.Size = new System.Drawing.Size(82, 13);
            this.lblNuevoNombre.TabIndex = 2;
            this.lblNuevoNombre.Text = "Nuevo Nombre:";
            // 
            // lblIDProyecto
            // 
            this.lblIDProyecto.AutoSize = true;
            this.lblIDProyecto.Location = new System.Drawing.Point(98, 14);
            this.lblIDProyecto.Name = "lblIDProyecto";
            this.lblIDProyecto.Size = new System.Drawing.Size(35, 13);
            this.lblIDProyecto.TabIndex = 1;
            this.lblIDProyecto.Text = "label1";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(3, 14);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(63, 13);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID Proyecto";
            // 
            // ModificarProyecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(334, 311);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ModificarProyecto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModificarProyecto";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ModificarProyecto_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblProyecto;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btCambiar;
        private System.Windows.Forms.TextBox tbNuevoNombre;
        private System.Windows.Forms.Label lblNuevoNombre;
        private System.Windows.Forms.Label lblIDProyecto;
        private System.Windows.Forms.Label lblID;
    }
}