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
    class Tipo_proyecto
    {

        public void inserta_TipoProyecto_SQL(string nombre_tproy, string desc_tproy)
        {
            using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["HelpDeskConnectionString"].ToString()))
            {
                cn.Open();
                SqlCommand cmdact = new SqlCommand();
                cmdact.CommandText = "INSERT INTO tipe_proyect(nombre_tproy,desc_tproy,estado_tproy) values(@nombre_tproy,@desc_tproy,1)";
                cmdact.CommandType = CommandType.Text;
                cmdact.Connection = cn;
                cmdact.Parameters.AddWithValue("@nombre_tproy", nombre_tproy);
                cmdact.Parameters.AddWithValue("@desc_tproy", desc_tproy);
                cmdact.ExecuteNonQuery();
                cn.Close();
            }
        }

        public void delete_TipoProyecto_SQL(int id_tproy)
        {
            using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["HelpDeskConnectionString"].ToString()))
            {
                cn.Open();
                SqlCommand cmdact = new SqlCommand();
                cmdact.CommandText = "delete from tipe_proyect where id_tproy=@id_tproy ";
                cmdact.CommandType = CommandType.Text;
                cmdact.Connection = cn;
                cmdact.Parameters.AddWithValue("@id_tproy", id_tproy);
                cmdact.ExecuteNonQuery();
                cn.Close();
            }
        }


        public void update_TipoProyecto_SQL(string nombre_tproy, string desc_tproy, int id_tproy)
        {
            using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["HelpDeskConnectionString"].ToString()))
            {
                cn.Open();
                SqlCommand cmdact = new SqlCommand();
                cmdact.CommandText = "UPDATE tipe_proyect SET nombre_tproy=@nombre_tproy,desc_tproy=@desc_tproy  where id_tproy=@id_tproy";
                cmdact.CommandType = CommandType.Text;
                cmdact.Connection = cn;
                cmdact.Parameters.AddWithValue("@nombre_tproy", nombre_tproy);
                cmdact.Parameters.AddWithValue("@desc_tproy", desc_tproy);
                cmdact.Parameters.AddWithValue("@id_tproy", id_tproy);
                cmdact.ExecuteNonQuery();
                cn.Close();
            }
        }
    }
}
