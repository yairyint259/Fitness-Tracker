using Fitness_tracking_softwareClass;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Fitness_tracking_software.Class
{
 

    internal class ResultReport
    {
        //encapsulation report data
        private int reportID;
        private double result;
        private double weight;
        private int duration;
        private DateTime date;


        public int ReportID
        {
            get { return reportID; }
            set { reportID = value; }
        }

        public double Result
        {
            get { return result; }
            set { result = value; }
        }
        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        public int Duration
        {
            get { return duration; }
            set { duration = value; }
        }
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }


        DatabaseCN dbConnect = new DatabaseCN(); //create database default constructor


        //save user current data if id and activity id exist
        int activityID, userID;
        public void saveTotalReport(double total, User user, WorkoutActivity activity, double weight, int time, DateTime? customDate = null)
        {

            this.result = total;
            this.weight = weight;
            this.duration = time;
            DateTime userWorkoutDay = customDate ?? DateTime.Now;

            dbConnect.CnOpen();

            //get activity id and name for report
            string activityNameQuery = "select activityID from workout_activity where activityName=@activityName;";
            MySqlCommand cmdActivity = new MySqlCommand(activityNameQuery, dbConnect.cn);
            cmdActivity.Parameters.AddWithValue("@activityName", activity.SelectedActivity);

            object actResult = cmdActivity.ExecuteScalar();
            if (actResult == null)
            {
                dbConnect.CnClose();
                throw new Exception("invalid activity selected");
            }

            int activityID = Convert.ToInt32(actResult);

            //get user id and data for report
            string userIDquery = "select id from user where username = @username";
            MySqlCommand userCmd = new MySqlCommand(userIDquery, dbConnect.cn);
            userCmd.Parameters.AddWithValue("@username", user.Username);
            int userID = Convert.ToInt32(userCmd.ExecuteScalar());


            //MessageBox.Show($"user id is {userID} and activity id is {activityID}"); //check userid and activity correct

            //DateTime userWorkOutDay = DateTime.Now;


            string insertQuery = @"insert into result_report (result, activity_id,weight,duration,date,dayOfWeek,user_id) values (@result, @activityID, @weight, @time, @date, @dayOfWeek, @userID)";

            MySqlCommand cmd = new MySqlCommand(insertQuery, dbConnect.cn);

            cmd.Parameters.AddWithValue("@result", this.result);
            cmd.Parameters.AddWithValue("@activityID", activityID);
            cmd.Parameters.AddWithValue("@weight", this.weight);
            cmd.Parameters.AddWithValue("@time", this.duration);
            cmd.Parameters.AddWithValue("@date", userWorkoutDay);
            cmd.Parameters.AddWithValue("@dayOfWeek", userWorkoutDay.DayOfWeek.ToString());
            cmd.Parameters.AddWithValue("@userID", userID);

            //catch insert code work or not
            try
            {
                cmd.ExecuteNonQuery();

                MessageBox.Show("Result saved to Report");

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }


            dbConnect.CnClose();

        }

        //get workout day count from db
        public int showWorkOutDay(User user)
        {
            int dayCount = 0;
            dbConnect.CnOpen();

            int userID = 0;

            string userIDquery = "select id from user where username = @username";
            using (MySqlCommand userCmd = new MySqlCommand(userIDquery, dbConnect.cn))
            {
                userCmd.Parameters.AddWithValue("@username", user.Username);

                userID = Convert.ToInt32(userCmd.ExecuteScalar());
            }

            string dayQuery = @"select count(distinct date(date)) from result_report where user_id = @userID AND date >= DATE_SUB(CURDATE(),INTERVAL 7 DAY);"; //send workoutday count of weekly at report if user id exist

            using (MySqlCommand cmd = new MySqlCommand(dayQuery, dbConnect.cn))
            {
                cmd.Parameters.AddWithValue("@userID", userID);
                dayCount = Convert.ToInt32(cmd.ExecuteScalar());

            }

            dbConnect.CnClose();
            return dayCount;

        }

        public double getWeeklyCalories(int userID)
        {
            double weeklyCaloriesBurned = 0;
            dbConnect.CnOpen();

            string query = @"SELECT IFNULL(SUM(result), 0) FROM result_report WHERE user_id = @userID AND date >= DATE_SUB(CURDATE(), INTERVAL 7 DAY);";

            using (MySqlCommand cmd = new MySqlCommand(query, dbConnect.cn))
            {
                cmd.Parameters.AddWithValue("@userID", userID);
                weeklyCaloriesBurned = Convert.ToDouble(cmd.ExecuteScalar());

            }

            dbConnect.CnClose();
            return weeklyCaloriesBurned;


        }

        //get method to move next day for calories burn
        public DateTime getNextWorkoutDate(User user)
        {
           dbConnect.CnOpen();
            string query = @"select MAX(date) from result_report where user_id = (select id from user where username = @username);";

            MySqlCommand cmd = new MySqlCommand(query, dbConnect.cn);
            cmd.Parameters.AddWithValue("@username", user.Username);

            object result = cmd.ExecuteScalar();
            dbConnect.CnClose();

            //adding 1 day to esure testing so that do not need to wait for next day to test
            if(result != null && result != DBNull.Value)
            {
                DateTime previousDate = Convert.ToDateTime(result);
                return previousDate.AddDays(1);
            }

            return DateTime.Now;
        }


        //check 7 day cycle complete
        public bool setWeeklyCycle (User user)
        {
            int workoutDay = showWorkOutDay(user);
            return workoutDay >= 7;
                  
        }

        //reset previous weekly data

        public void resetWeeklyReport(User user)
        {
            dbConnect.CnOpen();

            string query = @"delete from result_report where user_id = (select id from user where username=@username) AND date >= DATE_SUB(CURDATE(),INTERVAL 7 DAY);";

            using (MySqlCommand cmd = new MySqlCommand(query, dbConnect.cn))
            {
                cmd.Parameters.AddWithValue("@username",user.Username);
                cmd.ExecuteNonQuery();
            }
            dbConnect.CnClose();
        
        }
    }
}


