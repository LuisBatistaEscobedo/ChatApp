using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Diagnostics;


using System.Configuration;
using MySql.Data.MySqlClient;
using Capa_Entidad;

namespace Capa_Datos
{
    public class D_Users
    {
        static string server = "127.0.0.1";
        static string username = "root";
        static string database = "chat_room_db";

        static string connection = "server=" + server + ";" + "uid=" + username + ";" + "database=" + database + ";" + "SslMode=none;";

        MySqlConnection con = new MySqlConnection(connection);

        MySqlCommand cmd = new MySqlCommand();

        public DataTable D_User(E_Users obj)
        {
            MySqlDataAdapter data = new MySqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            try
            {
                cmd.Connection = con;

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.CommandText = "user_login";

                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@na", obj.usuario);

                cmd.Parameters.AddWithValue("@pass", obj.clave);

                data.Fill(dt);

            }
            catch(Exception err)
            {
                Debug.WriteLine(err.Message);
            }

            return dt;

        }

    }
}
