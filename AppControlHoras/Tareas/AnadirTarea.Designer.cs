namespace AppControlHoras.Tareas
{
    partial class AnadirTarea
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnadirTarea));
            this.btAnadir = new System.Windows.Forms.Button();
            this.tbTarea = new System.Windows.Forms.TextBox();
            this.lblProyecto = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btAnadir
            // 
            this.btAnadir.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btAnadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAnadir.Location = new System.Drawing.Point(132, 157);
            this.btAnadir.Name = "btAnadir";
            this.btAnadir.Size = new System.Drawing.Size(75, 23);
            this.btAnadir.TabIndex = 14;
            this.btAnadir.Text = "Añadir";
            this.btAnadir.UseVisualStyleBackColor = true;
            this.btAnadir.Click += new System.EventHandler(this.btAnadir_Click);
            // 
            // tbTarea
            // 
            this.tbTarea.Location = new System.Drawing.Point(167, 129);
            this.tbTarea.Name = "tbTarea";
            this.tbTarea.Size = new System.Drawing.Size(100, 20);
            this.tbTarea.TabIndex = 13;
            // 
            // lblProyecto
            // 
            this.lblProyecto.AutoSize = true;
            this.lblProyecto.Location = new System.Drawing.Point(70, 132);
            this.lblProyecto.Name = "lblProyecto";
            this.lblProyecto.Size = new System.Drawing.Size(93, 13);
            this.lblProyecto.TabIndex = 12;
            this.lblProyecto.Text = "Nombre de Tarea:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AppControlHoras.Properties.Resources.CodiceTitulo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // AnadirTarea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(334, 311);
            this.Controls.Add(this.btAnadir);
            this.Controls.Add(this.tbTarea);
            this.Controls.Add(this.lblProyecto);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AnadirTarea";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AnadirTarea";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btAnadir;
        private System.Windows.Forms.TextBox tbTarea;
        private System.Windows.Forms.Label lblProyecto;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}