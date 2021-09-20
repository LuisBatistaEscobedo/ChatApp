using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Capa_Entidad;
using Capa_Negocio;

namespace ChatApp
{
    public partial class Login : Form
    {
        E_Users objEUser = new E_Users();
        N_Users objNUser = new N_Users();
        AdminForm form01 = new AdminForm();
        UserForm form02 = new UserForm();
        NewUserReg form03 = new NewUserReg();

        public static string userId;
        public static string userName;
        public static string status;
        public static string authType;

        void loginRoutine()
        {
            DataTable dt = new DataTable();
            objEUser.usuario = textBoxUserName.Text;
            objEUser.clave = textBoxPass.Text;

            dt = objNUser.N_user(objEUser);

            if(dt.Rows.Count > 0)
            {
                MessageBox.Show("Welcome " + dt.Rows[0][1].ToString(), "Mensaje", MessageBoxButtons.OK,MessageBoxIcon.Information);
                userName = dt.Rows[0][1].ToString();
                status = dt.Rows[0][3].ToString();
                authType = dt.Rows[0][4].ToString();

                //Login login = new Login();
                //login.ShowDialog();

                if (status == "ACTIVE" && authType == "admin")
                {
                    this.Hide();
                    form01.ShowDialog();
                    
                }else if(status == "ACTIVE" && authType == "user")
                {
                    userId = dt.Rows[0][0].ToString();
                    this.Hide();
                    form02.Show();
                }
                else if(status == "INACTIVE") 
                {
                    MessageBox.Show("Inactive User", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                textBoxUserName.Clear();
                textBoxPass.Clear();
            }
            else
            {
                MessageBox.Show("Non valid user or password", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public Login()
        {
            InitializeComponent();
        }

        private void buttonLoginClick(object sender, EventArgs e)
        {
            loginRoutine();
        }

        private void buttonNewUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            form03.ShowDialog();
            this.Show();
        }
    }
}
