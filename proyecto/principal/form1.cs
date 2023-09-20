using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto.principal
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal) this.WindowState = FormWindowState.Maximized;
            else this.WindowState = FormWindowState.Normal;
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void form1_Load(object sender, EventArgs e)
        {
            txtSexo.SelectedIndex = 0;
            btnGuardar.Enabled = false;
        }

        private void txtPrimerNombre_Enter(object sender, EventArgs e)
        {
            if (txtPrimerNombre.Text == "Primer nombre") txtPrimerNombre.Text = "";
        }

        private void txtPrimerNombre_Leave(object sender, EventArgs e)
        {
            if (txtPrimerNombre.Text == "") txtPrimerNombre.Text = "Primer Nombre";
        }

        private void txtSegundoNombre_Enter(object sender, EventArgs e)
        {
            if (txtSegundoNombre.Text == "Segundo nombre") txtSegundoNombre.Text = "";
        }

        private void txtSegundoNombre_Leave(object sender, EventArgs e)
        {
            if (txtSegundoNombre.Text == "") txtSegundoNombre.Text = "Segundo nombre";
        }

        private void txtDni_Enter(object sender, EventArgs e)
        {
            if (txtDni.Text == "DNI") txtDni.Text = "";
        }

        private void txtDni_Leave(object sender, EventArgs e)
        {
            if (txtDni.Text == "") txtDni.Text = "DNI";
        }

        private void txtNivel_Enter(object sender, EventArgs e)
        {
            if (txtNivel.Text == "Nivel") txtNivel.Text = "";
        }

        private void txtNivel_Leave(object sender, EventArgs e)
        {
            if (txtNivel.Text == "") txtNivel.Text = "Nivel";
        }

        private void txtPrimerApellido_Enter(object sender, EventArgs e)
        {
            if (txtPrimerApellido.Text == "Primer Apellido") txtPrimerApellido.Text = "";
        }

        private void txtPrimerApellido_Leave(object sender, EventArgs e)
        {
            if (txtPrimerApellido.Text == "") txtPrimerApellido.Text = "Primer Apellido";
        }

        private void txtSegundoApellido_Enter(object sender, EventArgs e)
        {
            if (txtSegundoApellido.Text == "Segundo Apellido") txtSegundoApellido.Text = "";
        }

        private void txtSegundoApellido_Leave(object sender, EventArgs e)
        {
            if (txtSegundoApellido.Text == "") txtSegundoApellido.Text = "Segundo Apellido";
        }

        private void txtGrado_Enter(object sender, EventArgs e)
        {
            if (txtGrado.Text == "Grado") txtGrado.Text = "";
        }

        private void txtGrado_Leave(object sender, EventArgs e)
        {
            if (txtGrado.Text == "") txtGrado.Text = "Grado";
        }

        private void txtTelefono_Enter(object sender, EventArgs e)
        {
            if (txtTelefono.Text == "Teléfono") txtTelefono.Text = "";
        }

        private void txtTelefono_Leave(object sender, EventArgs e)
        {
            if (txtTelefono.Text == "") txtTelefono.Text = "Teléfono";
        }

        private void txtDireccion_Enter(object sender, EventArgs e)
        {
            if (txtDireccion.Text == "Dirección") txtDireccion.Text = "";
        }

        private void txtDireccion_Leave(object sender, EventArgs e)
        {
            if (txtDireccion.Text == "Nivel") txtDireccion.Text = "Dirección";
        }

        private void txtObservaciones_Enter(object sender, EventArgs e)
        {
            if (txtObservaciones.Text == "Observaciones") txtObservaciones.Text = "";
        }

        private void txtObservaciones_Leave(object sender, EventArgs e)
        {
            if (txtObservaciones.Text == "Observaciones") txtObservaciones.Text = "Observaciones";
        }

        private void txtSeccion_Enter(object sender, EventArgs e)
        {
            if (txtSeccion.Text == "Sección") txtSeccion.Text = "";
        }

        private void txtSeccion_Leave(object sender, EventArgs e)
        {
            if (txtSeccion.Text == "") txtSeccion.Text = "Sección";
        }
        private void LimpiarTextos()
        {
            txtPrimerNombre.Text = "Primer nombre";
            txtSegundoNombre.Text = "Segundo nombre";
            txtPrimerApellido.Text = "Primer apellido";
            txtSegundoApellido.Text = "Segundo apellido";
            txtDni.Text = "DNI";
            txtTelefono.Text = "Teléfono";
            txtSeccion.Text = "Sección";
            txtNivel.Text = "Nivel";
            txtGrado.Text = "Grado";
            txtObservaciones.Text = "Observaciones";
            txtDireccion.Text = "Dirección";
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            btnGuardar.Enabled = true;
            btnNuevo.Enabled = false;
        }
    }
}
