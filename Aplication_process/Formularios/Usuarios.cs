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
using System.Configuration;


namespace Aplication_process
{
    public partial class Usuarios : Form
    {
        
        public static int codusuario;
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["coneccion"].ConnectionString);
        public Usuarios()
        {
            InitializeComponent();
            cb_estado.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_perfil.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            SqlCommand consulta = new SqlCommand("select id_user,name_user,lastname_user,email_user, pass_user,state_user,empresa_user,phone_user,phone_user,name_role from usuario u inner join rol r on r.id_role=u.id_role ", cn);
            SqlDataAdapter da = new SqlDataAdapter(consulta);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            cn.Close();

            DataSet ds = new DataSet();
            //indicamos la consulta en SQL
            SqlDataAdapter dap = new SqlDataAdapter("SELECT id_role,name_role from rol", cn);
            //se indica el nombre de la tabla
            dap.Fill(ds, "rol");
            cb_perfil.DataSource = ds.Tables[0].DefaultView;
            //se especifica el campo de la tabla
            cb_perfil.ValueMember = "name_rol";
          
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_nombre.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
            txt_apellido.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
            txt_email.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
            txt_telefono.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString());
            txt_telefono2.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString());
            txt_empresa.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString());
            cb_perfil.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString());
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            validaciones.Validaciones vali = new validaciones.Validaciones();
            ErrorProvider err = new ErrorProvider();

            if (!vali.validarEmail(txt_email.Text))
            {
                err.SetError(txt_email, "El email inválido");
            } 
            if (!vali.validacionIsNumeric(txt_telefono.Text))
            {
                err.SetError(txt_telefono, "No se admiten letras");
            }

            if (vali.validacionIsNumeric(txt_telefono.Text) == false)
            {
                MessageBox.Show("Ingrese un número de teléfono válido.", "NUMERO TELEFONO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_email.Focus();
            }
            else
            {

                crud.Usuarios insSql = new crud.Usuarios();
                validaciones.Encriptacion en = new validaciones.Encriptacion();
                string password = en.Encriptar("1234");
                int estado, perfil;
                estado = Convert.ToInt32(cb_estado.SelectedValue);
                perfil = Convert.ToInt32(cb_perfil.SelectedValue);
                insSql.inserta_Usuario_SQL(txt_nombre.Text, txt_apellido.Text, txt_email.Text, estado, txt_empresa.Text, txt_telefono.Text, txt_telefono2.Text, perfil, password);
                MessageBox.Show("Usuario guardado correctamente");
                SqlCommand consulta = new SqlCommand("select id_user,name_user,lastname_user,email_user, pass_user,state_user,empresa_user,phone_user,phone_user,name_role from usuario u inner join rol r on r.id_role=u.id_role ", cn);
                SqlDataAdapter da = new SqlDataAdapter(consulta);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                cn.Close();

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult varresult;
            crud.Usuarios insSql = new crud.Usuarios();
            codusuario = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());

            varresult = MessageBox.Show("Desea eliminar este usuario? ", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (varresult == DialogResult.Yes)
            {
                insSql.delete_Usuario_SQL(codusuario);
                MessageBox.Show("Usuario eliminado correctamente");
                SqlCommand consulta = new SqlCommand("select id_user,name_user,lastname_user,email_user, pass_user,state_user,empresa_user,phone_user,phone_user,name_role from usuario u inner join rol r on r.id_role=u.id_role ", cn);
                SqlDataAdapter da = new SqlDataAdapter(consulta);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                cn.Close();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            crud.Usuarios insSql = new crud.Usuarios();
            int estado, perfil;
            estado = Convert.ToInt32(cb_estado.SelectedValue);
            perfil = Convert.ToInt32(cb_perfil.SelectedValue);
            codusuario = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            insSql.update_Usuario_SQL(codusuario, txt_nombre.Text, txt_apellido.Text, txt_email.Text, estado, txt_empresa.Text, txt_telefono.Text, txt_telefono2.Text, perfil);
            MessageBox.Show("Usuario actualizado correctamente");
            SqlCommand consulta = new SqlCommand("select id_user,name_user,lastname_user,email_user, pass_user,state_user,empresa_user,phone_user,phone_user,name_role from usuario u inner join rol r on r.id_role=u.id_role ", cn);
            SqlDataAdapter da = new SqlDataAdapter(consulta);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            cn.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txt_nombre.Text = "";
            txt_apellido.Text = "";
            txt_email.Text = "";
            txt_empresa.Text = "";
            txt_telefono.Text = "";
            txt_telefono2.Text = "";
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            SqlCommand consulta = new SqlCommand("select id_user,name_user,lastname_user,email_user, pass_user,state_user,empresa_user,phone_user,phone_user,name_role from usuario u inner join rol r on r.id_role=u.id_role where name_user like('"+ txt_filtro1.Text +"%')", cn);
            SqlDataAdapter da = new SqlDataAdapter(consulta);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            cn.Close();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            validaciones.Encriptacion en = new validaciones.Encriptacion();
            string claveencrip = (en.Encriptar("1234"));
            txt_nombre.Text = claveencrip;


        }

        private void txt_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            txt_nombre.CharacterCasing = CharacterCasing.Upper;
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_apellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            txt_apellido.CharacterCasing = CharacterCasing.Upper;
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_empresa_KeyPress(object sender, KeyPressEventArgs e)
        {
            txt_empresa.CharacterCasing = CharacterCasing.Upper;
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
