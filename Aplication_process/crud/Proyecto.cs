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


        public void inserta_Proy_SQL(string name_proyect, DateTime datein_proyect, DateTime datemsx_proyect,
            string estado_proyect, double presupuesto_proyect, double percent_proyect, string desc_proyect, 
            int id_tproy, int  form_id, string link_proyect, string objetivo_proyect, int state_proyect, 
            string logo_proyect, string alcance_proyect)
        {
            using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["HelpDeskConnectionString"].ToString()))
            {
                cn.Open();
                SqlCommand cmdact = new SqlCommand();
                cmdact.CommandText = "INSERT INTO proyect" +
                    "(name_proyect,datein_proyect,datemsx_proyect," +
                    "estado_proyect,presupuesto_proyect,percent_proyect,desc_proyect," +
                    "id_tproy,form_id,link_proyect,objetivo_proyect," +
                    "state_proyect,logo_proyect,alcance_proyect)" +
                    " values(@name_proyect,@datein_proyect,@datemsx_proyect," +
                    "@estado_proyect,@presupuesto_proyect,@percent_proyect,@desc_proyect," +
                    "@id_tproy,@form_id,@link_proyect,@objetivo_proyect," +
                    "@state_proyect,@logo_proyect,@alcance_proyect)";
                cmdact.CommandType = CommandType.Text;
                cmdact.Connection = cn;
                cmdact.Parameters.AddWithValue("@name_proyect", name_proyect);
                cmdact.Parameters.AddWithValue("@datein_proyect", datein_proyect);
                cmdact.Parameters.AddWithValue("@datemsx_proyect", datemsx_proyect);
                cmdact.Parameters.AddWithValue("@estado_proyect", estado_proyect);
                cmdact.Parameters.AddWithValue("@presupuesto_proyect", presupuesto_proyect);
                cmdact.Parameters.AddWithValue("@percent_proyect", percent_proyect); //valor de la derecha
                cmdact.Parameters.AddWithValue("@desc_proyect", desc_proyect);
                cmdact.Parameters.AddWithValue("@id_tproy", id_tproy);
                cmdact.Parameters.AddWithValue("@form_id", form_id);
                cmdact.Parameters.AddWithValue("@link_proyect", link_proyect);
                cmdact.Parameters.AddWithValue("@objetivo_proyect", objetivo_proyect);
                cmdact.Parameters.AddWithValue("@state_proyect", state_proyect);
                cmdact.Parameters.AddWithValue("@logo_proyect", logo_proyect);
                cmdact.Parameters.AddWithValue("@alcance_proyect", alcance_proyect);

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


        public void update_Project_SQL(int id_proj,string name_proyect, DateTime datein_proyect, DateTime datemsx_proyect,
            string estado_proyect, double presupuesto_proyect, double percent_proyect, string desc_proyect,
            int id_tproy, int form_id, string link_proyect, string objetivo_proyect, int state_proyect,
            string logo_proyect, string alcance_proyect)
        {
            using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["HelpDeskConnectionString"].ToString()))
            {
                cn.Open();
                SqlCommand cmdact = new SqlCommand();
                cmdact.CommandText = "UPDATE proyect set " +
                    "name_proyect=@name_proyect,datein_proyect=@datein_proyect,datemsx_proyect=@datemsx_proyect," +
                    "estado_proyect=@estado_proyect,presupuesto_proyect=@presupuesto_proyect,percent_proyect=@percent_proyect,desc_proyect=@desc_proyect," +
                    "id_tproy=@id_tproy,form_id=@form_id,link_proyect=@link_proyect,objetivo_proyect=@objetivo_proyect," +
                    "state_proyect=@state_proyect,logo_proyect=@logo_proyect,alcance_proyect=@alcance_proyect " +                    
                    "where id_proyect = @id_proyect";
                cmdact.CommandType = CommandType.Text;
                cmdact.Connection = cn;
                cmdact.Parameters.AddWithValue("@id_proyect", id_proj);
                cmdact.Parameters.AddWithValue("@name_proyect", name_proyect);
                cmdact.Parameters.AddWithValue("@datein_proyect", datein_proyect);
                cmdact.Parameters.AddWithValue("@datemsx_proyect", datemsx_proyect);
                cmdact.Parameters.AddWithValue("@estado_proyect", estado_proyect);
                cmdact.Parameters.AddWithValue("@presupuesto_proyect", presupuesto_proyect);
                cmdact.Parameters.AddWithValue("@percent_proyect", percent_proyect); //valor de la derecha
                cmdact.Parameters.AddWithValue("@desc_proyect", desc_proyect);
                cmdact.Parameters.AddWithValue("@id_tproy", id_tproy);
                cmdact.Parameters.AddWithValue("@form_id", form_id);
                cmdact.Parameters.AddWithValue("@link_proyect", link_proyect);
                cmdact.Parameters.AddWithValue("@objetivo_proyect", objetivo_proyect);
                cmdact.Parameters.AddWithValue("@state_proyect", state_proyect);
                cmdact.Parameters.AddWithValue("@logo_proyect", logo_proyect);
                cmdact.Parameters.AddWithValue("@alcance_proyect", alcance_proyect);

                cmdact.ExecuteNonQuery();
                cn.Close();
            }
        }
    }
}
