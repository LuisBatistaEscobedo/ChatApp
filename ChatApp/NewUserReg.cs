using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ChatApp
{
    public partial class NewUserReg : Form
    {

        public NewUserReg()
        {
            InitializeComponent();
        }
        static string server = "127.0.0.1";
        static string username = "root";
        static string database = "chat_room_db";

        static string connection = "server=" + server + ";" + "uid=" + username + ";" + "database=" + database + ";" + "SslMode=none;";

        MySqlConnection con = new MySqlConnection(connection);
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataReader sqlRd;

        private void buttonRegUser_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxPassReg.Text) || string.IsNullOrWhiteSpace(textBoxUserNameReg.Text))
            {
                MessageBox.Show("Favor de llenar todos los campos");
            }
            else
            {
                try
                {
                    con.Open();

                    String sqlQuery = "INSERT INTO users (user_id, name, password, status, auth_type) VALUES (NULL, '" + textBoxUserNameReg.Text + "', '" + textBoxPassReg.Text + "', 'ACTIVE', 'user')";

                    cmd = new MySqlCommand(sqlQuery, con);

                    sqlRd = cmd.ExecuteReader();

                    con.Close();

                    MessageBox.Show("Registro agredado!");

                    clear_AllFields();


                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }

                this.DialogResult = DialogResult.OK;
            }
        }

        private void clear_AllFields()
        {
            textBoxPassReg.Clear();
            textBoxUserNameReg.Clear();

        }
    }
}
