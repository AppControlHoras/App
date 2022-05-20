namespace AppControlHoras.AreaFuncional
{
    partial class ModificarArea
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarArea));
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblArea = new System.Windows.Forms.Label();
            this.tbArea = new System.Windows.Forms.TextBox();
            this.btBuscar = new System.Windows.Forms.Button();
            this.panelModificar = new System.Windows.Forms.Panel();
            this.lblIdArea = new System.Windows.Forms.Label();
            this.lbIdArea = new System.Windows.Forms.Label();
            this.btCambiar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNuevoNombre = new System.Windows.Forms.TextBox();
            this.PbCodice = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panelModificar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbCodice)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblArea);
            this.panel2.Controls.Add(this.tbArea);
            this.panel2.Controls.Add(this.btBuscar);
            this.panel2.Location = new System.Drawing.Point(70, 84);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(240, 100);
            this.panel2.TabIndex = 31;
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(17, 17);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(72, 13);
            this.lblArea.TabIndex = 0;
            this.lblArea.Text = "Nombre Area:";
            // 
            // tbArea
            // 
            this.tbArea.Location = new System.Drawing.Point(115, 14);
            this.tbArea.Name = "tbArea";
            this.tbArea.Size = new System.Drawing.Size(100, 20);
            this.tbArea.TabIndex = 1;
            // 
            // btBuscar
            // 
            this.btBuscar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btBuscar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBuscar.Location = new System.Drawing.Point(83, 56);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(75, 23);
            this.btBuscar.TabIndex = 24;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = false;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // panelModificar
            // 
            this.panelModificar.Controls.Add(this.lblIdArea);
            this.panelModificar.Controls.Add(this.lbIdArea);
            this.panelModificar.Controls.Add(this.btCambiar);
            this.panelModificar.Controls.Add(this.label4);
            this.panelModificar.Controls.Add(this.tbNuevoNombre);
            this.panelModificar.Location = new System.Drawing.Point(70, 190);
            this.panelModificar.Name = "panelModificar";
            this.panelModificar.Size = new System.Drawing.Size(240, 130);
            this.panelModificar.TabIndex = 30;
            this.panelModificar.Visible = false;
            // 
            // lblIdArea
            // 
            this.lblIdArea.AutoSize = true;
            this.lblIdArea.Location = new System.Drawing.Point(17, 13);
            this.lblIdArea.Name = "lblIdArea";
            this.lblIdArea.Size = new System.Drawing.Size(46, 13);
            this.lblIdArea.TabIndex = 3;
            this.lblIdArea.Text = "ID Area:";
            // 
            // lbIdArea
            // 
            this.lbIdArea.AutoSize = true;
            this.lbIdArea.Location = new System.Drawing.Point(112, 13);
            this.lbIdArea.Name = "lbIdArea";
            this.lbIdArea.Size = new System.Drawing.Size(35, 13);
            this.lbIdArea.TabIndex = 4;
            this.lbIdArea.Text = "label3";
            // 
            // btCambiar
            // 
            this.btCambiar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btCambiar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btCambiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCambiar.Location = new System.Drawing.Point(83, 93);
            this.btCambiar.Name = "btCambiar";
            this.btCambiar.Size = new System.Drawing.Size(75, 23);
            this.btCambiar.TabIndex = 23;
            this.btCambiar.Text = "Cambiar";
            this.btCambiar.UseVisualStyleBackColor = false;
            this.btCambiar.Click += new System.EventHandler(this.btCambiar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nuevo Nombre:";
            // 
            // tbNuevoNombre
            // 
            this.tbNuevoNombre.Location = new System.Drawing.Point(115, 49);
            this.tbNuevoNombre.Name = "tbNuevoNombre";
            this.tbNuevoNombre.Size = new System.Drawing.Size(100, 20);
            this.tbNuevoNombre.TabIndex = 6;
            // 
            // PbCodice
            // 
            this.PbCodice.Image = global::AppControlHoras.Properties.Resources.CodiceTitulo;
            this.PbCodice.Location = new System.Drawing.Point(12, 12);
            this.PbCodice.Name = "PbCodice";
            this.PbCodice.Size = new System.Drawing.Size(131, 46);
            this.PbCodice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbCodice.TabIndex = 32;
            this.PbCodice.TabStop = false;
            // 
            // ModificarArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.PbCodice);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelModificar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ModificarArea";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModificarArea";
            this.Load += new System.EventHandler(this.ModificarArea_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelModificar.ResumeLayout(false);
            this.panelModificar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbCodice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PbCodice;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.TextBox tbArea;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.Panel panelModificar;
        private System.Windows.Forms.Label lblIdArea;
        private System.Windows.Forms.Label lbIdArea;
        private System.Windows.Forms.Button btCambiar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNuevoNombre;
    }
}