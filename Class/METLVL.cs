using Fitness_tracking_softwareClass;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace Fitness_tracking_software.Class
{
    internal class METLVL
    {

        //encapsulation met data
        private int metID;
        private string metName;
        private double metLevel;

        public int METID
        {
            get { return metID; }
            set { metID = value; }
        }
        public string METName
        {
            get { return metName; }
            set { metName = value; }
        }
        public double METLevel
        {
            get { return metLevel; }
            set { metLevel = value; }
        }

        //get meta data to compare with activity option MET function
        DatabaseCN dbConnect = new DatabaseCN(); 
        public double getMETLevel(string selectedOption)
        {
            dbConnect.CnOpen();
            this.metName=selectedOption;
            string query = "select metLevel from met where metName=@metName;"; //check with parameter
           
            MySqlCommand cmd= new MySqlCommand(query, dbConnect.cn);
            cmd.Parameters.AddWithValue("@metName",this.metName);

            MySqlDataReader dr = cmd.ExecuteReader();

            //if name match, ouput lvl
            if (dr.Read()) 
            { 
            this.metLevel = dr.GetDouble("metLevel");
            }
            else
            {
             this.metLevel=0;
            }

                dbConnect.CnClose();
            return this.metLevel;
        }
    }
}
