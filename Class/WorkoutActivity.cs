using Fitness_tracking_softwareClass;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness_tracking_software.Class
{
    public class WorkoutActivity //public constructor
    {
        //encapsulation activties data
        private int activityID;
        private string activityName;
        private string selectedOption;
        private double metValue;
      

        public int ActivityID
        {
            get { return activityID; }
            set { activityID = value; }
        }

        public string SelectedActivity
        {
            get { return activityName; }
            set { activityName = value; }
        }

        public string SelectedOption
        {
            get { return selectedOption;}
            set { selectedOption = value; }
        }

        public double MetValue
        {
            get{ return metValue;}
            set { metValue = value; }
        }

        
       

        
        //get option list from selected activity name
        DatabaseCN dbConnect = new DatabaseCN();
        public List<String> getOptionList(string selectedActivityName)
        {
            //db connection open
            dbConnect.CnOpen();
            this.activityName = selectedActivityName;

            string query = $"select option1,option2,option3 from workout_activity where activityName='{this.activityName}';";

            MySqlDataReader dr = dbConnect.dataReader(query);

            List<String> optionList = new List<String>();
            while(dr.Read())
            {
                optionList.Add(dr.GetString(0));
                optionList.Add(dr.GetString(1));
                optionList.Add(dr.GetString(2));
            }
            dr.Close();

            dbConnect.CnClose();
            return optionList;
        }

        
        
      


    }
}
