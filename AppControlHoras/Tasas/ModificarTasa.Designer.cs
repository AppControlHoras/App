namespace AppControlHoras.Tasas
{
    partial class ModificarTasa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarTasa));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btBuscar = new System.Windows.Forms.Button();
            this.panelModificar = new System.Windows.Forms.Panel();
            this.btCambiar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbIdTasas = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbValorAntiguo = new System.Windows.Forms.Label();
            this.nudNuevoValor = new System.Windows.Forms.NumericUpDown();
            this.PbCodice = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panelModificar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNuevoValor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbCodice)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbIdTasas);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btBuscar);
            this.panel2.Location = new System.Drawing.Point(62, 89);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(240, 100);
            this.panel2.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Tasa:";
            // 
            // btBuscar
            // 
            this.btBuscar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btBuscar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBuscar.Location = new System.Drawing.Point(83, 52);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(75, 23);
            this.btBuscar.TabIndex = 24;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = false;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // panelModificar
            // 
            this.panelModificar.Controls.Add(this.nudNuevoValor);
            this.panelModificar.Controls.Add(this.lbValorAntiguo);
            this.panelModificar.Controls.Add(this.label2);
            this.panelModificar.Controls.Add(this.btCambiar);
            this.panelModificar.Controls.Add(this.label4);
            this.panelModificar.Location = new System.Drawing.Point(62, 195);
            this.panelModificar.Name = "panelModificar";
            this.panelModificar.Size = new System.Drawing.Size(240, 130);
            this.panelModificar.TabIndex = 27;
            this.panelModificar.Visible = false;
            // 
            // btCambiar
            // 
            this.btCambiar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btCambiar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btCambiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCambiar.Location = new System.Drawing.Point(83, 104);
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
            this.label4.Location = new System.Drawing.Point(17, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nuevo Valor:";
            // 
            // cbIdTasas
            // 
            this.cbIdTasas.FormattingEnabled = true;
            this.cbIdTasas.Location = new System.Drawing.Point(94, 14);
            this.cbIdTasas.Name = "cbIdTasas";
            this.cbIdTasas.Size = new System.Drawing.Size(121, 21);
            this.cbIdTasas.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Valor Antiguo:";
            // 
            // lbValorAntiguo
            // 
            this.lbValorAntiguo.AutoSize = true;
            this.lbValorAntiguo.Location = new System.Drawing.Point(96, 22);
            this.lbValorAntiguo.Name = "lbValorAntiguo";
            this.lbValorAntiguo.Size = new System.Drawing.Size(35, 13);
            this.lbValorAntiguo.TabIndex = 30;
            this.lbValorAntiguo.Text = "label3";
            // 
            // nudNuevoValor
            // 
            this.nudNuevoValor.Location = new System.Drawing.Point(95, 64);
            this.nudNuevoValor.Name = "nudNuevoValor";
            this.nudNuevoValor.Size = new System.Drawing.Size(120, 20);
            this.nudNuevoValor.TabIndex = 31;
            this.nudNuevoValor.ValueChanged += new System.EventHandler(this.nudNuevoValor_ValueChanged);
            // 
            // PbCodice
            // 
            this.PbCodice.Image = global::AppControlHoras.Properties.Resources.CodiceTitulo;
            this.PbCodice.Location = new System.Drawing.Point(12, 12);
            this.PbCodice.Name = "PbCodice";
            this.PbCodice.Size = new System.Drawing.Size(131, 46);
            this.PbCodice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbCodice.TabIndex = 29;
            this.PbCodice.TabStop = false;
            // 
            // ModificarTasa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.PbCodice);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelModificar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ModificarTasa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModificarTasa";
            this.Load += new System.EventHandler(this.ModificarTasa_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelModificar.ResumeLayout(false);
            this.panelModificar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNuevoValor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbCodice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbIdTasas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.Panel panelModificar;
        private System.Windows.Forms.Button btCambiar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbValorAntiguo;
        private System.Windows.Forms.NumericUpDown nudNuevoValor;
        private System.Windows.Forms.PictureBox PbCodice;
    }
}