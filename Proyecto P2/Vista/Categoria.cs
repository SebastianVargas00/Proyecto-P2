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
    public partial class Categoria : Form
    {
        public Categoria()
        {
            InitializeComponent();

        }

        private void Categoria_Load(object sender, EventArgs e)
        {
            ClaseBD.Connect();
            dataGridView1.DataSource = llenar_grid();

        }

        public DataTable llenar_grid() {

            ClaseBD.Connect();
            DataTable dt = new DataTable();
            string consulta = "SELECT * FROM Categorias";
            SqlCommand cmd = new SqlCommand(consulta, ClaseBD.Connect());

            SqlDataAdapter data = new SqlDataAdapter(cmd);

            data.Fill(dt);

            return dt;

        }
        public void Limpiar()
        {
            textcodigo.Clear();
            textestado.Clear();
            textnombre.Clear();

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                ClaseBD.Connect();
                string insert = "INSERT INTO Categorias (ID_Categoria,Nombre,Estado) " +
                    "VALUES(@ID,@NOMBRE,@ESTADO)";
                SqlCommand cmdadd = new SqlCommand(insert, ClaseBD.Connect());
                cmdadd.Parameters.AddWithValue("@ID", textcodigo.Text);
                cmdadd.Parameters.AddWithValue("@NOMBRE", textnombre.Text);
                cmdadd.Parameters.AddWithValue("@ESTADO", textestado.Text);
                cmdadd.ExecuteNonQuery();
                MessageBox.Show("Insertado Correctamente");
                dataGridView1.DataSource = llenar_grid();

                Limpiar();
            }
            catch (Exception) {
                MessageBox.Show("Error, datos duplicados (ID)");
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView1.CurrentRow.Selected = true;
                textcodigo.Text = dataGridView1.Rows[e.RowIndex].Cells["ID_Categoria"].FormattedValue.ToString();
                textnombre.Text = dataGridView1.Rows[e.RowIndex].Cells["Nombre"].FormattedValue.ToString();
                textestado.Text = dataGridView1.Rows[e.RowIndex].Cells["Estado"].FormattedValue.ToString();


            }

        }

        private void buttonalter_Click(object sender, EventArgs e)
        {
            ClaseBD.Connect();
            string alter = "UPDATE Categorias SET Id_Categoria=@ID,Nombre=@NOMBRE,Estado=@ESTADO WHERE Id_Categoria=@ID";
            SqlCommand cmdalter = new SqlCommand(alter,ClaseBD.Connect());

            cmdalter.Parameters.AddWithValue("@ID",textcodigo.Text);
            cmdalter.Parameters.AddWithValue("@NOMBRE", textnombre.Text);
            cmdalter.Parameters.AddWithValue("@ESTADO", textestado.Text);

            cmdalter.ExecuteNonQuery();

            MessageBox.Show("Datos actualizados");
            dataGridView1.DataSource=llenar_grid();
        }

        private void buttondelete_Click(object sender, EventArgs e)
        {
            try
            {
                ClaseBD.Connect();
                string delete = "DELETE FROM Categorias Where ID_Categoria=@ID";
                SqlCommand cmddelete = new SqlCommand(delete, ClaseBD.Connect());

                cmddelete.Parameters.AddWithValue("@ID", textcodigo.Text);

                cmddelete.ExecuteNonQuery();

                MessageBox.Show("Eliminado Correctamente");

                dataGridView1.DataSource = llenar_grid();

                textcodigo.Clear();
                textnombre.Clear();
                textestado.Clear();

            }
            catch (Exception) {
                MessageBox.Show("Error, valla a tabla producto y elimine la relación");
            }
        
        }

        

        
    }
           
}

