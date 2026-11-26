using Fitness_tracking_software;
using Fitness_tracking_software.Class;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fitness_tracking_software
{

    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
    
        int failLoginAttempt = 0;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string pwd = txtPassword.Text;

            if (userName == "" || pwd == "")
            {
                MessageBox.Show("Please, fill your account name and password!");
                return;
            }

            User user = new User();

            if(user.login(userName, pwd)) 
            {

                MessageBox.Show("Login successful!");
                this.Hide(); 

                
                
                frmActivity activityForm = new frmActivity(user);
                activityForm.ShowDialog();
            }
            else
            {
                failLoginAttempt++;
                MessageBox.Show("Unsuccessful login!!!!!!");

                    if (failLoginAttempt == 5)
                    {
                        timer1.Interval = 5000; //5sec freeze
                        timer1.Start();
                        txtUserName.ReadOnly = true;
                        txtPassword.ReadOnly = true;
                        btnLogin.Enabled = false;
                    MessageBox.Show("Too many Attempt!!! Wait 5sec and try again...", "Your cannot write right now!",MessageBoxButtons.OK,MessageBoxIcon.Warning); 
                    }
                
            }
        }
        

     

        private void linkedLblLogin_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmRegister registerForm = new frmRegister();
            registerForm.ShowDialog();
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            txtUserName.ReadOnly = false;
            txtPassword.ReadOnly = false;
            btnLogin.Enabled = true;
            lblErrorMsg.Text = "";
            failLoginAttempt = 0;
        }

        bool flag = false;
        private void btnShowHide_Click(object sender, EventArgs e)
        {
            if (flag == true)
            {
                flag = false;
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

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

