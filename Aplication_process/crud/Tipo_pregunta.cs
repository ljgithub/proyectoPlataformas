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
    class Tipo_pregunta
    {

        public void inserta_TipoPregunta_SQL(string name_tipeques, string desc_tipeques)
        {
            using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["HelpDeskConnectionString"].ToString()))
            {
                cn.Open();
                SqlCommand cmdact = new SqlCommand();
                cmdact.CommandText = "INSERT INTO tipe_question(name_tipeques,desc_tipeques,state_tipeques) values(@name_tipeques,@desc_tipeques,1)";
                cmdact.CommandType = CommandType.Text;
                cmdact.Connection = cn;
                cmdact.Parameters.AddWithValue("@name_tipeques", name_tipeques);
                cmdact.Parameters.AddWithValue("@desc_tipeques", desc_tipeques);
                cmdact.ExecuteNonQuery();
                cn.Close();
            }
        }

        public void delete_TipoPregunta_SQL(int id_tipeques)
        {
            using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["HelpDeskConnectionString"].ToString()))
            {
                cn.Open();
                SqlCommand cmdact = new SqlCommand();
                cmdact.CommandText = "delete from tipe_question where id_tipeques=@id_tipeques ";
                cmdact.CommandType = CommandType.Text;
                cmdact.Connection = cn;
                cmdact.Parameters.AddWithValue("@id_tipeques", id_tipeques);
                cmdact.ExecuteNonQuery();
                cn.Close();
            }
        }


        public void update_TipoPregunta_SQL(int id_tipeques, string name_tipeques, string desc_tipeques)
        {
            using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["HelpDeskConnectionString"].ToString()))
            {
                cn.Open();
                SqlCommand cmdact = new SqlCommand();
                cmdact.CommandText = "UPDATE tipe_question SET name_tipeques=@name_tipeques,desc_tipeques=@desc_tipeques where id_tipeques=@id_tipeques";
                cmdact.CommandType = CommandType.Text;
                cmdact.Connection = cn;
                cmdact.Parameters.AddWithValue("@name_tipeques", name_tipeques);
                cmdact.Parameters.AddWithValue("@desc_tipeques", desc_tipeques);
                cmdact.Parameters.AddWithValue("@id_tipeques", id_tipeques);
                cmdact.ExecuteNonQuery();
                cn.Close();
            }
        }
    }
}
