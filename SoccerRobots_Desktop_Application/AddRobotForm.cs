using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoccerRobots_Desktop_Application
{
    public partial class AddRobotForm : Form
    {
        private DataGridView dataGridView1;
        private Robot robot1;

        public AddRobotForm()
        {
            InitializeComponent();//initialize the graphic controls properties
            //without calling this method you'll an empty Form
        }

        public AddRobotForm(DataGridView dataGridView1) //surcharge of the constructor
        {
            InitializeComponent();
            this.dataGridView1 = dataGridView1;
        }

        public AddRobotForm(Robot robot1, DataGridView dataGridView1)
        {
            InitializeComponent();

            this.robot1 = robot1;
            this.dataGridView1 = dataGridView1;
        }

        private void bt_AddRobot_Click(object sender, EventArgs e)
        {
            //insert a new Robot on the database

            //Connected mode
            //this mode is based on SQL request
            //This mode is based  on using three classes :
            //1-xyzConnection --> used to specify the connection properties with the database like username, password, path,...
            //2-xyzCommand --> used to introduce the SQL request and execuste it on the database 
            //three cases are possible :
            //ExecuteReader()--> if we want to execute Select ..from...
            //ExecuteNonQuery()--> if we want to execute insert or update or delete
            //ExecuteScalar() --> if we want to execute select count or Max, Min,AVG,Sum
            //3-xyzDataReader --> this class is used to get the  select request result (equals to a sql table)

            //the prefix "xyz" is fixed based on the SGBD
            //for example for oracle use ==> OracleConnection, OracleCommand, OracleDataReader
            //for example for MySQL use ==> MySqlConnection, MySqlCommand, MySqlDataReader
            //for example for Sql Server use ==> SqlConnection, SqlCommand, SqlDataReader

            //first step : create the connection object
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-7J9ODH9;Initial Catalog=SoccerRobotDB;Integrated Security=True;Pooling=False");
            //Secod step : Open the connection
            con.Open();
            MessageBox.Show((con.State == ConnectionState.Open).ToString());





        }
    }
}
