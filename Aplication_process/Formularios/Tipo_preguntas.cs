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
    public partial class Tipo_preguntas : Form
    {

        public static int codpre;
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["coneccion"].ConnectionString);
        public Tipo_preguntas()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Tipo_preguntas_Load(object sender, EventArgs e)
        {
            SqlCommand consulta = new SqlCommand("select * from tipe_question", cn);
            SqlDataAdapter da = new SqlDataAdapter(consulta);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            cn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            crud.Tipo_pregunta insSql = new crud.Tipo_pregunta();
            insSql.inserta_TipoPregunta_SQL(txt_nombre.Text, txt_desc.Text);
            MessageBox.Show("Registro guardado correctamente");
            SqlCommand consulta = new SqlCommand("select * from tipe_question", cn);
            SqlDataAdapter da = new SqlDataAdapter(consulta);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            cn.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult varresult;
            crud.Tipo_pregunta insSql = new crud.Tipo_pregunta();
            codpre = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());

            varresult = MessageBox.Show("Desea eliminar este registro? ", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (varresult == DialogResult.Yes)
            {
                insSql.delete_TipoPregunta_SQL(codpre);
                MessageBox.Show("Registro eliminado correctamente");
                SqlCommand consulta = new SqlCommand("select * from tipe_question", cn);
                SqlDataAdapter da = new SqlDataAdapter(consulta);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                cn.Close();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            crud.Tipo_pregunta insSql = new crud.Tipo_pregunta();
            codpre = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            insSql.update_TipoPregunta_SQL(codpre,txt_nombre.Text, txt_desc.Text);
            MessageBox.Show("Registro actualizado correctamente");
            SqlCommand consulta = new SqlCommand("select * from tipe_question", cn);
            SqlDataAdapter da = new SqlDataAdapter(consulta);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            cn.Close();
        }
    }
}
