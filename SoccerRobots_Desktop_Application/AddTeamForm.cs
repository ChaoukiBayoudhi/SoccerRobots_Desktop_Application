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
    public partial class AddTeamForm : Form
    {
        private SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-7J9ODH9;Initial Catalog=SoccerRobotDB;Integrated Security=True;Pooling=False");

        private SqlCommand cmd = new SqlCommand();

        private string Action;
        

        public  Team Team1 { get; set; }
        public DataGridView dataGridView1 { get; set; }

        public AddTeamForm()
        {
            InitializeComponent();
        }

        public AddTeamForm(Team Team1, DataGridView dataGridView1)
        {
            InitializeComponent();
            this.Team1 = Team1;//?? throw new ArgumentNullException(nameof(team));
            this.dataGridView1 = dataGridView1; //?? throw new ArgumentNullException(nameof(dataGridView1));
            this.Action = "Modify";
        }

        public AddTeamForm(DataGridView dataGridView1)
        {
            InitializeComponent();
            this.Action = "Add";
            this.dataGridView1 = dataGridView1;
        }

        private void bt_AddTeam_Click(object sender, EventArgs e)
        {
            //Connected Mode
            //use of classes : xyzConnction, xyzCommand, xyzDataReader
            //xyz may be sql -->sql server
            //xyz may be oracle -->Oracle
            //xyz may be Mysql -->Mysql
            //xyz may be oledb or odbc : generic driver
            if (Action == "Add")
            {
                Boolean added = false;
               
                //step 1 : create connection

                try
                {
                    //con = new SqlConnection(@"Data Source=DESKTOP-7J9ODH9;Initial Catalog=SoccerRobotDB;Integrated Security=True;Pooling=False");
                    //xyz may be sql -->sql server
                    //we could use the property ConnectionString to set the connection string
                    // con.ConnectionString = @"Data Source=DESKTOP-7J9ODH9;Initial Catalog=SoccerRobotDB;Integrated Security=True;Pooling=False";

                    //step 2 : open the connection
                    con.Open();
                    //step 3 : Create command
                    //SqlCommand cmd = new SqlCommand("insert into values....",con);
                    //or

                    cmd.CommandText = "insert into Team(Name,Color) values(@Name,@Color)";
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.Text;//optional
                   //cmd.Parameters.AddWithValue("@Id", int.Parse(txt_Id.Text)); //Id is identity
                    cmd.Parameters.AddWithValue("@Name", txt_Name.Text);
                    cmd.Parameters.AddWithValue("@Color", txt_Color.Text);
                    //cmd.Parameters.Add("@Id", SqlDbType.Int).Direction = ParameterDirection.Output; //the @id will be an output


                    //step 4 : Execute command
                    cmd.ExecuteNonQuery();//is used for insert, update and delete
                                          //cmd.ExecuteReader(); //used in select case

                    MessageBox.Show("The Team has been successufly added");
                    added = true;
                    

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    //last step close the connection
                    if (con != null && con.State == ConnectionState.Open)
                        con.Close();
                    if (added)
                    {
                        this.dataGridView1.DataSource = null;
                        this.dataGridView1.DataSource = TeamDashbord.getAllTeams();
                        Reset();
                        txt_Id.Text = (getLastId()+10).ToString();
                    }
                    
                }



                //or we could use "using", so we don't have to call open nother close
                //step 1 : create connection
                /* using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-7J9ODH9;Initial Catalog=SoccerRobotDB;Integrated Security=True;Pooling=False"))
                 { 
                    //step 1
                     con.Open()

                     //step 2
                     //.....

                 }//end use==>con.Close()
                */

            }
            else
            {
                Boolean updated = false;
                try
                {
                   
                    //step 2 : open the connection
                    con.Open();
                    //step 3 : Create command
                    //SqlCommand cmd = new SqlCommand("insert into values....",con);
                    //or

                    cmd.CommandText = "update Team set Name = @Name, Color = @Color where id=@Id;";
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.Text;//optional
                    cmd.Parameters.AddWithValue("@Id", int.Parse(txt_Id.Text)); 
                    cmd.Parameters.AddWithValue("@Name", txt_Name.Text);
                    cmd.Parameters.AddWithValue("@Color", txt_Color.Text);

                    //step 4 : Execute command
                    cmd.ExecuteNonQuery();//is used for insert, update and delete
                                          //cmd.ExecuteReader(); //used in select case

                    MessageBox.Show("The Team has been successufly updated");
                    updated = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    //last step close the connection
                    if (con != null && con.State == ConnectionState.Open)
                        con.Close();
                    if (updated)
                    {
                        this.dataGridView1.DataSource = null;
                        this.dataGridView1.DataSource = TeamDashbord.getAllTeams();
                    }
                }

            }

        }
        private void Reset()
        {
            foreach (var x in groupBox1.Controls)
            {
                if (x is TextBox && x != txt_Id)
                    (x as TextBox).Text = string.Empty;

            }
        }
        private int getLastId()
        {
            int id = 0;
             
            try
            {

                    con.Open();
                    //step 3 : Create command
                    SqlCommand cmd = new SqlCommand("select max(Id) from team",con);
                    
                    //step 4 : Execute command
                    id =(int)cmd.ExecuteScalar();//is used in select aggregation function case
                                          

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);                                
            }
            finally
            {
                //last step close the connection
                if (con != null && con.State == ConnectionState.Open)
                    con.Close();
            }
            return id;
        }

   

    private void AddTeamForm_Load(object sender, EventArgs e)
        {
            txt_Id.Enabled = false;
            if (Action == "Add")
            {                
                txt_Id.Text = (getLastId() + 10).ToString();
            }
            else
            {
                this.Text = "Modify Team";
                bt_AddTeam.Text = "Modify";
                this.txt_Id.Text = Team1.Id.ToString();
                this.txt_Name.Text = Team1.Name;
                this.txt_Color.Text = Team1.Color;

            }

        }

        private void bt_Reset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
