namespace AppControlHoras
{
    partial class MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.PbCodice = new System.Windows.Forms.PictureBox();
            this.GbMenu = new System.Windows.Forms.GroupBox();
            this.BtCerrarSesion = new System.Windows.Forms.Button();
            this.BtAdmin = new System.Windows.Forms.Button();
            this.BtImputacion = new System.Windows.Forms.Button();
            this.BtExportar = new System.Windows.Forms.Button();
            this.BtAusencias = new System.Windows.Forms.Button();
            this.lblUser = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PbCodice)).BeginInit();
            this.GbMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // PbCodice
            // 
            this.PbCodice.Image = global::AppControlHoras.Properties.Resources.CodiceTitulo;
            this.PbCodice.Location = new System.Drawing.Point(12, 12);
            this.PbCodice.Name = "PbCodice";
            this.PbCodice.Size = new System.Drawing.Size(131, 46);
            this.PbCodice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbCodice.TabIndex = 1;
            this.PbCodice.TabStop = false;
            // 
            // GbMenu
            // 
            this.GbMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GbMenu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.GbMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.GbMenu.Controls.Add(this.BtCerrarSesion);
            this.GbMenu.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.GbMenu.Location = new System.Drawing.Point(12, 293);
            this.GbMenu.Name = "GbMenu";
            this.GbMenu.Size = new System.Drawing.Size(411, 70);
            this.GbMenu.TabIndex = 2;
            this.GbMenu.TabStop = false;
            // 
            // BtCerrarSesion
            // 
            this.BtCerrarSesion.BackColor = System.Drawing.Color.White;
            this.BtCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtCerrarSesion.Location = new System.Drawing.Point(158, 19);
            this.BtCerrarSesion.Name = "BtCerrarSesion";
            this.BtCerrarSesion.Size = new System.Drawing.Size(81, 33);
            this.BtCerrarSesion.TabIndex = 7;
            this.BtCerrarSesion.Text = "Cerrar Sesion";
            this.BtCerrarSesion.UseVisualStyleBackColor = false;
            this.BtCerrarSesion.Click += new System.EventHandler(this.BtCerrarSesion_Click);
            // 
            // BtAdmin
            // 
            this.BtAdmin.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtAdmin.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.BtAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtAdmin.Location = new System.Drawing.Point(144, 120);
            this.BtAdmin.Name = "BtAdmin";
            this.BtAdmin.Size = new System.Drawing.Size(142, 23);
            this.BtAdmin.TabIndex = 3;
            this.BtAdmin.Text = "Administración";
            this.BtAdmin.UseVisualStyleBackColor = false;
            this.BtAdmin.Visible = false;
            this.BtAdmin.Click += new System.EventHandler(this.BtAdmin_Click);
            // 
            // BtImputacion
            // 
            this.BtImputacion.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtImputacion.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.BtImputacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtImputacion.Location = new System.Drawing.Point(144, 149);
            this.BtImputacion.Name = "BtImputacion";
            this.BtImputacion.Size = new System.Drawing.Size(142, 23);
            this.BtImputacion.TabIndex = 4;
            this.BtImputacion.Text = "Imputación de Horas";
            this.BtImputacion.UseVisualStyleBackColor = false;
            this.BtImputacion.Visible = false;
            this.BtImputacion.Click += new System.EventHandler(this.BtImputacion_Click);
            // 
            // BtExportar
            // 
            this.BtExportar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtExportar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.BtExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtExportar.Location = new System.Drawing.Point(144, 178);
            this.BtExportar.Name = "BtExportar";
            this.BtExportar.Size = new System.Drawing.Size(142, 23);
            this.BtExportar.TabIndex = 5;
            this.BtExportar.Text = "Exportar Datos";
            this.BtExportar.UseVisualStyleBackColor = false;
            this.BtExportar.Visible = false;
            this.BtExportar.Click += new System.EventHandler(this.BtExportar_Click);
            // 
            // BtAusencias
            // 
            this.BtAusencias.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtAusencias.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.BtAusencias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtAusencias.Location = new System.Drawing.Point(144, 207);
            this.BtAusencias.Name = "BtAusencias";
            this.BtAusencias.Size = new System.Drawing.Size(142, 23);
            this.BtAusencias.TabIndex = 6;
            this.BtAusencias.Text = "Control de Ausencias";
            this.BtAusencias.UseVisualStyleBackColor = false;
            this.BtAusencias.Visible = false;
            this.BtAusencias.Click += new System.EventHandler(this.BtAusencias_Click);
            // 
            // lblUser
            // 
            this.lblUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(316, 22);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(57, 17);
            this.lblUser.TabIndex = 7;
            this.lblUser.Text = "Usuario";
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(435, 446);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.BtAusencias);
            this.Controls.Add(this.BtExportar);
            this.Controls.Add(this.BtImputacion);
            this.Controls.Add(this.BtAdmin);
            this.Controls.Add(this.GbMenu);
            this.Controls.Add(this.PbCodice);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            ((System.ComponentModel.ISupportInitialize)(this.PbCodice)).EndInit();
            this.GbMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PbCodice;
        private System.Windows.Forms.GroupBox GbMenu;
        private System.Windows.Forms.Button BtCerrarSesion;
        private System.Windows.Forms.Button BtAdmin;
        private System.Windows.Forms.Button BtImputacion;
        private System.Windows.Forms.Button BtExportar;
        private System.Windows.Forms.Button BtAusencias;
        private System.Windows.Forms.Label lblUser;
    }
}