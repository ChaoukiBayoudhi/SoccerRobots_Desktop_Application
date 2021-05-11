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
            AddTeamForm atf = new AddTeamForm(dataGridView1);
            atf.Show();
        }

        private void bt_ModifyTeam_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dataGridView1.CurrentRow.Index;
                if(index ==-1)
                    throw new Exception("You should select a line on the datagrid to update it"); ;
                int id = (int)dataGridView1[0, index].Value;
                Team team = getAllTeams().Find(x => x.Id == id);
                AddTeamForm adf = new AddTeamForm(team, dataGridView1);
                adf.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
           
        }
        public static List<Team> getAllTeams()
        {
            List<Team> lstTeams = new List<Team>();
            //Connected Mode
            //based on SQL Request
            //this mode uses 3 classes : xyzConnection, xyzCommand, xyzDataReader
            //for example xyz could be Oracle ==>DBMS Oracle,  Mysql ===>DBMS Mysql, sql==>Sql Server
            //1-create connection using Connection class
            SqlConnection con;
            try
            {
                using (con = new SqlConnection(@"Data Source=DESKTOP-7J9ODH9;Initial Catalog=SoccerRobotDB;Integrated Security=True;Pooling=False"))
                {

                    //2-open the connection
                    con.Open();

                    //3-create the command object
                    SqlCommand cmd = new SqlCommand("select * from [Team]", con);

                    //4-Execute command
                    //three posibilities
                    //cmd.executeReader()===>select
                    //or cmd.ExecuteNonQuery() ===>insert/update/delete
                    //or cmd.ExecuteScalar() ==>select Max, Min, AVG, count, SUM (aggregation)
                    SqlDataReader DR = cmd.ExecuteReader();
                    //DR is like the table team

                    //convert DataReader on List
                    //The method DR.Read() get a row from DR
                    //to get a column value from DR 
                    //Get[Type]("column_name" or index)
                    //with type could be Int32 if the column type is int
                    //String if the column type is String ....
                    //Convert from DataReader To List of Teams
                    while (DR.Read())
                    {
                        Team t = new Team();
                        t.Id = DR.GetInt32(0);
                        t.Name = DR.GetString(1);
                        t.Color = DR.GetString(2);
                        lstTeams.Add(t);

                    }
                    DR.Close();
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
            return lstTeams;

        }

        private void TeamDashbord_Load(object sender, EventArgs e)
        {
            
            dataGridView1.DataSource = getAllTeams();               
        }

        private void bt_DeleteTeam_Click(object sender, EventArgs e)
        {
            Boolean deleted = false;
            try
            {
                int index = dataGridView1.CurrentRow.Index;
                if (index == -1)
                    throw new Exception("You should select a line on the datagrid to remove it"); ;
                int id = (int)dataGridView1[0, index].Value;
                DialogResult confirmation = MessageBox.Show("You want really delete the selected team ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmation == DialogResult.Yes)
                {
                    SqlConnection con;
                    using (con = new SqlConnection(@"Data Source=DESKTOP-7J9ODH9;Initial Catalog=SoccerRobotDB;Integrated Security=True;Pooling=False"))
                    {

                        //2-open the connection
                        con.Open();

                        //3-create the command object
                        SqlCommand cmd = new SqlCommand("delete from [Team] where id=" + id, con);

                        //4-Execute command
                        //three posibilities
                        //cmd.executeReader()===>select
                        //or cmd.ExecuteNonQuery() ===>insert/update/delete
                        //or cmd.ExecuteScalar() ==>select Max, Min, AVG, count, SUM (aggregation)
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("The Team has been successfuly deleted");
                        deleted = true;

                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (deleted)
                {
                    this.dataGridView1.DataSource = null;
                    this.dataGridView1.DataSource = TeamDashbord.getAllTeams();
                }

            }
        }
           
        
    }
}
