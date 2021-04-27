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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void addTeamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTeamForm atf = new AddTeamForm();
            atf.MdiParent = this;//on a effectué le lien entre les deux formes
            atf.Show();
        }

        private void showTeamsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TeamDashbord td = new TeamDashbord();
            td.MdiParent = this;
            td.Show();
        }
    }
}
