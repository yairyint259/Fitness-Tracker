using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Fitness_tracking_softwareClass;
using MySql.Data.MySqlClient;

namespace Fitness_tracking_software.Class
{
    public class User
    {
        //apply encapsulation 
        private int userid;
        private string username;
        private string password;
        private double goal;

        public int ID
        {
            get { return userid; }
            set { userid = value; }
        }

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public double Goal   //Goal encapsulation 
        {
            get { return goal; }
            set { Goal = value; }
        }


        //create db object
        DatabaseCN dbConnect = new DatabaseCN();

        //register method
        public void register(string u, string p)
        {
            this.username = u;
            this.password = p;

            dbConnect.CnOpen();

            string query = $"select * from user where username='{this.username}';";

            MySqlDataReader dr = dbConnect.dataReader(query);

            if (dr.Read()) //for data row exist
            {
                MessageBox.Show("Username is already exist!");
            }
            else
            {
                dr.Close();
                string insertQuery = "insert into user (username,password) values ('" + this.username + "', '" + this.password + "');";
                dbConnect.executeQuery(insertQuery);
                MessageBox.Show("Account created sucessfully!!", "Congratulation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            dbConnect.CnClose();

        }

        //Login Method 

        public bool login(string unanme, string pwd)
        {
            this.Username = unanme;
            dbConnect.CnOpen();

            string query = "select username from user where username = @username and password=@password";

            MySqlCommand cmd = new MySqlCommand(query, dbConnect.cn);
            cmd.Parameters.AddWithValue("@username", this.Username);
            cmd.Parameters.AddWithValue("@password", pwd);

            MySqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {

                this.username = dr.GetString("username");

                dr.Close();
                dbConnect.CnClose();
                return true;
            }
            else
            {
                dr.Close();
                dbConnect.CnClose();
                return false;
            }

        }



        //load activity page
        public void loadGoal(TextBox txtGoal, Button btnSetGoal, Button btnUpdateGoal, Button btnForward)
        {

            dbConnect.CnOpen();
            string query = "select target_goal from user where username= @username;";

            MySqlCommand cmd = new MySqlCommand(query, dbConnect.cn);
            cmd.Parameters.AddWithValue("@username", this.Username);

            object result = cmd.ExecuteScalar();

            if (result == DBNull.Value || result == null || Convert.ToDouble(result) == 0)
            {
                txtGoal.Text = "0";
                txtGoal.ReadOnly = false;
                btnForward.Visible = false;
                btnUpdateGoal.Visible = false;
                btnSetGoal.Visible = true;
            }
            else
            {
                double resultGoal = Convert.ToDouble(result);
                btnSetGoal.Visible = false;
                btnForward.Visible = true;
                txtGoal.ReadOnly = true;
                txtGoal.Text = resultGoal.ToString();
               
            }

            dbConnect.CnClose();
        }

        //setup new user goal method
        public void setUpGoal(double goal)
        {
            this.goal = goal;
            dbConnect.CnOpen();
            string updateQuery = "update user set target_goal = @goal where username = @username;";

            MySqlCommand cmd = new MySqlCommand(updateQuery, dbConnect.cn);
            cmd.Parameters.AddWithValue("@goal", goal);
            cmd.Parameters.AddWithValue("@username", this.username);

            int eRow = cmd.ExecuteNonQuery(); //check execute row

            if (eRow > 0)
            {
                MessageBox.Show("Your target goal set successfully!");
            }

            dbConnect.CnClose();

        }


        //update user goal method
        public void updateGoal(double newGoal,string username)
        {
            this.goal = newGoal;

            dbConnect.CnOpen();

            string query = "select target_goal from user where username = @username;";
            MySqlCommand cmd = new MySqlCommand(query, dbConnect.cn);
            cmd.Parameters.AddWithValue("@username", username);

            MySqlDataReader dr = cmd.ExecuteReader();
               
            if (dr.Read())
            {
                if (!dr.IsDBNull(dr.GetOrdinal("target_goal"))) //if current user goal in db is not null
                {
                    double currentGoal = dr.GetDouble("target_goal");

                    DialogResult result = MessageBox.Show($" Do yout want update current goal?", "Update Goal", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    dr.Close();

                    //update if yes
                    if (result == DialogResult.Yes)
                    {
                        dr.Close(); //stop reading
                        string updateQuery = "update user set target_goal=@newGoal where username=@username;";

                        MySqlCommand updateCmd = new MySqlCommand(updateQuery, dbConnect.cn);
                        updateCmd.Parameters.AddWithValue("@newGoal", newGoal);
                        updateCmd.Parameters.AddWithValue("@username", username);

                        updateCmd.ExecuteNonQuery();

                        MessageBox.Show("Your goal is update successfully");
                    }
                    else
                    {
                        MessageBox.Show("Cancelled!!");
                    }

                }

            }
            else
            {
                dr.Close();
                
            }
            dbConnect.CnClose();

        }



        //get user target goal for report
        public double getTargetGoal(TextBox txtTargetGoal)
        {
            double goal = 0;
            dbConnect.CnOpen();
            string query = @"select target_goal from user where username =@username;";
            MySqlCommand cmd = new MySqlCommand(query, dbConnect.cn);
            cmd.Parameters.AddWithValue("@username", this.username); //call parameter to add new goal
            object result = cmd.ExecuteScalar();

            if (result != null && result != DBNull.Value)
            {

                goal = Convert.ToDouble(result);
                txtTargetGoal.Text = goal.ToString();
            }


            dbConnect.CnClose();
            return goal;
        }

        //reset goal
        public void resetTargetGoal()
        {
            dbConnect.CnOpen();

            string query = "update user set target_goal = 0 where username = @username";

            using (MySqlCommand cmd = new MySqlCommand(query, dbConnect.cn))
            {
                cmd.Parameters.AddWithValue("@username",this.username);
                cmd.ExecuteNonQuery();
                dbConnect.CnClose();
            }
           
        }

        
    }

}
    
   

