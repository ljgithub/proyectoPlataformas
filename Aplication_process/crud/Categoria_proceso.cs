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
    class Categoria_proceso
    {
        public void inserta_CProceso_SQL(string name_proccat, string desc_proccat)
        {
            using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["HelpDeskConnectionString"].ToString()))
            {
                cn.Open();
                SqlCommand cmdact = new SqlCommand();
                cmdact.CommandText = "INSERT INTO process_category(name_proccat,desc_proccat,state_proccat) values(@name_proccat,@desc_proccat,1)";
                cmdact.CommandType = CommandType.Text;
                cmdact.Connection = cn;
                cmdact.Parameters.AddWithValue("@name_proccat", name_proccat);
                cmdact.Parameters.AddWithValue("@desc_proccat", desc_proccat);
                cmdact.ExecuteNonQuery();
                cn.Close();
            }
        }

        public void delete_CProceso_SQL(int id_proccat)
        {
            using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["HelpDeskConnectionString"].ToString()))
            {
                cn.Open();
                SqlCommand cmdact = new SqlCommand();
                cmdact.CommandText = "delete from process_category where id_proccat=@id_proccat ";
                cmdact.CommandType = CommandType.Text;
                cmdact.Connection = cn;
                cmdact.Parameters.AddWithValue("@id_proccat", id_proccat);
                cmdact.ExecuteNonQuery();
                cn.Close();
            }
        }


        public void update_CProceso_SQL(int id_proccat, string name_proccat, string desc_proccat)
        {
            using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["HelpDeskConnectionString"].ToString()))
            {
                cn.Open();
                SqlCommand cmdact = new SqlCommand();
                cmdact.CommandText = "UPDATE process_category SET name_proccat=@name_proccat,desc_proccat=@desc_proccat where id_proccat=@id_proccat";
                cmdact.CommandType = CommandType.Text;
                cmdact.Connection = cn;
                cmdact.Parameters.AddWithValue("@name_proccat", name_proccat);
                cmdact.Parameters.AddWithValue("@desc_proccat", desc_proccat);
                cmdact.Parameters.AddWithValue("@id_proccat", id_proccat);
                cmdact.ExecuteNonQuery();
                cn.Close();
            }
        }
    }
}
