using Fitness_tracking_software.Class;
using Fitness_tracking_software;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fitness_tracking_software
{
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        User u = new User();
        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username=txtUserName.Text;
            string pwd=txtPassword.Text;
            string confirmPwd=txtCfmPassword.Text;


            //define regular experssion patterns
            string userNamePattern = "^[a-zA-Z0-9]*$";
            string passwordPattern = "^(?=.*[a-z])(?=.*[A-Z]).{12}$";

            //initialize error message
            String errorMessage = "";
            if (username == "" || string.IsNullOrEmpty(pwd) || string.IsNullOrEmpty(confirmPwd))
            {
                errorMessage = "All information is needed to fill for creating a new account \n";
            }
            else
            {
                if (!Regex.IsMatch(username, userNamePattern))
                {
                    errorMessage += "Invalid Username!!";
                }
                if (!Regex.IsMatch(pwd, passwordPattern))
                {
                    errorMessage += "Invalid Password!! \n Length must be 12 words \n At least contain one Upper and Lower Character \n";
                }

                if (pwd != confirmPwd)
                {
                    errorMessage += "Password does not match !";
                }
            }

            //output error message
            if (!string.IsNullOrEmpty(errorMessage))
            {
                MessageBox.Show(errorMessage, "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else //create acc
            {
                u.register(username, pwd); //function call

                txtUserName.Clear();
                txtPassword.Clear();
                txtCfmPassword.Clear();
            
            }
            }

        bool flag = false;
        private void btnShowHide_Click(object sender, EventArgs e)
        {
            if (flag == true)
            {
                flag=false;
                btnShowHide.BackgroundImage = Properties.Resources.SharinganOpenEye;
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                flag = true;
                btnShowHide.BackgroundImage = Properties.Resources.hiddenEye;
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        bool flag1 = false;
        private void btnShowHideConfirm_Click(object sender, EventArgs e)
        {
            if (flag1 == true)
            {
                flag1 = false;
                btnShowHideConfirm.BackgroundImage = Properties.Resources.SharinganOpenEye;
                txtCfmPassword.UseSystemPasswordChar = false;
            }
            else
            {
                flag1 = true;
                btnShowHideConfirm.BackgroundImage = Properties.Resources.hiddenEye;
                txtCfmPassword.UseSystemPasswordChar = true;
            }
        }

        private void linkedLblRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmLogin loginForm = new frmLogin();
           loginForm.ShowDialog();
        }

        private void frmRegister_Load(object sender, EventArgs e)
        {

        }
    }
}
