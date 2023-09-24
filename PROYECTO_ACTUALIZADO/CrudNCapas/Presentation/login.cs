using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class login : Form
    {
        private string conexion = "Data Source=DESKTOP-7LDGQBD;Initial Catalog=LOGINBD;Integrated Security=True";
        public login()
        {
            InitializeComponent();
        }

        private void btnINICIO_Click(object sender, EventArgs e)
        {
            string usuario = textUsuario.Text;
            string contraseña = textContraseña.Text;

            using (SqlConnection conn = new SqlConnection(conexion))
            {
                conn.Open();
                string entrada = "SELECT COUNT (*) FROM USUARIOS WHERE usuario = @usuario and contraseña = @contraseña";
                SqlCommand comando = new SqlCommand(entrada, conn);
                comando.Parameters.AddWithValue("@usuario", usuario);
                comando.Parameters.AddWithValue("@contraseña", contraseña);


                int mostrar = (int)comando.ExecuteScalar();

                if (mostrar > 0)
                {

                    Form1 registroForm = new Form1();
                    registroForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("INVÁLIDO");
                }
            }
        }
    }
}
