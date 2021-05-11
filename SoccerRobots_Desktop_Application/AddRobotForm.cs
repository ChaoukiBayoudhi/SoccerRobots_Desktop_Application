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
        private string Action;
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
            Action = "Add";
        }

        public AddRobotForm(Robot robot1, DataGridView dataGridView1)
        {
            InitializeComponent();

            this.robot1 = robot1;
            this.dataGridView1 = dataGridView1;
            Action = "Modify";
        }

        private void bt_AddRobot_Click(object sender, EventArgs e)
        {
            //insert a new Robot on the dataSet

            //Deconnected mode
            //1-Add a new line to the Robot table on the dataset
            //DataTable--->Tables
            //DataRow--> row on Tables
            //DataColumn -->column in Tables
            DataRow DR = RobotDashbord.DS.Tables[0].NewRow();//return a line having the structure of a row on the robot table
            //2-fill the line from the graphic controls
           // DR["Code"] = int.Parse(txt_Code.Text);
            DR[1] = float.Parse(txt_XPosition.Text);
            DR[2] = float.Parse(txt_YPosition.Text);
            DR[3] = 0;
            if (chk_HaveBall.Checked)
                DR[3] = 1;
            DR[4] = cmb_State.SelectedItem.ToString();

            //3-add the line to the table on the dataset
            RobotDashbord.DS.Tables[0].Rows.Add(DR);

            MessageBox.Show("The Robot has been successfuly added");
            //4- update the dataGridView Content
            dataGridView1.DataSource = RobotDashbord.DS.Tables[0];


        }

        private void AddRobotForm_Load(object sender, EventArgs e)
        {
            //fill the combobox with the enumeration values
            cmb_State.DataSource = Enum.GetValues(typeof(RobotState));
        }
    }
}
