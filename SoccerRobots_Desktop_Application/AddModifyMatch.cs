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
    public partial class AddModifyMatch : Form
    {
        private DataGridView dataGridView1;
        private Match match;
        private string Action;
       

        public AddModifyMatch()
        {
            InitializeComponent();
        }

        public AddModifyMatch(DataGridView dataGridView1)
        {
            InitializeComponent();
            this.Action = "Add";
            this.dataGridView1 = dataGridView1;
        }

        public AddModifyMatch(DataGridView dataGridView1, Match match)
        {
            this.match = match;
            InitializeComponent();
            this.Action = "Modify";
            this.dataGridView1 = dataGridView1;
        }

        private void AddModifyMatch_Load(object sender, EventArgs e)
        {
        //    cmb_IdTeamA.DataSource = (from t in MatchDashBord.dbRC.Teams
        //                             select t.Id).ToList<int>();
        //    cmb_IdTeamB.DataSource = (from x in MatchDashBord.dbRC.Teams
        //                             select x.Id).ToList<int>();
        //    cmb_IdPitch.DataSource = (from p in MatchDashBord.dbRC.FootPitches
        //                              select p.id).ToList<int>();
        
        }

        private void bt_AddModify_Click(object sender, EventArgs e)
        {
            //Linq n'est pas basé sur des requetes SQL
            //Linq use only c# and the OO
            if(Action=="Add")
            {
                try
                {
                    //Match m1 = new Match();
                    //m1.IdTeamA = int.Parse(cmb_IdTeamA.Text);
                    //m1.IdTeamB = int.Parse(cmb_IdTeamB.Text);
                    //m1.IdFootPitch = int.Parse(cmb_IdPitch.Text);
                    //m1.StartTime = dtp_StartTime.Value;
                    //MatchDashBord.dbRC.Matches.InsertOnSubmit(m1);//add the object match to the propertie Matches
                    //MatchDashBord.dbRC.SubmitChanges();//add a new lined to the match table (on the database)


                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }


            }
            else
            {

            }
        }
    }
}
