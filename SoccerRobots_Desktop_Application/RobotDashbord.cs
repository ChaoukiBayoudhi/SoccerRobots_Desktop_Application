using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoccerRobots_Desktop_Application
{
    public partial class RobotDashbord : Form
    {
        public RobotDashbord()
        {
            InitializeComponent();
        }

        private void bt_AddRobot_Click(object sender, EventArgs e)
        {
            AddRobotForm ard = new AddRobotForm(dataGridView1);
            ard.Show();
        }

        private void bt_ModifyRobot_Click(object sender, EventArgs e)
        {
            Robot Robot1 = new Robot();
            AddRobotForm ard = new AddRobotForm(Robot1,dataGridView1);
            ard.Show();
        }

        private void RobotDashbord_Load(object sender, EventArgs e)
        {

        }
    }
}
