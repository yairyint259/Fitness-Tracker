using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient; //apply mysql 

namespace Fitness_tracking_softwareClass
{
    internal class DatabaseCN
    {
        public MySqlConnection cn;

        public MySqlConnection Connection { get; internal set; }

        public MySqlConnection dataSource()
        {
            cn = new MySqlConnection("Server=localhost;Database=fitnessdb;Uid=root;Pwd=root;");
            return cn;
        }

        public void CnOpen()
        {
            dataSource();
            cn.Open();
        }

        public void CnClose()
        {
            dataSource();
            cn.Close();
        }

        public void executeQuery(string query)
        {
            MySqlCommand cmd=new MySqlCommand(query,cn);
            cmd.ExecuteNonQuery(); // execute SQL command insert, update , delete operation
        }

        public MySqlDataReader dataReader(string query)
        {
            MySqlCommand cmd = new MySqlCommand(query,cn);
            MySqlDataReader dr=cmd.ExecuteReader();
            return dr;
        }
    }
}
