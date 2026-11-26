using Fitness_tracking_software.Class;
using Fitness_tracking_softwareClass;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Bcpg;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Fitness_tracking_software
{
    public partial class frmReport : Form
    {

        private User user;
        public frmReport(User user, WorkoutActivity a)
        {
            InitializeComponent();
            this.user = user;
       
        }


        DatabaseCN dbConnect = new DatabaseCN();


        ResultReport r = new ResultReport();
      

        //initialized total to fetch from calculator
        public void setTotal(double total)
        {
            txtTotalReport.Text = total.ToString();
            txtTotalReport.ReadOnly = true;
        }

        int userID;
        double weeklyTotal = 0;
        private void Report_Load(object sender, EventArgs e)
        {

            dbConnect.CnOpen();
            string userIDQuery = "SELECT id FROM user WHERE username = @username";

            MySqlCommand cmd =new MySqlCommand(userIDQuery,dbConnect.cn);
            cmd.Parameters.AddWithValue("@username",user.Username);

            object result = cmd.ExecuteScalar();
            if (result != null && result!= DBNull.Value)
             
            userID = Convert.ToInt32(result);
            
            dbConnect.CnClose();

            //get weekly total calories
            weeklyTotal = r.getWeeklyCalories(userID);

            //show weekly total
            txtTotalWeeklyReport.Text=weeklyTotal.ToString("F2");
            txtTotalWeeklyReport.ReadOnly = true;



            double target = user.getTargetGoal(txtTargetGoal); //set target goal from user at report form

            double total = Convert.ToDouble(txtTotalReport.Text);


            double progressLvl = (weeklyTotal / target) * 100; //formula for user progression


            if (progressLvl >= 100)
            {
                progressBar.Value = 100;
                lblCongrat.Text = "Congratulation!!! You weekly goal achieved :D";
                MessageBox.Show("Congratulation!!!");
            }
            else if (progressLvl < 100)
            {
                progressBar.Value = Convert.ToInt32(progressLvl);
            }
            else
            {
                progressBar.Value = 0;
            }
            lblProgressPercent.Text = progressBar.Value + "%";

            txtTargetGoal.ReadOnly = true;
           
            ChartByUser(userID); //call chart

            //show workout day count
            int workoutDays = r.showWorkOutDay(user);
            txtWorkoutDay.Text = workoutDays.ToString();
            txtWorkoutDay.ReadOnly = true;

            //calculate daycount and return form
           
            if (workoutDays >= 7)
            {
                MessageBox.Show("Your weekly goal result is completed! Please set a new goal.");


                user.resetTargetGoal();
                r.resetWeeklyReport(user); //reset weekly report


            }

              
            

        }



        //get bar chart by user db method
        private void ChartByUser( int userID, int? activityID = null)
        {
            dbConnect.CnOpen();

            string query = @"SELECT a.activityName AS activity_name, SUM(r.result) AS total_result FROM result_report r INNER JOIN workout_activity a ON r.activity_id = a.activityID WHERE r.user_id = @userID AND r.date >= DATE_SUB(CURDATE(),INTERVAL 7 DAY)";


            if (activityID.HasValue)
            {
                query += " AND r.activity_id = @activityID";
            }
            query += " GROUP BY a.activityName";

            using (MySqlCommand cmd = new MySqlCommand(query, dbConnect.cn))
            {
                cmd.Parameters.AddWithValue("@userID", userID);
                if (activityID.HasValue)
                {
                    cmd.Parameters.AddWithValue("@activityID", activityID.Value);
                }

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    chartActivity.Series.Clear();
                    chartActivity.Titles.Clear();
              
                    chartActivity.Titles.Add("Activity Results");

                    Series series = new Series
                    {
                        Name = "Result",
                        IsValueShownAsLabel = true,
                        ChartType = SeriesChartType.Column
                    };

                    chartActivity.Series.Add(series);

                    while (reader.Read())
                    {
                        string activityName = reader.GetString("activity_name");
                        double totalResult = reader.GetDouble("total_result");

                        series.Points.AddXY(activityName, totalResult);
                    }
                }
            }
            dbConnect.CnClose();
        }

        private void btn_returnReporttoActivity_Click(object sender, EventArgs e)
        {
            //DateTime nextDay = r.getNextWorkoutDate(user);

            this.Hide();
            frmActivity frmActivity = new frmActivity(user);
            frmActivity.ShowDialog();
            this.Close();
        }
    }

        

    }

           
       
       
       

    

