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
    class Roles
    {
        public void inserta_Rol_SQL(string name_role, string permission_role)
        {
            using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["HelpDeskConnectionString"].ToString()))
            {
                cn.Open();
                SqlCommand cmdact = new SqlCommand();
                cmdact.CommandText = "INSERT INTO rol(name_role,permission_role,state_role) values(@name_role,@permission_role,1)";
                cmdact.CommandType = CommandType.Text;
                cmdact.Connection = cn;
                cmdact.Parameters.AddWithValue("@name_role", name_role);
                cmdact.Parameters.AddWithValue("@permission_role", permission_role);
                             cmdact.ExecuteNonQuery();
                cn.Close();
            }
        }

        public void delete_Rol_SQL(int id_role)
        {
            using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["HelpDeskConnectionString"].ToString()))
            {
                cn.Open();
                SqlCommand cmdact = new SqlCommand();
                cmdact.CommandText = "delete from rol where id_role=@id_role ";
                cmdact.CommandType = CommandType.Text;
                cmdact.Connection = cn;
                cmdact.Parameters.AddWithValue("@id_role", id_role);
                cmdact.ExecuteNonQuery();
                cn.Close();
            }
        }


        public void update_Rol_SQL(int id_role, string name_role, string permission_role)
        {
            using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["HelpDeskConnectionString"].ToString()))
            {
                cn.Open();
                SqlCommand cmdact = new SqlCommand();
                cmdact.CommandText = "UPDATE ROL SET name_role=@name_role,permission_role=@permission_role where id_role=@id_role";
                cmdact.CommandType = CommandType.Text;
                cmdact.Connection = cn;
                cmdact.Parameters.AddWithValue("@id_role", id_role);
                cmdact.Parameters.AddWithValue("@name_role", name_role);
                cmdact.Parameters.AddWithValue("@permission_role", permission_role);

                cmdact.ExecuteNonQuery();
                cn.Close();
            }
        }
    }
}
