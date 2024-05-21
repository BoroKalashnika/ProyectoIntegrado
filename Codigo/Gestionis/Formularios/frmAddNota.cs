﻿using Gestionis.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Outlook = Microsoft.Office.Interop.Outlook;

namespace Gestionis
{
    public partial class frmAddNota : Form
    {
        public frmAddNota()
        {
            InitializeComponent();
        }

        #region Validaciones
        private bool ValidarDatos()
        {
            bool ok = true;
            errorProvider1.Clear();

            if (txtAddTitulo.Text == String.Empty)
            {
                ok = false;
                errorProvider1.SetError(txtAddTitulo, "Introduce un título");
            }

            if (txtAddAsunto.Text == String.Empty)
            {
                ok = false;
                errorProvider1.SetError(txtAddAsunto, "Introduce un asunto");
            }
            //if (btnColor.BackColor == Color.Empty)
            //{
            //    ok = false;
            //    errorProvider1.SetError(btnColor, "Seleccione un color");
            //}
            return ok;
        }
        #endregion


        private void frmAddNota_Load(object sender, EventArgs e)
        {
            dtpAddDia.Value = DateTime.Today;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            RestablecerControlesVisuales();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAnotar_Click(object sender, EventArgs e)
        {
            if (!ValidarDatos())
            {
                MessageBox.Show("Revisa los datos introducidos", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Notas nota1 = new Notas(txtAddTitulo.Text, txtAddAsunto.Text, dtpAddDia.Value, ckbAlarma.Checked, btnColor.BackColor.ToArgb());
                nota1.Add();
                if (ckbAlarma.Checked)
                {
                    DateTime fecha = dtpAddDia.Value.Date;
                    DateTime hora = dtpHoraAlarma.Value;
                    DateTime fechaHora = new DateTime(fecha.Year, fecha.Month, fecha.Day, hora.Hour, hora.Minute, hora.Second);

                    nota1.AgregarNotaAlCalendario(fechaHora);
                }
                this.Close();
            }
            catch
            {
                MessageBox.Show("No se ha podido conectar con la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.btnColor.BackColor = colorDialog1.Color;
            }
        }

        #region Metodos de Implementacion
        private void RestablecerControlesVisuales()
        {
            txtAddTitulo.Text = String.Empty;
            txtAddAsunto.Text = String.Empty;
            btnColor.BackColor = Color.Empty;
            ckbAlarma.Checked = false;
            dtpAddDia.Value = DateTime.Today;
        }

        #endregion

        private void ckbAlarma_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbAlarma.Checked) { dtpHoraAlarma.Visible = true; } else { dtpHoraAlarma.Visible = false; }
        }
    }
}
