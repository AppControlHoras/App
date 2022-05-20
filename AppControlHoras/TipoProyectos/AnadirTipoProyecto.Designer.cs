namespace AppControlHoras.TipoProyectos
{
    partial class AnadirTipoProyecto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnadirTipoProyecto));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btAnadir = new System.Windows.Forms.Button();
            this.tbTipoProyecto = new System.Windows.Forms.TextBox();
            this.lblProyecto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AppControlHoras.Properties.Resources.CodiceTitulo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btAnadir
            // 
            this.btAnadir.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btAnadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAnadir.Location = new System.Drawing.Point(132, 157);
            this.btAnadir.Name = "btAnadir";
            this.btAnadir.Size = new System.Drawing.Size(75, 23);
            this.btAnadir.TabIndex = 10;
            this.btAnadir.Text = "Añadir";
            this.btAnadir.UseVisualStyleBackColor = true;
            this.btAnadir.Click += new System.EventHandler(this.btAnadir_Click);
            // 
            // tbTipoProyecto
            // 
            this.tbTipoProyecto.Location = new System.Drawing.Point(167, 129);
            this.tbTipoProyecto.Name = "tbTipoProyecto";
            this.tbTipoProyecto.Size = new System.Drawing.Size(100, 20);
            this.tbTipoProyecto.TabIndex = 9;
            // 
            // lblProyecto
            // 
            this.lblProyecto.AutoSize = true;
            this.lblProyecto.Location = new System.Drawing.Point(70, 132);
            this.lblProyecto.Name = "lblProyecto";
            this.lblProyecto.Size = new System.Drawing.Size(91, 13);
            this.lblProyecto.TabIndex = 8;
            this.lblProyecto.Text = "Tipo de Proyecto:";
            // 
            // AnadirTipoProyecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(334, 311);
            this.Controls.Add(this.btAnadir);
            this.Controls.Add(this.tbTipoProyecto);
            this.Controls.Add(this.lblProyecto);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AnadirTipoProyecto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AnadirTipoProyecto";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btAnadir;
        private System.Windows.Forms.TextBox tbTipoProyecto;
        private System.Windows.Forms.Label lblProyecto;
    }
}