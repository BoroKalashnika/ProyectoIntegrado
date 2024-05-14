﻿namespace Gestionis
{
    partial class FrmMenuPrincipal
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            pnlBarra = new Panel();
            pbSpain = new PictureBox();
            pbAyuda = new PictureBox();
            pbUsuario = new PictureBox();
            pbNotificaciones = new PictureBox();
            pbNoticias = new PictureBox();
            pbTema = new PictureBox();
            pbEnglish = new PictureBox();
            pbHamburger = new PictureBox();
            rgbMenu = new RoundGroupBox();
            lblTotalValor = new Label();
            lblGastosValor = new Label();
            lblIngresosValor = new Label();
            lblTotal = new Label();
            lblGastos = new Label();
            lblIngresos = new Label();
            cmbCategoria = new ComboBox();
            cmbDinero = new ComboBox();
            cmbTipo = new ComboBox();
            txtNombre = new TextBox();
            dgvGastosIngresos = new DataGridView();
            btnGasto = new Button();
            btnIngreso = new Button();
            lblLinea = new Label();
            lblLinea2 = new Label();
            lblLinea3 = new Label();
            rgbCalendario = new RoundGroupBox();
            lblAdelante = new Label();
            lblAtras = new Label();
            lblMes = new Label();
            label3 = new Label();
            btnSalir = new Button();
            pnlNotas = new Panel();
            lblNotasValor = new Label();
            lblNotas = new Label();
            pnlBarra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbSpain).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbAyuda).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbUsuario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbNotificaciones).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbNoticias).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbTema).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbEnglish).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbHamburger).BeginInit();
            rgbMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGastosIngresos).BeginInit();
            rgbCalendario.SuspendLayout();
            pnlNotas.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(0, 43);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(254, 661);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // pnlBarra
            // 
            pnlBarra.BackColor = Color.FromArgb(211, 208, 242);
            pnlBarra.Controls.Add(pbSpain);
            pnlBarra.Controls.Add(pbAyuda);
            pnlBarra.Controls.Add(pbUsuario);
            pnlBarra.Controls.Add(pbNotificaciones);
            pnlBarra.Controls.Add(pbNoticias);
            pnlBarra.Controls.Add(pbTema);
            pnlBarra.Controls.Add(pbEnglish);
            pnlBarra.Controls.Add(pbHamburger);
            pnlBarra.Dock = DockStyle.Top;
            pnlBarra.Location = new Point(0, 0);
            pnlBarra.Name = "pnlBarra";
            pnlBarra.Size = new Size(1478, 41);
            pnlBarra.TabIndex = 2;
            pnlBarra.Paint += pnlBarra_Paint;
            // 
            // pbSpain
            // 
            pbSpain.Enabled = false;
            pbSpain.Location = new Point(91, 6);
            pbSpain.Margin = new Padding(3, 4, 3, 4);
            pbSpain.Name = "pbSpain";
            pbSpain.Size = new Size(33, 31);
            pbSpain.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSpain.TabIndex = 24;
            pbSpain.TabStop = false;
            pbSpain.Click += pbSpain_Click;
            // 
            // pbAyuda
            // 
            pbAyuda.Location = new Point(49, 5);
            pbAyuda.Margin = new Padding(3, 4, 3, 4);
            pbAyuda.Name = "pbAyuda";
            pbAyuda.Size = new Size(31, 30);
            pbAyuda.SizeMode = PictureBoxSizeMode.StretchImage;
            pbAyuda.TabIndex = 18;
            pbAyuda.TabStop = false;
            // 
            // pbUsuario
            // 
            pbUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pbUsuario.Location = new Point(1435, 5);
            pbUsuario.Margin = new Padding(3, 4, 3, 4);
            pbUsuario.Name = "pbUsuario";
            pbUsuario.Size = new Size(27, 31);
            pbUsuario.SizeMode = PictureBoxSizeMode.StretchImage;
            pbUsuario.TabIndex = 23;
            pbUsuario.TabStop = false;
            // 
            // pbNotificaciones
            // 
            pbNotificaciones.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pbNotificaciones.Location = new Point(1401, 5);
            pbNotificaciones.Margin = new Padding(3, 4, 3, 4);
            pbNotificaciones.Name = "pbNotificaciones";
            pbNotificaciones.Size = new Size(27, 31);
            pbNotificaciones.SizeMode = PictureBoxSizeMode.StretchImage;
            pbNotificaciones.TabIndex = 22;
            pbNotificaciones.TabStop = false;
            // 
            // pbNoticias
            // 
            pbNoticias.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pbNoticias.Location = new Point(1363, 5);
            pbNoticias.Margin = new Padding(3, 4, 3, 4);
            pbNoticias.Name = "pbNoticias";
            pbNoticias.Size = new Size(31, 31);
            pbNoticias.SizeMode = PictureBoxSizeMode.StretchImage;
            pbNoticias.TabIndex = 21;
            pbNoticias.TabStop = false;
            // 
            // pbTema
            // 
            pbTema.Location = new Point(135, 5);
            pbTema.Margin = new Padding(3, 4, 3, 4);
            pbTema.Name = "pbTema";
            pbTema.Size = new Size(32, 31);
            pbTema.SizeMode = PictureBoxSizeMode.StretchImage;
            pbTema.TabIndex = 20;
            pbTema.TabStop = false;
            // 
            // pbEnglish
            // 
            pbEnglish.Location = new Point(94, 5);
            pbEnglish.Margin = new Padding(3, 4, 3, 4);
            pbEnglish.Name = "pbEnglish";
            pbEnglish.Size = new Size(30, 31);
            pbEnglish.SizeMode = PictureBoxSizeMode.CenterImage;
            pbEnglish.TabIndex = 19;
            pbEnglish.TabStop = false;
            pbEnglish.Click += pbEnglish_Click;
            // 
            // pbHamburger
            // 
            pbHamburger.Location = new Point(12, 5);
            pbHamburger.Margin = new Padding(3, 4, 3, 4);
            pbHamburger.Name = "pbHamburger";
            pbHamburger.Size = new Size(31, 31);
            pbHamburger.SizeMode = PictureBoxSizeMode.StretchImage;
            pbHamburger.TabIndex = 17;
            pbHamburger.TabStop = false;
            pbHamburger.Click += pbHamburger_Click;
            // 
            // rgbMenu
            // 
            rgbMenu.AutoSize = true;
            rgbMenu.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            rgbMenu.BackColor = Color.Transparent;
            rgbMenu.Controls.Add(lblTotalValor);
            rgbMenu.Controls.Add(lblGastosValor);
            rgbMenu.Controls.Add(lblIngresosValor);
            rgbMenu.Controls.Add(lblTotal);
            rgbMenu.Controls.Add(lblGastos);
            rgbMenu.Controls.Add(lblIngresos);
            rgbMenu.Controls.Add(cmbCategoria);
            rgbMenu.Controls.Add(cmbDinero);
            rgbMenu.Controls.Add(cmbTipo);
            rgbMenu.Controls.Add(txtNombre);
            rgbMenu.Controls.Add(dgvGastosIngresos);
            rgbMenu.Controls.Add(btnGasto);
            rgbMenu.Controls.Add(btnIngreso);
            rgbMenu.Controls.Add(lblLinea);
            rgbMenu.Controls.Add(lblLinea2);
            rgbMenu.Controls.Add(lblLinea3);
            rgbMenu.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rgbMenu.ForeColor = SystemColors.ControlText;
            rgbMenu.Location = new Point(308, 96);
            rgbMenu.Name = "rgbMenu";
            rgbMenu.Size = new Size(696, 618);
            rgbMenu.TabIndex = 3;
            rgbMenu.TabStop = false;
            // 
            // lblTotalValor
            // 
            lblTotalValor.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTotalValor.AutoSize = true;
            lblTotalValor.Location = new Point(551, 148);
            lblTotalValor.Name = "lblTotalValor";
            lblTotalValor.Size = new Size(108, 32);
            lblTotalValor.TabIndex = 12;
            lblTotalValor.Text = "Ingresos:";
            // 
            // lblGastosValor
            // 
            lblGastosValor.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblGastosValor.AutoSize = true;
            lblGastosValor.Location = new Point(551, 99);
            lblGastosValor.Name = "lblGastosValor";
            lblGastosValor.Size = new Size(108, 32);
            lblGastosValor.TabIndex = 11;
            lblGastosValor.Text = "Ingresos:";
            // 
            // lblIngresosValor
            // 
            lblIngresosValor.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblIngresosValor.AutoSize = true;
            lblIngresosValor.Location = new Point(551, 51);
            lblIngresosValor.Name = "lblIngresosValor";
            lblIngresosValor.Size = new Size(108, 32);
            lblIngresosValor.TabIndex = 10;
            lblIngresosValor.Text = "Ingresos:";
            // 
            // lblTotal
            // 
            lblTotal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(446, 148);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(70, 32);
            lblTotal.TabIndex = 9;
            lblTotal.Text = "Total:";
            // 
            // lblGastos
            // 
            lblGastos.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblGastos.AutoSize = true;
            lblGastos.Location = new Point(446, 99);
            lblGastos.Name = "lblGastos";
            lblGastos.Size = new Size(89, 32);
            lblGastos.TabIndex = 8;
            lblGastos.Text = "Gastos:";
            // 
            // lblIngresos
            // 
            lblIngresos.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblIngresos.AutoSize = true;
            lblIngresos.Location = new Point(446, 51);
            lblIngresos.Name = "lblIngresos";
            lblIngresos.Size = new Size(108, 32);
            lblIngresos.TabIndex = 7;
            lblIngresos.Text = "Ingresos:";
            // 
            // cmbCategoria
            // 
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(499, 229);
            cmbCategoria.Margin = new Padding(3, 4, 3, 4);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(146, 40);
            cmbCategoria.TabIndex = 6;
            // 
            // cmbDinero
            // 
            cmbDinero.FormattingEnabled = true;
            cmbDinero.Location = new Point(376, 229);
            cmbDinero.Margin = new Padding(3, 4, 3, 4);
            cmbDinero.Name = "cmbDinero";
            cmbDinero.Size = new Size(105, 40);
            cmbDinero.TabIndex = 5;
            // 
            // cmbTipo
            // 
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Location = new Point(287, 229);
            cmbTipo.Margin = new Padding(3, 4, 3, 4);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(71, 40);
            cmbTipo.TabIndex = 4;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(47, 229);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(226, 39);
            txtNombre.TabIndex = 3;
            // 
            // dgvGastosIngresos
            // 
            dgvGastosIngresos.BackgroundColor = SystemColors.ControlLightLight;
            dgvGastosIngresos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGastosIngresos.GridColor = SystemColors.Window;
            dgvGastosIngresos.Location = new Point(47, 300);
            dgvGastosIngresos.Margin = new Padding(3, 4, 3, 4);
            dgvGastosIngresos.Name = "dgvGastosIngresos";
            dgvGastosIngresos.RowHeadersWidth = 51;
            dgvGastosIngresos.Size = new Size(599, 279);
            dgvGastosIngresos.TabIndex = 2;
            // 
            // btnGasto
            // 
            btnGasto.BackColor = Color.FromArgb(178, 242, 187);
            btnGasto.Location = new Point(61, 121);
            btnGasto.Margin = new Padding(3, 4, 3, 4);
            btnGasto.Name = "btnGasto";
            btnGasto.Size = new Size(183, 60);
            btnGasto.TabIndex = 1;
            btnGasto.Text = "Nuevo Gasto";
            btnGasto.UseVisualStyleBackColor = false;
            btnGasto.Click += btnGasto_Click;
            // 
            // btnIngreso
            // 
            btnIngreso.BackColor = Color.FromArgb(178, 242, 187);
            btnIngreso.Location = new Point(61, 51);
            btnIngreso.Margin = new Padding(3, 4, 3, 4);
            btnIngreso.Name = "btnIngreso";
            btnIngreso.Size = new Size(183, 60);
            btnIngreso.TabIndex = 0;
            btnIngreso.Text = "Nuevo Ingreso";
            btnIngreso.UseVisualStyleBackColor = false;
            btnIngreso.Click += btnIngreso_Click;
            // 
            // lblLinea
            // 
            lblLinea.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblLinea.AutoSize = true;
            lblLinea.Location = new Point(443, 56);
            lblLinea.Name = "lblLinea";
            lblLinea.Size = new Size(214, 32);
            lblLinea.TabIndex = 0;
            lblLinea.Text = "____________________";
            // 
            // lblLinea2
            // 
            lblLinea2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblLinea2.AutoSize = true;
            lblLinea2.Location = new Point(446, 104);
            lblLinea2.Name = "lblLinea2";
            lblLinea2.Size = new Size(214, 32);
            lblLinea2.TabIndex = 14;
            lblLinea2.Text = "____________________";
            // 
            // lblLinea3
            // 
            lblLinea3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblLinea3.AutoSize = true;
            lblLinea3.Location = new Point(445, 152);
            lblLinea3.Name = "lblLinea3";
            lblLinea3.Size = new Size(214, 32);
            lblLinea3.TabIndex = 13;
            lblLinea3.Text = "____________________";
            // 
            // rgbCalendario
            // 
            rgbCalendario.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            rgbCalendario.Controls.Add(lblAdelante);
            rgbCalendario.Controls.Add(lblAtras);
            rgbCalendario.Controls.Add(lblMes);
            rgbCalendario.Controls.Add(label3);
            rgbCalendario.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rgbCalendario.Location = new Point(1165, 115);
            rgbCalendario.Margin = new Padding(3, 4, 3, 4);
            rgbCalendario.Name = "rgbCalendario";
            rgbCalendario.Padding = new Padding(3, 4, 3, 4);
            rgbCalendario.Size = new Size(227, 137);
            rgbCalendario.TabIndex = 4;
            rgbCalendario.TabStop = false;
            // 
            // lblAdelante
            // 
            lblAdelante.AutoSize = true;
            lblAdelante.BackColor = Color.Transparent;
            lblAdelante.Location = new Point(153, 3);
            lblAdelante.Name = "lblAdelante";
            lblAdelante.Size = new Size(30, 32);
            lblAdelante.TabIndex = 3;
            lblAdelante.Text = ">";
            // 
            // lblAtras
            // 
            lblAtras.AutoSize = true;
            lblAtras.BackColor = Color.Transparent;
            lblAtras.Location = new Point(47, 3);
            lblAtras.Name = "lblAtras";
            lblAtras.Size = new Size(30, 32);
            lblAtras.TabIndex = 2;
            lblAtras.Text = "<";
            // 
            // lblMes
            // 
            lblMes.AutoSize = true;
            lblMes.BackColor = Color.Transparent;
            lblMes.Location = new Point(86, 3);
            lblMes.Name = "lblMes";
            lblMes.Size = new Size(59, 32);
            lblMes.TabIndex = 1;
            lblMes.Text = "Mes";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(-5, 8);
            label3.Name = "label3";
            label3.Size = new Size(264, 32);
            label3.TabIndex = 0;
            label3.Text = "_________________________";
            // 
            // btnSalir
            // 
            btnSalir.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSalir.BackColor = Color.FromArgb(178, 242, 187);
            btnSalir.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalir.Location = new Point(1265, 620);
            btnSalir.Margin = new Padding(3, 4, 3, 4);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(174, 60);
            btnSalir.TabIndex = 15;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // pnlNotas
            // 
            pnlNotas.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pnlNotas.BackColor = Color.FromArgb(205, 213, 221);
            pnlNotas.Controls.Add(lblNotasValor);
            pnlNotas.Controls.Add(lblNotas);
            pnlNotas.Location = new Point(1125, 315);
            pnlNotas.Margin = new Padding(3, 4, 3, 4);
            pnlNotas.Name = "pnlNotas";
            pnlNotas.Size = new Size(314, 241);
            pnlNotas.TabIndex = 16;
            // 
            // lblNotasValor
            // 
            lblNotasValor.AutoSize = true;
            lblNotasValor.BackColor = Color.Transparent;
            lblNotasValor.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNotasValor.Location = new Point(3, 52);
            lblNotasValor.Name = "lblNotasValor";
            lblNotasValor.Size = new Size(155, 32);
            lblNotasValor.TabIndex = 5;
            lblNotasValor.Text = "Notas del día";
            // 
            // lblNotas
            // 
            lblNotas.AutoSize = true;
            lblNotas.BackColor = Color.Transparent;
            lblNotas.Font = new Font("Segoe UI", 14.25F, FontStyle.Underline, GraphicsUnit.Point, 0);
            lblNotas.Location = new Point(3, 1);
            lblNotas.Name = "lblNotas";
            lblNotas.Size = new Size(155, 32);
            lblNotas.TabIndex = 4;
            lblNotas.Text = "Notas del día";
            // 
            // FrmMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(233, 236, 239);
            ClientSize = new Size(1478, 730);
            Controls.Add(pnlNotas);
            Controls.Add(btnSalir);
            Controls.Add(rgbCalendario);
            Controls.Add(rgbMenu);
            Controls.Add(pnlBarra);
            Controls.Add(flowLayoutPanel1);
            Name = "FrmMenuPrincipal";
            Text = "Gestionis";
            Load += FrmMenuPrincipal_Load;
            pnlBarra.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbSpain).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbAyuda).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbUsuario).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbNotificaciones).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbNoticias).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbTema).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbEnglish).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbHamburger).EndInit();
            rgbMenu.ResumeLayout(false);
            rgbMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGastosIngresos).EndInit();
            rgbCalendario.ResumeLayout(false);
            rgbCalendario.PerformLayout();
            pnlNotas.ResumeLayout(false);
            pnlNotas.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel pnlBarra;
        private RoundGroupBox rgbMenu;
        private Button btnGasto;
        private Button btnIngreso;
        private DataGridView dgvGastosIngresos;
        private Label lblTotalValor;
        private Label lblGastosValor;
        private Label lblIngresosValor;
        private Label lblTotal;
        private Label lblGastos;
        private Label lblIngresos;
        private ComboBox cmbCategoria;
        private ComboBox cmbDinero;
        private ComboBox cmbTipo;
        private TextBox txtNombre;
        private RoundGroupBox rgbCalendario;
        private Label lblLinea;
        private Label lblLinea2;
        private Label lblLinea3;
        private Label label3;
        private Button btnSalir;
        private Panel pnlNotas;
        private PictureBox pbHamburger;
        private PictureBox pbUsuario;
        private PictureBox pbNotificaciones;
        private PictureBox pbNoticias;
        private PictureBox pbTema;
        private PictureBox pbEnglish;
        private PictureBox pbAyuda;
        private Label lblAdelante;
        private Label lblAtras;
        private Label lblMes;
        private Label lblNotas;
        private Label lblNotasValor;
        private PictureBox pbSpain;
    }
}