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
    public partial class Proyectos : Form
    {

        public static int id_proj;

        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["coneccion"].ConnectionString);
        public Proyectos()
        {
            InitializeComponent();
        }

        private void Proyectos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bdd_helpdeskDataSet1.tipe_proyect' Puede moverla o quitarla según sea necesario.
            this.tipe_proyectTableAdapter.Fill(this.bdd_helpdeskDataSet1.tipe_proyect);
            // TODO: esta línea de código carga datos en la tabla 'bdd_helpdeskDataSet.usuario' Puede moverla o quitarla según sea necesario.
            this.usuarioTableAdapter.Fill(this.bdd_helpdeskDataSet.usuario);
            SqlCommand consulta = new SqlCommand("select * from proyect", cn);
            SqlDataAdapter da = new SqlDataAdapter(consulta);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            cn.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            int valueEstado;
            crud.Proyecto insProj = new crud.Proyecto();
            if (chb_estado.Checked) { valueEstado = 1; } else { valueEstado = 0; }
            insProj.inserta_Proy_SQL(txt_nomProy.Text,dp_fecha_ini.Value.Date, dp_fecha_fin.Value.Date,"Activo", Convert.ToDouble(txt_presupuesto.Text), Convert.ToDouble(txt_porcentaje.Text),rh_descrip.Text,Convert.ToInt32(cmb_tipo.SelectedValue),1, "www.default.com", rh_objetivo.Text, valueEstado,"",rh_alcance.Text);
            MessageBox.Show("El proyecto se ha guardado correctamente");
            SqlCommand consulta = new SqlCommand("select * from proyect", cn);
            SqlDataAdapter da = new SqlDataAdapter(consulta);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            cn.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id_proj = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            txt_nomProy.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
            dp_fecha_ini.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
            dp_fecha_fin.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
            //chb_estado.Checked = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString());
            /*if (dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString() =="1") {
                chb_estado.Checked = true;
            }*/
            txt_presupuesto.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString());
            txt_porcentaje.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString());
            rh_descrip.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString());
            cmb_tipo.SelectedValue = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString());
            txt_link_Proy.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString());
            rh_objetivo.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString());
            if (dataGridView1.Rows[e.RowIndex].Cells[12].Value.ToString() == "1")
            {
                chb_estado.Checked = true;
            }
            rh_alcance.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[14].Value.ToString());
        }

        private void btn_actualizar_registro_Click(object sender, EventArgs e )
        {            
            int valueEstado;
            crud.Proyecto insSql = new crud.Proyecto();            
            if (chb_estado.Checked) { valueEstado = 1; } else { valueEstado = 0; }
            insSql.update_Project_SQL(id_proj,txt_nomProy.Text, dp_fecha_ini.Value.Date, dp_fecha_fin.Value.Date, "Activo", Convert.ToDouble(txt_presupuesto.Text), Convert.ToDouble(txt_porcentaje.Text), rh_descrip.Text, Convert.ToInt32(cmb_tipo.SelectedValue), 1, "www.default.com", rh_objetivo.Text, valueEstado, "", rh_alcance.Text);
            MessageBox.Show("Proyecto actualizado correctamente");
            SqlCommand consulta = new SqlCommand("select * from proyect" , cn);
            SqlDataAdapter da = new SqlDataAdapter(consulta);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            cn.Close();
        }
    }
}
