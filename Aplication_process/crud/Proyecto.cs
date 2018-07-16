using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication_process.crud
{
    class Proyecto
    {

        public void inserta_Usuario_SQL(string name_user, string lastname_user, string email_user, int state_user, string empresa_user, string phone_user, string phone2_user, int id_role, string pass_user)
        {
            using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["HelpDeskConnectionString"].ToString()))
            {
                cn.Open();
                SqlCommand cmdact = new SqlCommand();
                cmdact.CommandText = "INSERT INTO usuario(name_user,lastname_user,email_user,state_user,empresa_user,phone_user,phone2_user,id_role,pass_user) values(@name_user,@lastname_user,@email_user, @state_user, @empresa_user, @phone_user, @phone2_user, @id_role, @pass_user)";
                cmdact.CommandType = CommandType.Text;
                cmdact.Connection = cn;
                cmdact.Parameters.AddWithValue("@name_user", name_user);
                cmdact.Parameters.AddWithValue("@lastname_user", lastname_user);
                cmdact.Parameters.AddWithValue("@email_user", email_user);
                cmdact.Parameters.AddWithValue("@state_user", state_user);
                cmdact.Parameters.AddWithValue("@empresa_user", empresa_user);
                cmdact.Parameters.AddWithValue("@phone_user", phone_user);
                cmdact.Parameters.AddWithValue("@phone2_user", phone2_user);
                cmdact.Parameters.AddWithValue("@id_role", id_role);
                cmdact.Parameters.AddWithValue("@pass_user", pass_user);
                cmdact.ExecuteNonQuery();
                cn.Close();
            }
        }

        public void delete_Usuario_SQL(int id_user)
        {
            using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["HelpDeskConnectionString"].ToString()))
            {
                cn.Open();
                SqlCommand cmdact = new SqlCommand();
                cmdact.CommandText = "delete from USUARIO where id_user=@id_user ";
                cmdact.CommandType = CommandType.Text;
                cmdact.Connection = cn;
                cmdact.Parameters.AddWithValue("@id_user", id_user);
                cmdact.ExecuteNonQuery();
                cn.Close();
            }
        }


        public void update_Usuario_SQL(int id_user, string name_user, string lastname_user, string email_user, int state_user, string empresa_user, string phone_user, string phone2_user, int id_role)
        {
            using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["HelpDeskConnectionString"].ToString()))
            {
                cn.Open();
                SqlCommand cmdact = new SqlCommand();
                cmdact.CommandText = "UPDATE usuario SET name_user=@name_user,lastname_user=@lastname_user,email_user=@email_user,state_user=@state_user,empresa_user=@empresa_user,phone_user=@phone_user,phone2_user=@phone2_user,id_role=@id_role where id_user=@id_user";
                cmdact.CommandType = CommandType.Text;
                cmdact.Connection = cn;
                cmdact.Parameters.AddWithValue("@id_user", id_user);
                cmdact.Parameters.AddWithValue("@name_user", name_user);
                cmdact.Parameters.AddWithValue("@lastname_user", lastname_user);
                cmdact.Parameters.AddWithValue("@email_user", email_user);
                cmdact.Parameters.AddWithValue("@state_user", state_user);
                cmdact.Parameters.AddWithValue("@empresa_user", empresa_user);
                cmdact.Parameters.AddWithValue("@phone_user", phone_user);
                cmdact.Parameters.AddWithValue("@phone2_user", phone2_user);
                cmdact.Parameters.AddWithValue("@id_role", id_role);
                cmdact.ExecuteNonQuery();
                cn.Close();
            }
        }
    }
}
