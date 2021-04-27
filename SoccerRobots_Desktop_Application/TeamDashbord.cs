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
    public partial class TeamDashbord : Form
    {
        public TeamDashbord()
        {
            InitializeComponent();
        }


        private void bt_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("You want really exit ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(res==DialogResult.Yes)
                this.Close();
        }

        private void bt_AddTeam_Click(object sender, EventArgs e)
        {
            AddTeamForm atf = new AddTeamForm();
            atf.Show();
        }
    }
}
