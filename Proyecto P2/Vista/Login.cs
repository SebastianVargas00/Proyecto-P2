using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Proyecto_P2
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClaseBD.Connect();
            string entrar = "SELECT* FROM Usuario WHERE Usuario = '" + txtusuario.Text + "'AND Contraseña = '" + txtcontraseña.Text + "'";
            SqlCommand codigo = new SqlCommand(entrar,ClaseBD.Connect());
            codigo.ExecuteNonQuery();
            SqlDataReader js = codigo.ExecuteReader();
            try
            {
                if (js.Read())
                {
                    MessageBox.Show("Bienvenido....");
                    Form formulario = new Form2();
                    formulario.Visible = true;
                    Visible = false;
                }
                else
                {
                    MessageBox.Show("Usuario o Contraseña incorrecta...");
                }

            }
            catch (SqlException Error)
            {
                MessageBox.Show(Error.Message);
            }
            
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                if (txtcontraseña.UseSystemPasswordChar == true)
                {
                    txtcontraseña.UseSystemPasswordChar = false;
                }
            }
            else
            {
                txtcontraseña.UseSystemPasswordChar = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
