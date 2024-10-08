﻿namespace Gestionis
{
    partial class frmHistorial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHistorial));
            lblHistorial = new Label();
            dgvIngresos = new DataGridView();
            lblFecha = new Label();
            txtBuscar = new TextBox();
            picBuscar = new PictureBox();
            lblBuscar = new Label();
            lblMetodo = new Label();
            cmbMetodo = new ComboBox();
            dtpBuscaFecha = new DateTimePicker();
            lblBuscaFecha = new Label();
            picBuscaFecha = new PictureBox();
            barraSecundaria1 = new Herramientas.BarraSecundaria();
            barraLateral1 = new Herramientas.BarraLateral();
            lblIngresos = new Label();
            dgvGastos = new DataGridView();
            lblGastos = new Label();
            btnSalir = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dgvIngresos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBuscar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBuscaFecha).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvGastos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblHistorial
            // 
            lblHistorial.AutoSize = true;
            lblHistorial.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHistorial.Location = new Point(310, 93);
            lblHistorial.Name = "lblHistorial";
            lblHistorial.Size = new Size(165, 46);
            lblHistorial.TabIndex = 1;
            lblHistorial.Text = "Historial";
            // 
            // dgvIngresos
            // 
            dgvIngresos.AllowUserToAddRows = false;
            dgvIngresos.AllowUserToDeleteRows = false;
            dgvIngresos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvIngresos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvIngresos.Location = new Point(322, 233);
            dgvIngresos.Name = "dgvIngresos";
            dgvIngresos.ReadOnly = true;
            dgvIngresos.RowHeadersWidth = 51;
            dgvIngresos.Size = new Size(1018, 350);
            dgvIngresos.TabIndex = 17;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFecha.Location = new Point(322, 160);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(58, 29);
            lblFecha.TabIndex = 18;
            lblFecha.Text = "Hoy";
            lblFecha.Visible = false;
            // 
            // txtBuscar
            // 
            txtBuscar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscar.Location = new Point(1346, 307);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(181, 30);
            txtBuscar.TabIndex = 19;
            // 
            // picBuscar
            // 
            picBuscar.Image = Properties.Resources.lupa;
            picBuscar.Location = new Point(1533, 307);
            picBuscar.Name = "picBuscar";
            picBuscar.Size = new Size(34, 38);
            picBuscar.SizeMode = PictureBoxSizeMode.StretchImage;
            picBuscar.TabIndex = 9;
            picBuscar.TabStop = false;
            picBuscar.Click += picBuscar_Click;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBuscar.Location = new Point(1346, 274);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(101, 25);
            lblBuscar.TabIndex = 20;
            lblBuscar.Text = "Buscador:";
            // 
            // lblMetodo
            // 
            lblMetodo.AutoSize = true;
            lblMetodo.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMetodo.Location = new Point(1346, 348);
            lblMetodo.Name = "lblMetodo";
            lblMetodo.Size = new Size(84, 25);
            lblMetodo.TabIndex = 21;
            lblMetodo.Text = "Metodo:";
            // 
            // cmbMetodo
            // 
            cmbMetodo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMetodo.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbMetodo.FormattingEnabled = true;
            cmbMetodo.Location = new Point(1346, 380);
            cmbMetodo.Name = "cmbMetodo";
            cmbMetodo.Size = new Size(181, 33);
            cmbMetodo.TabIndex = 22;
            // 
            // dtpBuscaFecha
            // 
            dtpBuscaFecha.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpBuscaFecha.Format = DateTimePickerFormat.Short;
            dtpBuscaFecha.Location = new Point(1346, 233);
            dtpBuscaFecha.Name = "dtpBuscaFecha";
            dtpBuscaFecha.Size = new Size(180, 30);
            dtpBuscaFecha.TabIndex = 23;
            // 
            // lblBuscaFecha
            // 
            lblBuscaFecha.AutoSize = true;
            lblBuscaFecha.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBuscaFecha.Location = new Point(1346, 201);
            lblBuscaFecha.Name = "lblBuscaFecha";
            lblBuscaFecha.Size = new Size(194, 25);
            lblBuscaFecha.TabIndex = 24;
            lblBuscaFecha.Text = "Buscador por Fecha:";
            // 
            // picBuscaFecha
            // 
            picBuscaFecha.Image = Properties.Resources.lupa;
            picBuscaFecha.Location = new Point(1533, 233);
            picBuscaFecha.Name = "picBuscaFecha";
            picBuscaFecha.Size = new Size(34, 38);
            picBuscaFecha.SizeMode = PictureBoxSizeMode.StretchImage;
            picBuscaFecha.TabIndex = 25;
            picBuscaFecha.TabStop = false;
            picBuscaFecha.Click += picBuscaFecha_Click;
            // 
            // barraSecundaria1
            // 
            barraSecundaria1.BackColor = Color.FromArgb(211, 208, 242);
            barraSecundaria1.Dock = DockStyle.Top;
            barraSecundaria1.Location = new Point(0, 40);
            barraSecundaria1.Name = "barraSecundaria1";
            barraSecundaria1.Size = new Size(1759, 49);
            barraSecundaria1.TabIndex = 26;
            // 
            // barraLateral1
            // 
            barraLateral1.BackColor = Color.FromArgb(205, 213, 221);
            barraLateral1.Dock = DockStyle.Left;
            barraLateral1.Location = new Point(0, 89);
            barraLateral1.Name = "barraLateral1";
            barraLateral1.Size = new Size(249, 929);
            barraLateral1.TabIndex = 27;
            // 
            // lblIngresos
            // 
            lblIngresos.AutoSize = true;
            lblIngresos.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblIngresos.Location = new Point(322, 202);
            lblIngresos.Name = "lblIngresos";
            lblIngresos.Size = new Size(93, 25);
            lblIngresos.TabIndex = 29;
            lblIngresos.Text = "Ingresos:";
            // 
            // dgvGastos
            // 
            dgvGastos.AllowUserToAddRows = false;
            dgvGastos.AllowUserToDeleteRows = false;
            dgvGastos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGastos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGastos.Location = new Point(322, 638);
            dgvGastos.Name = "dgvGastos";
            dgvGastos.ReadOnly = true;
            dgvGastos.RowHeadersWidth = 51;
            dgvGastos.Size = new Size(1018, 353);
            dgvGastos.TabIndex = 30;
            // 
            // lblGastos
            // 
            lblGastos.AutoSize = true;
            lblGastos.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGastos.Location = new Point(322, 607);
            lblGastos.Name = "lblGastos";
            lblGastos.Size = new Size(80, 25);
            lblGastos.TabIndex = 31;
            lblGastos.Text = "Gastos:";
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.FromArgb(170, 166, 202);
            btnSalir.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalir.Location = new Point(1452, 947);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(124, 44);
            btnSalir.TabIndex = 32;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmHistorial
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1759, 1018);
            Controls.Add(btnSalir);
            Controls.Add(lblGastos);
            Controls.Add(dgvGastos);
            Controls.Add(lblIngresos);
            Controls.Add(barraLateral1);
            Controls.Add(barraSecundaria1);
            Controls.Add(picBuscaFecha);
            Controls.Add(lblBuscaFecha);
            Controls.Add(dtpBuscaFecha);
            Controls.Add(cmbMetodo);
            Controls.Add(lblMetodo);
            Controls.Add(lblBuscar);
            Controls.Add(picBuscar);
            Controls.Add(txtBuscar);
            Controls.Add(lblFecha);
            Controls.Add(dgvIngresos);
            Controls.Add(lblHistorial);
            Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmHistorial";
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;
            Load += frmHistorial_Load;
            Controls.SetChildIndex(lblHistorial, 0);
            Controls.SetChildIndex(dgvIngresos, 0);
            Controls.SetChildIndex(lblFecha, 0);
            Controls.SetChildIndex(txtBuscar, 0);
            Controls.SetChildIndex(picBuscar, 0);
            Controls.SetChildIndex(lblBuscar, 0);
            Controls.SetChildIndex(lblMetodo, 0);
            Controls.SetChildIndex(cmbMetodo, 0);
            Controls.SetChildIndex(dtpBuscaFecha, 0);
            Controls.SetChildIndex(lblBuscaFecha, 0);
            Controls.SetChildIndex(picBuscaFecha, 0);
            Controls.SetChildIndex(barraSecundaria1, 0);
            Controls.SetChildIndex(barraLateral1, 0);
            Controls.SetChildIndex(lblIngresos, 0);
            Controls.SetChildIndex(dgvGastos, 0);
            Controls.SetChildIndex(lblGastos, 0);
            Controls.SetChildIndex(btnSalir, 0);
            ((System.ComponentModel.ISupportInitialize)dgvIngresos).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBuscar).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBuscaFecha).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvGastos).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblHistorial;
        private DataGridView dgvIngresos;
        private Label lblFecha;
        private TextBox txtBuscar;
        private PictureBox picBuscar;
        private Label lblBuscar;
        private Label lblMetodo;
        private ComboBox cmbMetodo;
        private DateTimePicker dtpBuscaFecha;
        private Label lblBuscaFecha;
        private PictureBox picBuscaFecha;
        private Herramientas.BarraSecundaria barraSecundaria1;
        private Herramientas.BarraLateral barraLateral1;
        private Label lblIngresos;
        private DataGridView dgvGastos;
        private Label lblGastos;
        private Button btnSalir;
        private ErrorProvider errorProvider1;
    }
}