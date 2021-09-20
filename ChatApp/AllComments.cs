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
    public partial class AllComments : Form
    {
        public AllComments()
        {
            InitializeComponent();
            this.Text = "All Comments on DB";
        }
        static string server = "127.0.0.1";
        static string username = "root";
        static string database = "chat_room_db";

        static string connection = "server=" + server + ";" + "uid=" + username + ";" + "database=" + database + ";" + "SslMode=none;";

        MySqlConnection con = new MySqlConnection(connection);
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataReader sqlRd;

        private void AllComments_Load(object sender, EventArgs e)
        {
            gridAllComments.DataSource = grid();

            gridAllComments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        public DataTable grid()
        {
            DataTable table = new DataTable();

            try
            {
                con.Open();

                String filltable = "SELECT id,users.name, body, date FROM comments INNER JOIN users ON comments.user_id = users.user_id";

                cmd = new MySqlCommand(filltable, con);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

                adapter.Fill(table);

                con.Close();

                MessageBox.Show("Registers load!");

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            return table;
        }

        private void buttonAllCommentsExit_Click(object sender, EventArgs e)
        {
            DialogResult exitForm;
            try
            {

                exitForm = MessageBox.Show("Are you sure you want to exit the app?", "All comments DB", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

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

        private void buttonDrop_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(gridAllComments.CurrentRow.Cells[0].Value);

            if (id != 0)
            {

                try
                {
                    con.Open();

                    String sqlQueryDel = "DELETE FROM comments WHERE comments.id = " + id;

                    cmd = new MySqlCommand(sqlQueryDel, con);

                    sqlRd = cmd.ExecuteReader();



                    con.Close();

                    MessageBox.Show("Comment dropped!");

                    gridAllComments.DataSource = grid();

                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select a valid comment.");
            }
        }
    }
}
