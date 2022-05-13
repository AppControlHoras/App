namespace AppControlHoras.Cuentas
{
    partial class AnadirCuenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnadirCuenta));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.tbIdCliente = new System.Windows.Forms.TextBox();
            this.btAnadir = new System.Windows.Forms.Button();
            this.PbCodice = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PbCodice)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Descripcion:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "ID Cliente:";
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.BackColor = System.Drawing.SystemColors.Window;
            this.tbDescripcion.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbDescripcion.Location = new System.Drawing.Point(155, 118);
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.Size = new System.Drawing.Size(100, 20);
            this.tbDescripcion.TabIndex = 14;
            // 
            // tbIdCliente
            // 
            this.tbIdCliente.BackColor = System.Drawing.SystemColors.Window;
            this.tbIdCliente.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbIdCliente.Location = new System.Drawing.Point(155, 155);
            this.tbIdCliente.Name = "tbIdCliente";
            this.tbIdCliente.Size = new System.Drawing.Size(100, 20);
            this.tbIdCliente.TabIndex = 13;
            // 
            // btAnadir
            // 
            this.btAnadir.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btAnadir.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btAnadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAnadir.Location = new System.Drawing.Point(126, 207);
            this.btAnadir.Name = "btAnadir";
            this.btAnadir.Size = new System.Drawing.Size(75, 23);
            this.btAnadir.TabIndex = 17;
            this.btAnadir.Text = "Añadir";
            this.btAnadir.UseVisualStyleBackColor = false;
            this.btAnadir.Click += new System.EventHandler(this.btAnadir_Click);
            // 
            // PbCodice
            // 
            this.PbCodice.Image = global::AppControlHoras.Properties.Resources.CodiceTitulo;
            this.PbCodice.Location = new System.Drawing.Point(12, 12);
            this.PbCodice.Name = "PbCodice";
            this.PbCodice.Size = new System.Drawing.Size(131, 46);
            this.PbCodice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbCodice.TabIndex = 18;
            this.PbCodice.TabStop = false;
            // 
            // AnadirCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(334, 311);
            this.Controls.Add(this.PbCodice);
            this.Controls.Add(this.btAnadir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbDescripcion);
            this.Controls.Add(this.tbIdCliente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AnadirCuenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AnadirCuenta";
            ((System.ComponentModel.ISupportInitialize)(this.PbCodice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbDescripcion;
        private System.Windows.Forms.TextBox tbIdCliente;
        private System.Windows.Forms.Button btAnadir;
        private System.Windows.Forms.PictureBox PbCodice;
    }
}