using Fitness_tracking_software.Class;
using MySqlX.XDevAPI.Common;
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
    public partial class frmCalculator : Form
    {
        private User user;
        private WorkoutActivity a;
        
        public frmCalculator(User user,WorkoutActivity activity)
        {

            InitializeComponent();
            this.user = user;
            this.a=activity;
        }
       
        private void frmCalculator_Load(object sender, EventArgs e)
        {
           

                //call met lvl from activity page
                txtMETlvl.Text = a.MetValue.ToString();
            txtMETlvl.ReadOnly = true;

            //call username from user page
            lblCurrentUser.Text= user.Username;

            //call useroption from activity page
            txtUserOption.Text= a.SelectedOption;
            txtUserOption.ReadOnly= true;
           
            txtTotal.ReadOnly=true;
        }

        Class.ResultReport r = new Class.ResultReport(); // create report obj
      
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double weight;
            int activityTime;
            double MET = Convert.ToDouble(txtMETlvl.Text);

            //check user input

            

            if (string.IsNullOrWhiteSpace(txtWeight.Text) || string.IsNullOrWhiteSpace(txtTime.Text))
            {
                MessageBox.Show("Please Input Your Weight Or Activity Time", "Empty Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            //check user write wrong input like string for double

            if(!double.TryParse(txtWeight.Text, out weight) || !int.TryParse(txtTime.Text, out activityTime))
            {
                MessageBox.Show("Please Enter a Valid Number.","Input Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            if (activityTime < 1 || activityTime > 500)
            {
                MessageBox.Show("ACtivity time must be between 1 and 500 minutes", "Invalid Time", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (weight <= 0)
            {
                MessageBox.Show("Weight must be greater than 0.", "Invalid Weight", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }
            //choose lbl or kg for weight
            
            if (cboWeight.SelectedIndex == -1 || cboWeight.SelectedIndex == 0) //kg
            {
                if (weight > 225)
                {
                    MessageBox.Show("Maximum allowed weight is 225 kg.", "Weight Limit Exceeded", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return;
                }
            }
            else if(cboWeight.SelectedIndex == 1) 
                {

                if (weight > 500)
                {
                    MessageBox.Show("Maximum allowed weight is 500 lbs.", "Weight Limit Exceeded", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return;
                }
                weight = weight*0.45; //lbs
                }
           

            // calculate calories burned
           
            double total = (activityTime * MET * 3.5 * weight) / 200; ;

            MessageBox.Show($"Your result is {total:F2}", "Calculation Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtTotal.Text = total.ToString("F2");
          txtTotal.ReadOnly = true;
            btnCalculate.Visible = false;
          btnViewReport.Visible = true;
        }

        private void btnViewReport_Click(object sender, EventArgs e)
        {
            //return savetotalreport function and store at db
            double total = double.Parse(txtTotal.Text);
            double weight = double.Parse(txtWeight.Text);
            int time =int.Parse(txtTime.Text);
            DateTime workoutDate = r.getNextWorkoutDate(user);

             r.saveTotalReport(total, user, a, weight, time, workoutDate);

            //go report page
            this.Hide();
            frmReport reportForm = new frmReport(this.user, this.a);
            reportForm.setTotal(double.Parse(txtTotal.Text)); //give total to report
            reportForm.ShowDialog();
            


        }
    }
}
