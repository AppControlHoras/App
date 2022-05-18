namespace AppControlHoras.Tasas
{
    partial class AnadirTasa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnadirTasa));
            this.btAnadir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nudTasa = new System.Windows.Forms.NumericUpDown();
            this.PbCodice = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudTasa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbCodice)).BeginInit();
            this.SuspendLayout();
            // 
            // btAnadir
            // 
            this.btAnadir.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btAnadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAnadir.Location = new System.Drawing.Point(114, 186);
            this.btAnadir.Name = "btAnadir";
            this.btAnadir.Size = new System.Drawing.Size(75, 23);
            this.btAnadir.TabIndex = 5;
            this.btAnadir.Text = "Añadir";
            this.btAnadir.UseVisualStyleBackColor = true;
            this.btAnadir.Click += new System.EventHandler(this.btAnadir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Valor Tasa:";
            // 
            // nudTasa
            // 
            this.nudTasa.Location = new System.Drawing.Point(115, 133);
            this.nudTasa.Name = "nudTasa";
            this.nudTasa.Size = new System.Drawing.Size(120, 20);
            this.nudTasa.TabIndex = 6;
            this.nudTasa.ValueChanged += new System.EventHandler(this.nudTasa_ValueChanged);
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
            // AnadirTasa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(334, 311);
            this.Controls.Add(this.PbCodice);
            this.Controls.Add(this.nudTasa);
            this.Controls.Add(this.btAnadir);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AnadirTasa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AnadirTasa";
            ((System.ComponentModel.ISupportInitialize)(this.nudTasa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbCodice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btAnadir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudTasa;
        private System.Windows.Forms.PictureBox PbCodice;
    }
}