using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common.Attributes;
using Domain.Crud;

namespace Presentation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        //Variables
        CPersonas personas = new CPersonas();
        AttributesPeople attributes = new AttributesPeople();
        bool edit = false;
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

        private void getData()
        {
            CPersonas cPersonas = new CPersonas();
            DvgDatos.DataSource = cPersonas.Mostrar();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            txtSexo.SelectedIndex = 0;
            btnGuardar.Enabled = false;
            getData();
        }

        private void txtID_Enter(object sender, EventArgs e)
        {
            if (txtID.Text == "ID") txtID.Text = "";
        }

        private void txtID_Leave(object sender, EventArgs e)
        {
            if (txtID.Text == "") txtID.Text = "ID";
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
            if (txtDireccion.Text == "") txtDireccion.Text = "Dirección";
        }

        private void txtObservaciones_Enter(object sender, EventArgs e)
        {
            if (txtObservaciones.Text == "Observaciones") txtObservaciones.Text = "";
        }

        private void txtObservaciones_Leave(object sender, EventArgs e)
        {
            if (txtObservaciones.Text == "") txtObservaciones.Text = "Observaciones";
        }

        private void txtSeccion_Enter(object sender, EventArgs e)
        {
            if (txtSeccion.Text == "Sección") txtSeccion.Text = "";
        }

        private void txtSeccion_Leave(object sender, EventArgs e)
        {
            if (txtSeccion.Text == "") txtSeccion.Text = "Sección";
        }

        private void ClearTextBoxs()
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (edit == false)
            {
                //INSERTAR
                try
                {
                    attributes.Id = int.Parse(txtID.Text).ToString();
                    attributes.Primer_nombre = txtPrimerNombre.Text;
                    attributes.Segundo_nombre = txtSegundoNombre.Text;
                    attributes.Primer_apellido = txtPrimerApellido.Text;
                    attributes.Segundo_apellido = txtSegundoApellido.Text;
                    attributes.Telefono = txtTelefono.Text;
                    attributes.Nivel = txtNivel.Text;
                    attributes.Grado = txtGrado.Text;
                    attributes.Seccion = txtSeccion.Text;
                    attributes.Direccion = txtDireccion.Text;
                    attributes.Sexo = txtSexo.Text;
                    attributes.Fecha_nac = txtFechNac.Text;
                    attributes.Observaciones = txtObservaciones.Text;
                    attributes.Dni = txtDni.Text;

                    personas.Insertar(attributes);
                    ClearTextBoxs();
                    getData();
                    btnGuardar.Enabled = false;
                    btnNuevo.Enabled = true;
                    MessageBox.Show("SE GUARDÓ UN REGISTRO DE FORMA EXITOSA", "INSERTADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch(Exception ex)
                {
                    MessageBox.Show( $"SE PRODUJO EL SIGUIENTE ERROR: {ex.ToString()}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }else if(edit == true)
            {
                //ACTUALIZAR
                try
                {
                    attributes.Id = int.Parse(txtID.Text).ToString();
                    attributes.Primer_nombre = txtPrimerNombre.Text;
                    attributes.Segundo_nombre = txtSegundoNombre.Text;
                    attributes.Primer_apellido = txtPrimerApellido.Text;
                    attributes.Segundo_apellido = txtSegundoApellido.Text;
                    attributes.Telefono = txtTelefono.Text;
                    attributes.Nivel = txtNivel.Text;
                    attributes.Grado = txtGrado.Text;
                    attributes.Seccion = txtSeccion.Text;
                    attributes.Direccion = txtDireccion.Text;
                    attributes.Sexo = txtSexo.Text;
                    attributes.Fecha_nac = txtFechNac.Text;
                    attributes.Observaciones = txtObservaciones.Text;
                    attributes.Dni = txtDni.Text;
                    personas.Modificar(attributes);
                    ClearTextBoxs();
                    getData();
                    btnGuardar.Enabled = false;
                    btnNuevo.Enabled = true;
                    txtID.Enabled = true;
                    edit = false;
                    MessageBox.Show("SE ACTUALIZÓ UN REGISTRO DE FORMA EXITOSA", "MODIFICADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"SE PRODUJO EL SIGUIENTE ERROR: {ex.ToString()}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (DvgDatos.SelectedRows.Count > 0)
            {
                txtID.Enabled = false;
                btnNuevo.Enabled = false;
                btnGuardar.Enabled = true;
                edit = true;
                //CARGAR DATOS
                txtID.Text = DvgDatos.CurrentRow.Cells[0].Value.ToString();
                txtPrimerNombre.Text = DvgDatos.CurrentRow.Cells[1].Value.ToString();
                txtSegundoNombre.Text = DvgDatos.CurrentRow.Cells[2].Value.ToString();
                txtPrimerApellido.Text = DvgDatos.CurrentRow.Cells[3].Value.ToString();
                txtSegundoApellido.Text = DvgDatos.CurrentRow.Cells[4].Value.ToString();
                txtTelefono.Text = DvgDatos.CurrentRow.Cells[5].Value.ToString();
                txtNivel.Text = DvgDatos.CurrentRow.Cells[6].Value.ToString();
                txtGrado.Text = DvgDatos.CurrentRow.Cells[7].Value.ToString();
                txtSeccion.Text = DvgDatos.CurrentRow.Cells[8].Value.ToString();
                txtDireccion.Text = DvgDatos.CurrentRow.Cells[9].Value.ToString();
                txtSexo.Text = DvgDatos.CurrentRow.Cells[10].Value.ToString();
                txtFechNac.Text = DvgDatos.CurrentRow.Cells[11].Value.ToString();
                txtObservaciones.Text = DvgDatos.CurrentRow.Cells[12].Value.ToString();
                txtDni.Text = DvgDatos.CurrentRow.Cells[13].Value.ToString();

            }
        }

        private void txtBuscar_Enter(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "Buscar...") txtBuscar.Text = "";
        }

        private void txtBuscar_Leave(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
            {
                txtBuscar.Text = "Buscar...";
                getData();
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (DvgDatos.SelectedRows.Count > 0)
            {
                DialogResult dialog = MessageBox.Show("¿DESEAS ELIMINAR ESTE REGISTRO?", "ELIMINAR", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialog == DialogResult.Yes)
                {
                    try
                    {
                        int selectedRowIndex = DvgDatos.SelectedRows[0].Index;
                        DataGridViewRow selectedRow = DvgDatos.Rows[selectedRowIndex];

                        if (selectedRow.Cells[0].Value != null)
                        {
                            if (int.TryParse(selectedRow.Cells[0].Value.ToString(), out int id))
                            {
                                attributes.Id = null;
                                personas.Eliminar(attributes);
                                getData();
                                MessageBox.Show("REGISTRO ELIMINADO CORRECTAMENTE", "ELIMINADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("La celda seleccionada no contiene un valor numérico válido.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("La celda seleccionada está vacía.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"SE PRODUJO EL SIGUIENTE ERROR: {ex.ToString()}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            CPersonas cPersonas = new CPersonas();
            DvgDatos.DataSource = cPersonas.Buscar(txtBuscar.Text);
        }

        private void DvgDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DvgDatos_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
