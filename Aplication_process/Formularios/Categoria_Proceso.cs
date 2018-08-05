using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplication_process
{
    public partial class Categoria_Proceso : Form
    {
        public static int codcate;
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["coneccion"].ConnectionString);
        public Categoria_Proceso()
        {
            InitializeComponent();
        }

        private void Categoria_Proceso_Load(object sender, EventArgs e)
        {
            SqlCommand consulta = new SqlCommand("select * from process_category ", cn);
            SqlDataAdapter da = new SqlDataAdapter(consulta);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            cn.Close();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            crud.Categoria_proceso insSql = new crud.Categoria_proceso();
            insSql.inserta_CProceso_SQL(txt_nombre.Text, txt_desc.Text);
            MessageBox.Show("Guardado correctamente");
            SqlCommand consulta = new SqlCommand("select * from process_category", cn);
            SqlDataAdapter da = new SqlDataAdapter(consulta);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            cn.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult varresult;
            crud.Categoria_proceso insSql = new crud.Categoria_proceso();
            codcate = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());

            varresult = MessageBox.Show("Desea eliminar este registro? ", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (varresult == DialogResult.Yes)
            {
                insSql.delete_CProceso_SQL(codcate);
                MessageBox.Show("Registro eliminado correctamente");
                SqlCommand consulta = new SqlCommand("select * from process_category ", cn);
                SqlDataAdapter da = new SqlDataAdapter(consulta);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                cn.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_nombre.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
            txt_desc.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            crud.Categoria_proceso insSql = new crud.Categoria_proceso();
            codcate = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            insSql.update_CProceso_SQL(codcate,txt_nombre.Text, txt_desc.Text);
            MessageBox.Show("Registro actualizado correctamente");
            SqlCommand consulta = new SqlCommand("select * from process_category", cn);
            SqlDataAdapter da = new SqlDataAdapter(consulta);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            cn.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txt_nombre.Text = "";
            txt_desc.Text = "";
        }
    }
}
