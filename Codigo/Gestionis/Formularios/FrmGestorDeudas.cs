﻿using Gestionis.Clases;
using Gestionis.Formularios;

namespace Gestionis
{
    public partial class FrmGestorDeudas : FrmBarraPrincipal
    {
        private ToolTip toolTip; // Add a ToolTip instance

        public FrmGestorDeudas()
        {
            InitializeComponent();
            ModificarBotones();
            toolTip = new ToolTip(); // Initialize the ToolTip
        }
        private void FrmGestorDeudas_Load(object sender, EventArgs e)
        {
            #region Botones
            btnAnyadirDeuda.FlatStyle = FlatStyle.Flat;
            btnAnyadirDeuda.FlatAppearance.BorderColor = Color.Black;
            btnAnyadirDeuda.FlatAppearance.BorderSize = 2;

            btnEliminarDeuda.FlatStyle = FlatStyle.Flat;
            btnEliminarDeuda.FlatAppearance.BorderColor = Color.Black;
            btnEliminarDeuda.FlatAppearance.BorderSize = 2;

            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.FlatAppearance.BorderColor = Color.Black;
            btnBuscar.FlatAppearance.BorderSize = 2;

            btnRestaurar.FlatStyle = FlatStyle.Flat;
            btnRestaurar.FlatAppearance.BorderColor = Color.Black;
            btnRestaurar.FlatAppearance.BorderSize = 2;
            #endregion

            cmbCategoria.Items.AddRange(Deuda.Filtros());
            cmbCategoria.SelectedIndex = 0;

            SetGrafico();
            vpbDebo.ForeColor = Color.IndianRed;
            Titulo();

            //lblSaldoValor.Text = 
            lblDeudasTotalesValor.Text = Deuda.DeudasTotales().ToString();
            ProximaDeuda();

            dgvGastosIngresos.DataSource = Deuda.RecargarTabla();

            barraSecundaria.Load();
            barraLateral1.Load();
        }

        private void ModificarBotones()
        {
            barraSecundaria.BtnLanguage.Click += BtnTema_Click;
            barraSecundaria.BtnAyuda.Click += BtnTema_Click;
        }

        private void BtnTema_Click(object sender, EventArgs e)
        {

        }

        private void BtnAyuda_Click(object sender, EventArgs e) 
        {
            ShowTooltip(btnAnyadirDeuda, "Añadir una nueva deuda.");
            ShowTooltip(btnEliminarDeuda, "Eliminar una deuda existente.");
            ShowTooltip(btnBuscar, "Buscar deudas según los filtros seleccionados.");
            ShowTooltip(btnRestaurar, "Restaurar la tabla de deudas.");
            ShowTooltip(cmbCategoria, "Seleccionar una categoría de deuda.");
            ShowTooltip(txtTitulo, "Escribir el título de la deuda a buscar.");
            ShowTooltip(chkDebo, "Marcar si se deben mostrar solo las deudas que debes.");
            ShowTooltip(dgvGastosIngresos, "Tabla que muestra las deudas.");
            ShowTooltip(lblDeudasTotalesValor, "Muestra el total de deudas.");
            ShowTooltip(lblProximaDeudaValor, "Muestra la próxima deuda.");
            ShowTooltip(lblFechaLimiteValor, "Muestra la fecha límite de la próxima deuda.");
            ShowTooltip(lblTipoValor, "Indica si debes o te deben.");
            ShowTooltip(vpbDebo, "Progreso de las deudas que debes.");
            ShowTooltip(vpbMeDeben, "Progreso de las deudas que te deben.");
        }

        private void ShowTooltip(Control control, string message)
        {
            toolTip.SetToolTip(control, message);
            toolTip.Show(message, control, control.Width / 2, control.Height / 2);
        }

        private void Titulo()
        {
            if (cmbCategoria.SelectedIndex == 0)
            {
                lblTitulo.Enabled = true;
                txtTitulo.Enabled = true;
            }
            else
            {
                txtTitulo.Clear();
                lblTitulo.Enabled = false;
                txtTitulo.Enabled = false;
            }
        }
        private void ProximaDeuda()
        {
            Deuda deuda = new Deuda();
            deuda.GetProximaDeuda(deuda);

            if (deuda.Titulo != null)
            {
                lblProximaDeudaValor.Text = deuda.Titulo.ToString();
                lblFechaLimiteValor.Text = deuda.FechaVencimiento.ToShortDateString();
                if (deuda.Debo) lblTipoValor.Text = "Debo"; else lblTipoValor.Text = "Me deben";
            }
            else
            {
                lblProximaDeudaValor.Text = string.Empty;
                lblFechaLimiteValor.Text = string.Empty;
                lblTipoValor.Text = string.Empty;
            }
            SetGrafico();
        }

        private void btnAnyadirDeuda_Click(object sender, EventArgs e)
        {
            FrmAnyadirDeuda frmAnyadirDeuda = new FrmAnyadirDeuda();
            frmAnyadirDeuda.ShowDialog();
            lblDeudasTotalesValor.Text = Deuda.DeudasTotales().ToString();
            ProximaDeuda();
            dgvGastosIngresos.DataSource = Deuda.RecargarTabla(chkDebo.Checked);
        }

        private void btnEliminarDeuda_Click(object sender, EventArgs e)
        {
            FrmEliminarDeuda frmEliminarDeuda = new FrmEliminarDeuda();
            frmEliminarDeuda.ShowDialog();
            lblDeudasTotalesValor.Text = Deuda.DeudasTotales().ToString();
            ProximaDeuda();
            dgvGastosIngresos.DataSource = Deuda.RecargarTabla(chkDebo.Checked);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvGastosIngresos.DataSource = Deuda.CargarFiltro(cmbCategoria.Text, chkDebo.Checked, txtTitulo.Text);
            Titulo();
        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            Titulo();
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            dgvGastosIngresos.DataSource = Deuda.RecargarTabla();
        }

        private void chkDebo_CheckedChanged(object sender, EventArgs e)
        {
            dgvGastosIngresos.DataSource = Deuda.RecargarTabla(chkDebo.Checked);
        }

        private void SetGrafico()
        {
            double debo = Deuda.CalcularTotalDeuda(true), meDeben = Deuda.CalcularTotalDeuda(false);

            int valorMax = Utilidades.ProgramarGrafico(debo, meDeben);
            vpbDebo.Maximum = valorMax;
            vpbMeDeben.Maximum = valorMax;

            vpbDebo.Value = (int)debo;
            vpbMeDeben.Value = (int)meDeben;
        }
    }
}
