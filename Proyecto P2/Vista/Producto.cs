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
    public partial class Producto : Form
    {
        public Producto()
        {
            InitializeComponent();
        }

        private void Producto_Load(object sender, EventArgs e)
        {
            ClaseBD.Connect();
            // MessageBox.Show("Conexion");

            dataGridView1.DataSource = llenar_grid();
        }
        public DataTable llenar_grid()
        {

            ClaseBD.Connect();
            DataTable dt = new DataTable();
            string consulta = "SELECT * FROM Productos";
            SqlCommand cmd = new SqlCommand(consulta, ClaseBD.Connect());

            SqlDataAdapter data = new SqlDataAdapter(cmd);

            data.Fill(dt);

            return dt;

        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void Limpiar() {
            textcode.Clear();
            textnombre.Clear();
            textcodigo.Clear();
            textstock.Clear();
            textfecha.Clear();
            textdes.Clear();
            textid.Clear();
            textestado.Clear();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                ClaseBD.Connect();
                string alter = "INSERT INTO Productos (ID_Producto,Nombre,Codigo,Stock,Fecha_vencimiento,Descripcion,ID_Categoria,Estado) " +
                    "VALUES(@ID,@NOMBRE,@CODIGO,@STOCK,@FECHA,@DESCRIPCION,@ID_CATEGORIA,@ESTADO)";
                SqlCommand cmdalter = new SqlCommand(alter, ClaseBD.Connect());
                cmdalter.Parameters.AddWithValue("@ID", textcode.Text);
                cmdalter.Parameters.AddWithValue("@NOMBRE", textnombre.Text);
                cmdalter.Parameters.AddWithValue("@CODIGO", textcodigo.Text);
                cmdalter.Parameters.AddWithValue("@STOCK", textstock.Text);
                cmdalter.Parameters.AddWithValue("@FECHA", textfecha.Text);
                cmdalter.Parameters.AddWithValue("@DESCRIPCION", textdes.Text);
                cmdalter.Parameters.AddWithValue("@ID_CATEGORIA", textid.Text);
                cmdalter.Parameters.AddWithValue("@ESTADO", textestado.Text);

                cmdalter.ExecuteNonQuery();

                MessageBox.Show("Insertado Correctamente");

                dataGridView1.DataSource = llenar_grid();

                Limpiar();

              

            }
            catch (Exception) {
                MessageBox.Show("Error dato duplicado (ID)");

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView1.CurrentRow.Selected = true;
                textcode.Text = dataGridView1.Rows[e.RowIndex].Cells["ID_Producto"].FormattedValue.ToString();
                textnombre.Text = dataGridView1.Rows[e.RowIndex].Cells["Nombre"].FormattedValue.ToString();
                textcodigo.Text = dataGridView1.Rows[e.RowIndex].Cells["Codigo"].FormattedValue.ToString();
                textdes.Text = dataGridView1.Rows[e.RowIndex].Cells["Descripcion"].FormattedValue.ToString();
                textestado.Text = dataGridView1.Rows[e.RowIndex].Cells["Estado"].FormattedValue.ToString();
                textstock.Text = dataGridView1.Rows[e.RowIndex].Cells["Stock"].FormattedValue.ToString();
                textid.Text = dataGridView1.Rows[e.RowIndex].Cells["ID_Categoria"].FormattedValue.ToString();
                textfecha.Text = dataGridView1.Rows[e.RowIndex].Cells["Fecha_Vencimiento"].FormattedValue.ToString();
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClaseBD.Connect();
            string alter = "UPDATE Productos SET ID_Producto=@ID,Nombre=@NOMBRE,Codigo=@CODIGO,Stock=@STOCK,Fecha_vencimiento=@FECHA,Descripcion=@DESCRI,ID_Categoria=@IDCAT,Estado=@ESTADO WHERE ID_Producto=@ID";
            SqlCommand cmdalter = new SqlCommand(alter, ClaseBD.Connect());

            cmdalter.Parameters.AddWithValue("@ID", textcode.Text);
            cmdalter.Parameters.AddWithValue("@NOMBRE", textnombre.Text);
            cmdalter.Parameters.AddWithValue("@CODIGO", textcodigo.Text);
            cmdalter.Parameters.AddWithValue("@STOCK", textstock.Text);
            cmdalter.Parameters.AddWithValue("@FECHA", textfecha.Text);
            cmdalter.Parameters.AddWithValue("@DESCRI", textdes.Text);
            cmdalter.Parameters.AddWithValue("@IDCAT", textid.Text);
            cmdalter.Parameters.AddWithValue("@ESTADO", textestado.Text);

            cmdalter.ExecuteNonQuery();

            MessageBox.Show("Datos actualizados");
            dataGridView1.DataSource = llenar_grid();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ClaseBD.Connect();
            string delete = "DELETE FROM Productos Where ID_Producto=@ID";
            SqlCommand cmddelete = new SqlCommand(delete, ClaseBD.Connect());

            cmddelete.Parameters.AddWithValue("@ID", textcode.Text);

            cmddelete.ExecuteNonQuery();

            MessageBox.Show("Eliminado Correctamente");

            dataGridView1.DataSource = llenar_grid();
        }

 
        private void textstock_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
