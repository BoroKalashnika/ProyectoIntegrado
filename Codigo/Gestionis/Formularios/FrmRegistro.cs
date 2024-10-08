﻿using Gestionis.Clases;
using System.Diagnostics;

namespace Gestionis
{
    public partial class frmRegistro : Form
    {
        public frmRegistro()
        {
            InitializeComponent();
        }

        #region Validaciones
        private bool ValidaDatos()
        {
            bool ok = true;
            errorProvider1.Clear();

            if (txtApodo.Text == String.Empty)
            {
                ok = false;
                errorProvider1.SetError(txtApodo, "Introduce un apodo");
            }

            if (Utilidades.TieneEspacios(txtApodo.Text))
            {
                ok = false;
                errorProvider1.SetError(txtApodo, "El nombre no puede contener espacios");
            }

            if (txtCorreo.Text == String.Empty)
            {
                ok = false;
                errorProvider1.SetError(txtCorreo, "Introduce un correo");
            }

            if (txtNombre.Text == String.Empty)
            {
                ok = false;
                errorProvider1.SetError(txtNombre, "Introduce un nombre");
            }

            if (txtContrasenya.Text.Length < 8)
            {
                ok = false;
                errorProvider1.SetError(pctVerContrasenya, "La contraseña tiene que tener como mínimo 8 carácteres");
            }

            if (txtTelefono.Text != String.Empty)
            {
                if (!int.TryParse(txtTelefono.Text, out int tlfNumerico))
                {
                    ok = false;
                    errorProvider1.SetError(txtTelefono, "Solo se admiten números en el teléfono");
                }
            }

            return ok;
        }
        #endregion

        private void lklFaq_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Process.Start(new ProcessStartInfo("https://borokalashnika.github.io/GestionisWeb/Preguntas.html") { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo abrir el enlace. Error: " + ex.Message);
            }
        }

        private void lklInicioSesion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmInicioSesion fIS = new frmInicioSesion();
            fIS.Closed += (s, args) => this.Close();
            fIS.Show();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            RestablecerControlesVisuales();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (!ValidaDatos())
            {
                MessageBox.Show("Revisa los datos introducidos", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                if (Usuario.Existe(txtApodo.Text))
                {
                    MessageBox.Show("Ya existe un usuario con ese apodo", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (Usuario.CorreoExiste(txtCorreo.Text))
                {
                    MessageBox.Show("Ya existe un usuario con ese correo", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                CreaUsuario();
                CreaCuenta(txtApodo.Text);
                CreaLimites();

                lklInicioSesion_LinkClicked(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ConexionDB.CerrarConexion();
            }
        }

        private void pctVerContrasenya_Click(object sender, EventArgs e)
        {
            if (txtContrasenya.PasswordChar == '*')
            {
                txtContrasenya.PasswordChar = '\0';
            }
            else
            {
                txtContrasenya.PasswordChar = '*';
            }
        }

        #region Metodos de implementacion
        private void RestablecerControlesVisuales()
        {
            txtApodo.Text = String.Empty;
            txtCorreo.Text = String.Empty;
            txtNombre.Text = String.Empty;
            txtApellidos.Text = String.Empty;
            txtContrasenya.Text = String.Empty;
            txtDireccion.Text = String.Empty;
            txtTelefono.Text = String.Empty;
        }

        private void CreaUsuario()
        {
            Usuario usu1 = new Usuario(
                    txtApodo.Text.ToLower(),
                    txtNombre.Text,
                    txtApellidos.Text == String.Empty ? null : txtApellidos.Text,
                    txtCorreo.Text,
                    txtContrasenya.Text,
                    txtDireccion.Text == String.Empty ? null : txtDireccion.Text,
                    txtTelefono.Text == String.Empty ? null : txtTelefono.Text
                    );

            usu1.Add();
        }

        private void CreaCuenta(string apodo)
        {
            Cuenta cue1 = new Cuenta(
                apodo);

            cue1.Add();
        }

        private void CreaLimites()
        {
            int numCuenta = Cuenta.IDCuentaUsuario(txtApodo.Text);
            for (int i = 1; i < 6; i++)
            {
                LimitesNotif lim = new LimitesNotif(
                    numCuenta,
                    i,
                    150
                );
                lim.Add();
            }
        }
        #endregion        
    }
}
