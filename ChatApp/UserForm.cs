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
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
            this.Text = "Chat Application";
        }
        static string server = "127.0.0.1";
        static string username = "root";
        static string database = "chat_room_db";
        static DateTime localDate = DateTime.Now;
        static string sqlFormattedDate = localDate.ToString("yyyy-MM-dd HH:mm:ss.fff");

        static string connection = "server=" + server + ";" + "uid=" + username + ";" + "database=" + database + ";" + "SslMode=none;";

        MySqlConnection con = new MySqlConnection(connection);
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataReader sqlRd;

        private void UserForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            dataGridCommentHistory.DataSource = grid_history();

            dataGridCommentHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            dataGridChat.DataSource = grid_comments();

            dataGridChat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        }

        public DataTable grid_history()
        {
            MySqlDataAdapter data = new MySqlDataAdapter(cmd);

            DataTable table = new DataTable();

            try
            {
                cmd.Connection = con;

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.CommandText = "all_comments";

                data.Fill(table);

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            return table;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult exitForm;
            try
            {

                exitForm = MessageBox.Show("Are you sure you want to exit the app?", "Chat Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (exitForm == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public DataTable grid_comments()
        {
            MySqlDataAdapter data = new MySqlDataAdapter(cmd);

            DataTable table = new DataTable();

            try
            {
                cmd.Connection = con;

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.CommandText = "recent_comments";

                data.Fill(table);

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            return table;
        }

        private void buttonSendComment_Click(object sender, EventArgs e)
        {
            string userId = Login.userId;

            if (string.IsNullOrWhiteSpace(textBoxComment.Text))
            {
                MessageBox.Show("Please fill the comment section. " + localDate);
            }
            else
            {
                try
                {
                    con.Open();

                    String sqlQuery = "INSERT INTO comments (id, user_id, body, date) VALUES (NULL, '" + userId + "','" + textBoxComment.Text + "' ,'" + sqlFormattedDate + "')";

                    cmd = new MySqlCommand(sqlQuery, con);

                    sqlRd = cmd.ExecuteReader();

                    con.Close();

                    MessageBox.Show("Comment added!");

                    dataGridChat.DataSource = grid_comments();

                    textBoxComment.Clear();

                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
        }
    }
}
