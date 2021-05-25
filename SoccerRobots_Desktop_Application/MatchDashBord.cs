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
    public partial class MatchDashBord : Form
    {
        public MatchDashBord()
        {
            InitializeComponent();
        }

        private void bt_AddMatch_Click(object sender, EventArgs e)
        {
            AddModifyMatch amm = new AddModifyMatch(dataGridView1);
            amm.Show();
        }

        private void bt_modifyMatch_Click(object sender, EventArgs e)

        {
            Match m1 = new Match();
            AddModifyMatch amm = new AddModifyMatch(dataGridView1,m1);
            amm.Show();
        }

        private void bt_statistics_Click(object sender, EventArgs e)
        {
            MatchStatistics ms = new MatchStatistics();
            ms.Show();
        }

        private void MatchDashBord_Load(object sender, EventArgs e)
        {

        }
    }
}
