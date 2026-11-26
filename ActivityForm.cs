using Fitness_tracking_software.Class;
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
    public partial class frmActivity : Form
    {
        private User user;
       
        public frmActivity(User user)
        {
            InitializeComponent();
            this.user = user;
            
        }
      
        ResultReport r = new ResultReport();
        private void frmActivity_Load(object sender, EventArgs e)
        {
            lblCurrentUser.Text = user.Username;//get profile name from login

            //check target goal cycle is complete
            bool weeklySuccess = r.setWeeklyCycle(user);

            if (weeklySuccess)
            {
                txtGoal.Text = "0";
                txtGoal.ReadOnly=false;
                btnUpdateGoal.Visible = true;
                btnSetGoal.Visible = false;
                btnForward.Visible= false;

                user.resetTargetGoal();
            }
            else
            {
               
                txtGoal.ReadOnly = true;
                btnUpdateGoal.Visible =false;
            }
            user.loadGoal(txtGoal, btnSetGoal, btnUpdateGoal, btnForward); //call goal load function


        }

        //show options of selected activity
        private void cboActivity_SelectedIndexChanged(object sender, EventArgs e)
        {


            string selectedActivity = cboActivity.SelectedItem.ToString();
            WorkoutActivity activityObject = new WorkoutActivity();

            List<String> options = activityObject.getOptionList(selectedActivity);

            if (options.Count == 3)
            {

                rdoBtnOption1.Text = options[0];
                rdoBtnOption2.Text = options[1];
                rdoBtnOption3.Text = options[2];

                rdoBtnOption1.Visible = true;
                rdoBtnOption2.Visible = true;
                rdoBtnOption3.Visible = true;
            }        
            
        }

        //go to calculator page if catch condition
        private void btnSetGoal_Click(object sender, EventArgs e)
        {
            //catch goal input
         
            if (txtGoal.Text == "")
            {
                MessageBox.Show("Please Enter Your Target Goal");
                txtGoal.Focus();
               
            }
            else
            {
                double userGoal = Convert.ToDouble(txtGoal.Text);
                user.setUpGoal(userGoal);
                MessageBox.Show("Goal Set Sucessfully!!");
                btnForward.Visible = true;
                btnSetGoal.Visible = false;
                btnUpdateGoal.Visible = true;

            }
        }
        private void btnUpdateGoal_Click(object sender, EventArgs e)
        {

            if (txtGoal.Text == "")
            {
                MessageBox.Show("Please Enter Your Target Goal");
                txtGoal.Focus();
            }
            else
            {
                double userGoal = Convert.ToDouble(txtGoal.Text);
                user.updateGoal(userGoal,user.Username);
                MessageBox.Show("Saving Goal!!");
                btnForward.Visible = true;
                btnSetGoal.Visible = false;
            }
        }


        private void btnForward_Click(object sender, EventArgs e)
        {
           

            //catch selection 
            string selectOption = "";
            if (rdoBtnOption1.Checked)
            {
                selectOption = rdoBtnOption1.Text;
            }
            else if (rdoBtnOption2.Checked)
            {
                selectOption = rdoBtnOption2.Text;
            }
            else if (rdoBtnOption3.Checked)
            {
                selectOption = rdoBtnOption3.Text;
            }
            else
            {
                MessageBox.Show("Please select an option");
                return;
            }
            string selectedActivity = cboActivity.SelectedItem.ToString(); 

           
            METLVL metobj = new METLVL();  
            double metValue = metobj.getMETLevel(selectOption);  //get met value

            WorkoutActivity activity = new WorkoutActivity(); 
            activity.SelectedOption = selectOption; 
            activity.SelectedActivity = selectedActivity;
            activity.MetValue = metValue;  //store data on activity

            //show confirmation msg to calculator
            //go calulator page,pass activity obj
            MessageBox.Show($"You selected '{selectedActivity}' with option '{selectOption}'. Moving to Calculator.","Selection Confirmed",MessageBoxButtons.OK,MessageBoxIcon.Information);  
            this.Hide();
            frmCalculator calculatorForm = new frmCalculator(user,activity);
            calculatorForm.ShowDialog();
        }

       
        //enter double only for goal input
        private void txtGoal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar)||Char.IsWhiteSpace(e.KeyChar)||Char.IsSymbol(e.KeyChar))
      
            {
                e.Handled = true;
     
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
