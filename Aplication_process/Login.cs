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
    public partial class Login : Form
    {

        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["coneccion"].ConnectionString);
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["coneccion"].ConnectionString);
            cn.Open();
            validaciones.Validaciones vali = new validaciones.Validaciones();
            if (string.IsNullOrEmpty(txt_email.Text) || string.IsNullOrEmpty(txt_clave.Text)){
                MessageBox.Show("Los campos 'Usuario' y 'Password' son obligatorios.", "LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_email.Focus();
            }
            else
            {
                if (vali.validarEmail(txt_email.Text)  == false)
                {
                    MessageBox.Show("Ingrese un email válido.", "LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txt_email.Focus();
                }
                else
                {
                    validaciones.Encriptacion en = new validaciones.Encriptacion();
                    string claveencrip = (en.Encriptar(txt_clave.Text));
                    SqlCommand consulta = new SqlCommand("SELECT * FROM usuario WHERE email_user='" + txt_email.Text + "' AND pass_user='" + claveencrip + "'", cn);
                    SqlDataReader ejecuta = consulta.ExecuteReader();
                    if (ejecuta.Read() == true)
                    {
                        MessageBox.Show("Bienvenido");
                        MDIprincipal menu = new MDIprincipal();
                        this.Hide();
                        menu.Show();
                    }
                    else
                    {
                        MessageBox.Show("Usuario no encontrado");
                        txt_clave.Text = "USUARIO";
                        txt_email.Text = "CONTRASEÑA";
                    }
                }

                
            }
            cn.Close();
            cn.Dispose();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void txt_email_Enter(object sender, EventArgs e)
        {
            if (txt_email.Text == "USUARIO") {
                txt_email.Text = "";
                txt_email.ForeColor = Color.LightGray;
            } 
        }

        private void txt_email_Leave(object sender, EventArgs e)
        {
            if (txt_email.Text == "") { txt_email.Text = "USUARIO"; txt_email.ForeColor = Color.DimGray; }
        }

        private void txt_clave_Enter(object sender, EventArgs e)
        {
            if (txt_clave.Text == "CONTRASEÑA")
            {
                txt_clave.Text = "";
                txt_clave.ForeColor = Color.LightGray;
                txt_clave.UseSystemPasswordChar = true;
            }
        }

        private void txt_clave_Leave(object sender, EventArgs e)
        {
            if (txt_clave.Text == "") { txt_clave.Text = "CONTRASEÑA"; txt_clave.ForeColor = Color.DimGray; }
            txt_clave.UseSystemPasswordChar = false;
        }

        private void txt_clave_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
