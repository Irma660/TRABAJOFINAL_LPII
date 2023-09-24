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
        private void btnMin_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMax_Click_1(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal) this.WindowState = FormWindowState.Maximized;
            else this.WindowState = FormWindowState.Normal;
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnINICIO_Click(object sender, EventArgs e)
        {
            string USUARIO = textUsuario.Text;
            string CONTRASEÑA= textContraseña.Text;

            using (SqlConnection conn = new SqlConnection(conexion))
            {
                conn.Open();
                string entrada = "SELECT COUNT (*) FROM USUARIO WHERE USUARIO = @USUARIO and CONTRSEÑA= @CONTRASEÑA";
                SqlCommand comando = new SqlCommand(entrada, conn);
                comando.Parameters.AddWithValue("@USUARIO", USUARIO);
                comando.Parameters.AddWithValue("@CONTRASEÑA", CONTRASEÑA);


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
