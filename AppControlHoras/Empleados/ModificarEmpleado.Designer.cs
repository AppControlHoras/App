namespace AppControlHoras.Empleados
{
    partial class ModificarEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarEmpleado));
            this.label1 = new System.Windows.Forms.Label();
            this.cbIdEmpleado = new System.Windows.Forms.ComboBox();
            this.btBuscar = new System.Windows.Forms.Button();
            this.plInfoEmpleado = new System.Windows.Forms.Panel();
            this.tbSegundoApellido = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbTasa = new System.Windows.Forms.ComboBox();
            this.cbArea = new System.Windows.Forms.ComboBox();
            this.dtpFechaAlta = new System.Windows.Forms.DateTimePicker();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbPrimerApellido = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btModificar = new System.Windows.Forms.Button();
            this.PbCodice = new System.Windows.Forms.PictureBox();
            this.plInfoEmpleado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbCodice)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Empleado:";
            // 
            // cbIdEmpleado
            // 
            this.cbIdEmpleado.FormattingEnabled = true;
            this.cbIdEmpleado.Location = new System.Drawing.Point(155, 79);
            this.cbIdEmpleado.Name = "cbIdEmpleado";
            this.cbIdEmpleado.Size = new System.Drawing.Size(121, 21);
            this.cbIdEmpleado.TabIndex = 1;
            // 
            // btBuscar
            // 
            this.btBuscar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btBuscar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBuscar.Location = new System.Drawing.Point(305, 77);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(75, 23);
            this.btBuscar.TabIndex = 6;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = false;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // plInfoEmpleado
            // 
            this.plInfoEmpleado.Controls.Add(this.btModificar);
            this.plInfoEmpleado.Controls.Add(this.tbSegundoApellido);
            this.plInfoEmpleado.Controls.Add(this.label7);
            this.plInfoEmpleado.Controls.Add(this.cbTasa);
            this.plInfoEmpleado.Controls.Add(this.cbArea);
            this.plInfoEmpleado.Controls.Add(this.dtpFechaAlta);
            this.plInfoEmpleado.Controls.Add(this.tbEmail);
            this.plInfoEmpleado.Controls.Add(this.tbPrimerApellido);
            this.plInfoEmpleado.Controls.Add(this.tbNombre);
            this.plInfoEmpleado.Controls.Add(this.label6);
            this.plInfoEmpleado.Controls.Add(this.label5);
            this.plInfoEmpleado.Controls.Add(this.label4);
            this.plInfoEmpleado.Controls.Add(this.label3);
            this.plInfoEmpleado.Controls.Add(this.label2);
            this.plInfoEmpleado.Controls.Add(this.label8);
            this.plInfoEmpleado.Location = new System.Drawing.Point(42, 129);
            this.plInfoEmpleado.Name = "plInfoEmpleado";
            this.plInfoEmpleado.Size = new System.Drawing.Size(724, 266);
            this.plInfoEmpleado.TabIndex = 7;
            this.plInfoEmpleado.Visible = false;
            // 
            // tbSegundoApellido
            // 
            this.tbSegundoApellido.Location = new System.Drawing.Point(555, 32);
            this.tbSegundoApellido.Name = "tbSegundoApellido";
            this.tbSegundoApellido.Size = new System.Drawing.Size(121, 20);
            this.tbSegundoApellido.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(470, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Primer Apellido:";
            // 
            // cbTasa
            // 
            this.cbTasa.FormattingEnabled = true;
            this.cbTasa.Location = new System.Drawing.Point(86, 138);
            this.cbTasa.Name = "cbTasa";
            this.cbTasa.Size = new System.Drawing.Size(125, 21);
            this.cbTasa.TabIndex = 27;
            // 
            // cbArea
            // 
            this.cbArea.FormattingEnabled = true;
            this.cbArea.Location = new System.Drawing.Point(555, 86);
            this.cbArea.Name = "cbArea";
            this.cbArea.Size = new System.Drawing.Size(121, 21);
            this.cbArea.TabIndex = 26;
            // 
            // dtpFechaAlta
            // 
            this.dtpFechaAlta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaAlta.Location = new System.Drawing.Point(318, 87);
            this.dtpFechaAlta.Name = "dtpFechaAlta";
            this.dtpFechaAlta.Size = new System.Drawing.Size(125, 20);
            this.dtpFechaAlta.TabIndex = 25;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(90, 87);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(121, 20);
            this.tbEmail.TabIndex = 24;
            // 
            // tbPrimerApellido
            // 
            this.tbPrimerApellido.Location = new System.Drawing.Point(336, 29);
            this.tbPrimerApellido.Name = "tbPrimerApellido";
            this.tbPrimerApellido.Size = new System.Drawing.Size(107, 20);
            this.tbPrimerApellido.TabIndex = 23;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(90, 29);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(121, 20);
            this.tbNombre.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Tasa:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(470, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Area:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(251, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Fecha Alta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(251, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Primer Apellido:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Nombre:";
            // 
            // btModificar
            // 
            this.btModificar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btModificar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btModificar.Location = new System.Drawing.Point(318, 193);
            this.btModificar.Name = "btModificar";
            this.btModificar.Size = new System.Drawing.Size(75, 23);
            this.btModificar.TabIndex = 8;
            this.btModificar.Text = "Modificar";
            this.btModificar.UseVisualStyleBackColor = false;
            this.btModificar.Click += new System.EventHandler(this.btModificar_Click);
            // 
            // PbCodice
            // 
            this.PbCodice.Image = global::AppControlHoras.Properties.Resources.CodiceTitulo;
            this.PbCodice.Location = new System.Drawing.Point(12, 12);
            this.PbCodice.Name = "PbCodice";
            this.PbCodice.Size = new System.Drawing.Size(131, 46);
            this.PbCodice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbCodice.TabIndex = 11;
            this.PbCodice.TabStop = false;
            // 
            // ModificarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PbCodice);
            this.Controls.Add(this.plInfoEmpleado);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.cbIdEmpleado);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ModificarEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModificarEmpleado";
            this.Load += new System.EventHandler(this.ModificarEmpleado_Load);
            this.plInfoEmpleado.ResumeLayout(false);
            this.plInfoEmpleado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbCodice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbIdEmpleado;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.Panel plInfoEmpleado;
        private System.Windows.Forms.Button btModificar;
        private System.Windows.Forms.TextBox tbSegundoApellido;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbTasa;
        private System.Windows.Forms.ComboBox cbArea;
        private System.Windows.Forms.DateTimePicker dtpFechaAlta;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbPrimerApellido;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox PbCodice;
    }
}