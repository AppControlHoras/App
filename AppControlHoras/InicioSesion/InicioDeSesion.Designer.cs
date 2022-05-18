namespace AppControlHoras
{
    partial class InicioSesion
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InicioSesion));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TbUser = new System.Windows.Forms.TextBox();
            this.TbPswd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtInicioSesion = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PbCodice = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbCodice)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 116);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(411, 40);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Control de Horas";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.Location = new System.Drawing.Point(119, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Usuario:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TbUser
            // 
            this.TbUser.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TbUser.BackColor = System.Drawing.Color.White;
            this.TbUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbUser.Location = new System.Drawing.Point(207, 213);
            this.TbUser.Name = "TbUser";
            this.TbUser.Size = new System.Drawing.Size(100, 20);
            this.TbUser.TabIndex = 3;
            // 
            // TbPswd
            // 
            this.TbPswd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TbPswd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbPswd.Location = new System.Drawing.Point(207, 252);
            this.TbPswd.Name = "TbPswd";
            this.TbPswd.PasswordChar = '*';
            this.TbPswd.Size = new System.Drawing.Size(100, 20);
            this.TbPswd.TabIndex = 5;
            this.TbPswd.TextChanged += new System.EventHandler(this.TbPswd_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.Location = new System.Drawing.Point(119, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Contraseña:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtInicioSesion
            // 
            this.BtInicioSesion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtInicioSesion.BackColor = System.Drawing.SystemColors.Control;
            this.BtInicioSesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtInicioSesion.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.BtInicioSesion.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BtInicioSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtInicioSesion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtInicioSesion.Location = new System.Drawing.Point(172, 278);
            this.BtInicioSesion.Name = "BtInicioSesion";
            this.BtInicioSesion.Size = new System.Drawing.Size(81, 23);
            this.BtInicioSesion.TabIndex = 6;
            this.BtInicioSesion.Text = "Iniciar Sesión";
            this.BtInicioSesion.UseVisualStyleBackColor = false;
            this.BtInicioSesion.Click += new System.EventHandler(this.BtInicioSesion_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::AppControlHoras.Properties.Resources.MostrarPsswd;
            this.pictureBox2.Location = new System.Drawing.Point(288, 255);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(16, 14);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AppControlHoras.Properties.Resources.ocultarPswd;
            this.pictureBox1.Location = new System.Drawing.Point(288, 255);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 14);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // PbCodice
            // 
            this.PbCodice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PbCodice.Image = global::AppControlHoras.Properties.Resources.CodiceTitulo;
            this.PbCodice.Location = new System.Drawing.Point(12, 36);
            this.PbCodice.Name = "PbCodice";
            this.PbCodice.Size = new System.Drawing.Size(411, 57);
            this.PbCodice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PbCodice.TabIndex = 0;
            this.PbCodice.TabStop = false;
            // 
            // InicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(435, 446);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.BtInicioSesion);
            this.Controls.Add(this.TbPswd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TbUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.PbCodice);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "InicioSesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio de Sesion";
            this.Load += new System.EventHandler(this.InicioSesion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbCodice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PbCodice;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbUser;
        private System.Windows.Forms.TextBox TbPswd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtInicioSesion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

