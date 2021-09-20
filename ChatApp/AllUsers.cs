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
    public partial class AllUsers : Form
    {
        public AllUsers()
        {
            InitializeComponent();
            this.Text = "All Users on DB";
        }
        static string server = "127.0.0.1";
        static string username = "root";
        static string database = "chat_room_db";

        static string connection = "server=" + server + ";" + "uid=" + username + ";" + "database=" + database + ";" + "SslMode=none;";

        MySqlConnection con = new MySqlConnection(connection);
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataReader sqlRd;

        private void AllUsers_Load(object sender, EventArgs e)
        {
            gridAllUsers.DataSource = grid();

            gridAllUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        public DataTable grid()
        {
            DataTable table = new DataTable();

            try
            {
                con.Open();

                String filltable = "select * from users";

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

        private void buttonDrop_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(gridAllUsers.CurrentRow.Cells[0].Value);

            if (id != 0)
            {

                try
                {
                    con.Open();

                    String sqlQueryDel = "DELETE FROM users WHERE users.user_id = " + id;

                    cmd = new MySqlCommand(sqlQueryDel, con);

                    sqlRd = cmd.ExecuteReader();



                    con.Close();

                    MessageBox.Show("User dropped!");

                    gridAllUsers.DataSource = grid();

                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select a valid user.");
            }
        }

        private void buttonAllUsersExit_Click(object sender, EventArgs e)
        {
            DialogResult exitForm;
            try
            {

                exitForm = MessageBox.Show("Are you sure you want to exit the app?", "All users DB", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

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

        private void buttonStatusChange_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(gridAllUsers.CurrentRow.Cells[0].Value);

            if (id != 0)
            {

                try
                {
                    con.Open();

                    string sqlQueryUpd;

                    string currentStatusUser = gridAllUsers.CurrentRow.Cells[3].Value.ToString();

                    if(currentStatusUser == "ACTIVE")
                    {
                        sqlQueryUpd = "UPDATE users SET status = 'INACTIVE' WHERE users.user_id = " + id;
                        cmd = new MySqlCommand(sqlQueryUpd, con);
                        currentStatusUser = "INACTIVE";
                    } else if(currentStatusUser == "INACTIVE")
                    {
                        sqlQueryUpd = "UPDATE users SET status = 'ACTIVE' WHERE users.user_id = " + id;
                        cmd = new MySqlCommand(sqlQueryUpd, con);
                        currentStatusUser = "ACTIVE";
                    }

                    sqlRd = cmd.ExecuteReader();

                    con.Close();

                    MessageBox.Show("User stauts changed to "+ currentStatusUser + "!");

                    gridAllUsers.DataSource = grid();

                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select a valid user.");
            }
        }
    }
}
