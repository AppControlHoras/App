﻿namespace AppControlHoras
{
    partial class MenuAdministracion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuAdministracion));
            this.btCuentas = new System.Windows.Forms.Button();
            this.PbCodice = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PbCodice)).BeginInit();
            this.SuspendLayout();
            // 
            // btCuentas
            // 
            this.btCuentas.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btCuentas.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btCuentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCuentas.Location = new System.Drawing.Point(68, 112);
            this.btCuentas.Name = "btCuentas";
            this.btCuentas.Size = new System.Drawing.Size(75, 23);
            this.btCuentas.TabIndex = 0;
            this.btCuentas.Text = "Cuentas";
            this.btCuentas.UseVisualStyleBackColor = false;
            this.btCuentas.Click += new System.EventHandler(this.btCuentas_Click);
            // 
            // PbCodice
            // 
            this.PbCodice.Image = global::AppControlHoras.Properties.Resources.CodiceTitulo;
            this.PbCodice.Location = new System.Drawing.Point(12, 12);
            this.PbCodice.Name = "PbCodice";
            this.PbCodice.Size = new System.Drawing.Size(131, 46);
            this.PbCodice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbCodice.TabIndex = 9;
            this.PbCodice.TabStop = false;
            // 
            // MenuAdministracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PbCodice);
            this.Controls.Add(this.btCuentas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuAdministracion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuAdministracion";
            ((System.ComponentModel.ISupportInitialize)(this.PbCodice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btCuentas;
        private System.Windows.Forms.PictureBox PbCodice;
    }
}