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
            
        }
    }
}
