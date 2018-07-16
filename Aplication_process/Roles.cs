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
    public partial class Roles : Form
    {

        public static int codrol;
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["coneccion"].ConnectionString);
        public Roles()
        {
            InitializeComponent();
        }

        private void Roles_Load(object sender, EventArgs e)
        {
            SqlCommand consulta = new SqlCommand("select * from rol ", cn);
            SqlDataAdapter da = new SqlDataAdapter(consulta);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            cn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            crud.Roles insSql = new crud.Roles();
            insSql.inserta_Rol_SQL(txt_nombre.Text, txt_permiso.Text);
            MessageBox.Show("Rol guardado correctamente");
            SqlCommand consulta = new SqlCommand("select * from rol", cn);
            SqlDataAdapter da = new SqlDataAdapter(consulta);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            cn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_nombre.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
            txt_permiso.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult varresult;
            crud.Roles insSql = new crud.Roles();
            codrol = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());

            varresult = MessageBox.Show("Desea eliminar este rol? ", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (varresult == DialogResult.Yes)
            {
                insSql.delete_Rol_SQL(codrol);
                MessageBox.Show("Rol eliminado correctamente");
                SqlCommand consulta = new SqlCommand("select * from rol", cn);
                SqlDataAdapter da = new SqlDataAdapter(consulta);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                cn.Close();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            crud.Roles insSql = new crud.Roles();
            codrol = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            insSql.update_Rol_SQL(codrol, txt_nombre.Text, txt_permiso.Text);
            MessageBox.Show("Rol actualizado correctamente");
            SqlCommand consulta = new SqlCommand("select * from rol", cn);
            SqlDataAdapter da = new SqlDataAdapter(consulta);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            cn.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txt_nombre.Text = "";
            txt_permiso.Text = "";

        }
    }
}
