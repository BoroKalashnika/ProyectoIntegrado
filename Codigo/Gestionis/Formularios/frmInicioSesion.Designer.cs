﻿namespace Gestionis
{
    partial class frmInicioSesion
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicioSesion));
            lblInicioSesion = new Label();
            lblNombreUsuario = new Label();
            txtNombreUsuario = new TextBox();
            txtContrasenya = new TextBox();
            lblContrasenya = new Label();
            btnBorrar = new Button();
            btnEnviar = new Button();
            lklFaq = new LinkLabel();
            lklRegistro = new LinkLabel();
            errorProvider1 = new ErrorProvider(components);
            pctVerContrasenya = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctVerContrasenya).BeginInit();
            SuspendLayout();
            // 
            // lblInicioSesion
            // 
            lblInicioSesion.AutoSize = true;
            lblInicioSesion.BackColor = Color.FromArgb(211, 208, 242);
            lblInicioSesion.BorderStyle = BorderStyle.FixedSingle;
            lblInicioSesion.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInicioSesion.Location = new Point(245, 23);
            lblInicioSesion.Name = "lblInicioSesion";
            lblInicioSesion.Padding = new Padding(5);
            lblInicioSesion.Size = new Size(239, 48);
            lblInicioSesion.TabIndex = 0;
            lblInicioSesion.Text = "Inicio de Sesión";
            lblInicioSesion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNombreUsuario
            // 
            lblNombreUsuario.AutoSize = true;
            lblNombreUsuario.BackColor = SystemColors.Control;
            lblNombreUsuario.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombreUsuario.Location = new Point(71, 101);
            lblNombreUsuario.Name = "lblNombreUsuario";
            lblNombreUsuario.Padding = new Padding(5);
            lblNombreUsuario.Size = new Size(276, 42);
            lblNombreUsuario.TabIndex = 1;
            lblNombreUsuario.Text = "Nombre de Usuario:";
            lblNombreUsuario.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombreUsuario.Location = new Point(341, 105);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(289, 38);
            txtNombreUsuario.TabIndex = 1;
            // 
            // txtContrasenya
            // 
            txtContrasenya.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContrasenya.Location = new Point(341, 167);
            txtContrasenya.Name = "txtContrasenya";
            txtContrasenya.PasswordChar = '*';
            txtContrasenya.Size = new Size(289, 38);
            txtContrasenya.TabIndex = 2;
            // 
            // lblContrasenya
            // 
            lblContrasenya.AutoSize = true;
            lblContrasenya.BackColor = SystemColors.Control;
            lblContrasenya.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblContrasenya.Location = new Point(167, 164);
            lblContrasenya.Name = "lblContrasenya";
            lblContrasenya.Padding = new Padding(5);
            lblContrasenya.Size = new Size(179, 42);
            lblContrasenya.TabIndex = 3;
            lblContrasenya.Text = "Contraseña:";
            lblContrasenya.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnBorrar
            // 
            btnBorrar.BackColor = Color.FromArgb(211, 208, 242);
            btnBorrar.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBorrar.Location = new Point(501, 277);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(127, 53);
            btnBorrar.TabIndex = 4;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = false;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnEnviar
            // 
            btnEnviar.BackColor = Color.FromArgb(178, 242, 187);
            btnEnviar.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEnviar.Location = new Point(651, 277);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(127, 53);
            btnEnviar.TabIndex = 3;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = false;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // lklFaq
            // 
            lklFaq.AutoSize = true;
            lklFaq.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lklFaq.Location = new Point(11, 237);
            lklFaq.Name = "lklFaq";
            lklFaq.Size = new Size(249, 32);
            lklFaq.TabIndex = 5;
            lklFaq.TabStop = true;
            lklFaq.Text = "¿Algún Problema?";
            lklFaq.LinkClicked += lklFaq_LinkClicked;
            // 
            // lklRegistro
            // 
            lklRegistro.AutoSize = true;
            lklRegistro.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lklRegistro.Location = new Point(11, 292);
            lklRegistro.Name = "lklRegistro";
            lklRegistro.Size = new Size(274, 32);
            lklRegistro.TabIndex = 6;
            lklRegistro.TabStop = true;
            lklRegistro.Text = "¿No Tienes Cuenta?";
            lklRegistro.LinkClicked += lklRegistro_LinkClicked;
            // 
            // errorProvider1
            // 
            errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider1.ContainerControl = this;
            // 
            // pctVerContrasenya
            // 
            pctVerContrasenya.Image = Properties.Resources.ojo;
            pctVerContrasenya.Location = new Point(636, 167);
            pctVerContrasenya.Name = "pctVerContrasenya";
            pctVerContrasenya.Size = new Size(38, 39);
            pctVerContrasenya.SizeMode = PictureBoxSizeMode.StretchImage;
            pctVerContrasenya.TabIndex = 7;
            pctVerContrasenya.TabStop = false;
            pctVerContrasenya.Click += pictureBox1_Click;
            // 
            // frmInicioSesion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 353);
            Controls.Add(pctVerContrasenya);
            Controls.Add(lklRegistro);
            Controls.Add(lklFaq);
            Controls.Add(btnEnviar);
            Controls.Add(btnBorrar);
            Controls.Add(txtContrasenya);
            Controls.Add(lblContrasenya);
            Controls.Add(txtNombreUsuario);
            Controls.Add(lblNombreUsuario);
            Controls.Add(lblInicioSesion);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmInicioSesion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ge$tioni$";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctVerContrasenya).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInicioSesion;
        private Label lblNombreUsuario;
        private TextBox txtNombreUsuario;
        private TextBox txtContrasenya;
        private Label lblContrasenya;
        private Button btnBorrar;
        private Button btnEnviar;
        private LinkLabel lklFaq;
        private LinkLabel lklRegistro;
        private ErrorProvider errorProvider1;
        private PictureBox pctVerContrasenya;
    }
}
