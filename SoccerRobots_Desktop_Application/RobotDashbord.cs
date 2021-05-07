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
    public partial class RobotDashbord : Form
    {
        internal static DataSet DS = new DataSet();//dataset is an object structred like a local Database
        private SqlDataAdapter DA;
        private SqlConnection con;
        private SqlCommandBuilder cmdB = new SqlCommandBuilder();
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
            try
            {
                //first step : load the Robot table content into the dataset
                con = new SqlConnection(@"Data Source=DESKTOP-7J9ODH9;Initial Catalog=SoccerRobotDB;Integrated Security=True;Pooling=False");
                DA = new SqlDataAdapter("select * from Robot;", con);
                //DA = new SqlDataAdapter("select * from Robot;select * from match", con);
                //DA.TableMappings.Add("Robot", "tab_Robot");
                //DA.TableMappings.Add("Match", "tab_match");
                //MessageBox.Show(DS.Tables.Count.ToString());
                DA.Fill(DS);
                DS.Tables[0].TableName = "Tab_Robot";
                
                //Set Auto-Incriment Priamry key column for the Robot Table
                DS.Tables[0].Columns["Code"].AllowDBNull = false;
                DS.Tables[0].Columns["Code"].AutoIncrement = true;//precise si la colonne est automatiquement 
                if (DS.Tables[0].Rows.Count == 0)
                    DS.Tables[0].Columns["Code"].AutoIncrementSeed = 1;
                else
                    DS.Tables[0].Columns["Code"].AutoIncrementSeed = Convert.ToInt32(DS.Tables[0].Rows[DS.Tables[0].Rows.Count - 1]["Code"]) + 1;
                DS.Tables[0].Columns["Code"].AutoIncrementStep = 1;//l'increment à ajouter lors de chaque ajout

                dataGridView1.DataSource = DS.Tables["Tab_Robot"];
                
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void bt_DeleteRobot_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dataGridView1.CurrentRow.Index;
                if (index == -1)
                    throw new Exception("You have to select a row on the dataGrid");
                DialogResult res = MessageBox.Show("You want really delet the robot ?","Confirmation",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    //get the code value of the selected row on the datagridview
                    //int Code = (int)dataGridView1[0, index].Value;
                    //delete the line having the same index on the robot table into- dataset
                    DS.Tables[0].Rows[index].Delete();
                    dataGridView1.DataSource = DS.Tables[0];
                    MessageBox.Show("The Robot has been successufly deleted");
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void RobotDashbord_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult res = MessageBox.Show("Do you want really to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            e.Cancel = (res == DialogResult.No);
            SqlCommandBuilder cmb = new SqlCommandBuilder(DA);
            DA.Update(DS, "Tab_Robot");
        }
    }
}
