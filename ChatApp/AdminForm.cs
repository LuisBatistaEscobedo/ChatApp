using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ChatApp
{
    public partial class AdminForm : Form
    {
        AllUsers form01 = new AllUsers();
        AllComments form02 = new AllComments();
        public AdminForm()
        {
            InitializeComponent();
        }

       private void AdminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void buttonAllUsers_Click(object sender, EventArgs e)
        {
            this.Hide();
            form01.ShowDialog();
        }

        private void buttonAllComments_Click(object sender, EventArgs e)
        {
            this.Hide();
            form02.ShowDialog();
        }
    }
}
