namespace AppControlHoras.Tareas
{
    partial class ModificarTarea
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarTarea));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btCambiar = new System.Windows.Forms.Button();
            this.tbNuevoNombre = new System.Windows.Forms.TextBox();
            this.lblNuevoTipo = new System.Windows.Forms.Label();
            this.lblIDTarea = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTipoProyecto = new System.Windows.Forms.Label();
            this.btBuscar = new System.Windows.Forms.Button();
            this.tbTarea = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btCambiar);
            this.panel2.Controls.Add(this.tbNuevoNombre);
            this.panel2.Controls.Add(this.lblNuevoTipo);
            this.panel2.Controls.Add(this.lblIDTarea);
            this.panel2.Controls.Add(this.lblID);
            this.panel2.Location = new System.Drawing.Point(53, 165);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(218, 113);
            this.panel2.TabIndex = 10;
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
            // lblNuevoTipo
            // 
            this.lblNuevoTipo.AutoSize = true;
            this.lblNuevoTipo.Location = new System.Drawing.Point(6, 48);
            this.lblNuevoTipo.Name = "lblNuevoTipo";
            this.lblNuevoTipo.Size = new System.Drawing.Size(82, 13);
            this.lblNuevoTipo.TabIndex = 2;
            this.lblNuevoTipo.Text = "Nuevo Nombre:";
            // 
            // lblIDTarea
            // 
            this.lblIDTarea.AutoSize = true;
            this.lblIDTarea.Location = new System.Drawing.Point(98, 14);
            this.lblIDTarea.Name = "lblIDTarea";
            this.lblIDTarea.Size = new System.Drawing.Size(35, 13);
            this.lblIDTarea.TabIndex = 1;
            this.lblIDTarea.Text = "label1";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(3, 14);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(52, 13);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID Tarea:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTipoProyecto);
            this.panel1.Controls.Add(this.btBuscar);
            this.panel1.Controls.Add(this.tbTarea);
            this.panel1.Location = new System.Drawing.Point(53, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(218, 82);
            this.panel1.TabIndex = 9;
            // 
            // lblTipoProyecto
            // 
            this.lblTipoProyecto.AutoSize = true;
            this.lblTipoProyecto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoProyecto.Location = new System.Drawing.Point(3, 21);
            this.lblTipoProyecto.Name = "lblTipoProyecto";
            this.lblTipoProyecto.Size = new System.Drawing.Size(78, 13);
            this.lblTipoProyecto.TabIndex = 1;
            this.lblTipoProyecto.Text = "Nombre Tarea:";
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
            // tbTarea
            // 
            this.tbTarea.Location = new System.Drawing.Point(101, 18);
            this.tbTarea.Name = "tbTarea";
            this.tbTarea.Size = new System.Drawing.Size(114, 20);
            this.tbTarea.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AppControlHoras.Properties.Resources.CodiceTitulo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // ModificarTarea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(334, 311);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ModificarTarea";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModificarTarea";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btCambiar;
        private System.Windows.Forms.TextBox tbNuevoNombre;
        private System.Windows.Forms.Label lblNuevoTipo;
        private System.Windows.Forms.Label lblIDTarea;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTipoProyecto;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.TextBox tbTarea;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}