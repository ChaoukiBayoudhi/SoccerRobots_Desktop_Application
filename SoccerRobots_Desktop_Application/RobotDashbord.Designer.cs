
namespace SoccerRobots_Desktop_Application
{
    partial class RobotDashbord
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_Find = new System.Windows.Forms.Button();
            this.cmb_creteria = new System.Windows.Forms.ComboBox();
            this.txt_value = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bt_Cancel = new System.Windows.Forms.Button();
            this.bt_ModifyRobot = new System.Windows.Forms.Button();
            this.bt_DeleteRobot = new System.Windows.Forms.Button();
            this.bt_AddRobot = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_Find);
            this.groupBox1.Controls.Add(this.cmb_creteria);
            this.groupBox1.Controls.Add(this.txt_value);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(86, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(641, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Find Robot";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // bt_Find
            // 
            this.bt_Find.BackColor = System.Drawing.SystemColors.HotTrack;
            this.bt_Find.ForeColor = System.Drawing.Color.Tomato;
            this.bt_Find.Location = new System.Drawing.Point(508, 38);
            this.bt_Find.Name = "bt_Find";
            this.bt_Find.Size = new System.Drawing.Size(107, 36);
            this.bt_Find.TabIndex = 4;
            this.bt_Find.Text = "Find";
            this.bt_Find.UseVisualStyleBackColor = false;
            // 
            // cmb_creteria
            // 
            this.cmb_creteria.FormattingEnabled = true;
            this.cmb_creteria.Items.AddRange(new object[] {
            "Code",
            "Have Ball",
            "State"});
            this.cmb_creteria.Location = new System.Drawing.Point(103, 44);
            this.cmb_creteria.Name = "cmb_creteria";
            this.cmb_creteria.Size = new System.Drawing.Size(121, 26);
            this.cmb_creteria.TabIndex = 3;
            // 
            // txt_value
            // 
            this.txt_value.Location = new System.Drawing.Point(347, 44);
            this.txt_value.Name = "txt_value";
            this.txt_value.Size = new System.Drawing.Size(100, 24);
            this.txt_value.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Creteria";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(271, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Value";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bt_Cancel);
            this.groupBox2.Controls.Add(this.bt_ModifyRobot);
            this.groupBox2.Controls.Add(this.bt_DeleteRobot);
            this.groupBox2.Controls.Add(this.bt_AddRobot);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(587, 144);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(184, 263);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Action";
            // 
            // bt_Cancel
            // 
            this.bt_Cancel.BackColor = System.Drawing.SystemColors.HotTrack;
            this.bt_Cancel.ForeColor = System.Drawing.Color.Tomato;
            this.bt_Cancel.Location = new System.Drawing.Point(29, 203);
            this.bt_Cancel.Name = "bt_Cancel";
            this.bt_Cancel.Size = new System.Drawing.Size(128, 35);
            this.bt_Cancel.TabIndex = 3;
            this.bt_Cancel.Text = "Cancel";
            this.bt_Cancel.UseVisualStyleBackColor = false;
            // 
            // bt_ModifyRobot
            // 
            this.bt_ModifyRobot.BackColor = System.Drawing.SystemColors.HotTrack;
            this.bt_ModifyRobot.ForeColor = System.Drawing.Color.Tomato;
            this.bt_ModifyRobot.Location = new System.Drawing.Point(29, 148);
            this.bt_ModifyRobot.Name = "bt_ModifyRobot";
            this.bt_ModifyRobot.Size = new System.Drawing.Size(128, 35);
            this.bt_ModifyRobot.TabIndex = 2;
            this.bt_ModifyRobot.Text = "Modify Robot";
            this.bt_ModifyRobot.UseVisualStyleBackColor = false;
            this.bt_ModifyRobot.Click += new System.EventHandler(this.bt_ModifyRobot_Click);
            // 
            // bt_DeleteRobot
            // 
            this.bt_DeleteRobot.BackColor = System.Drawing.SystemColors.HotTrack;
            this.bt_DeleteRobot.ForeColor = System.Drawing.Color.Tomato;
            this.bt_DeleteRobot.Location = new System.Drawing.Point(29, 88);
            this.bt_DeleteRobot.Name = "bt_DeleteRobot";
            this.bt_DeleteRobot.Size = new System.Drawing.Size(128, 35);
            this.bt_DeleteRobot.TabIndex = 1;
            this.bt_DeleteRobot.Text = "Delete Robot";
            this.bt_DeleteRobot.UseVisualStyleBackColor = false;
            this.bt_DeleteRobot.Click += new System.EventHandler(this.bt_DeleteRobot_Click);
            // 
            // bt_AddRobot
            // 
            this.bt_AddRobot.BackColor = System.Drawing.SystemColors.HotTrack;
            this.bt_AddRobot.ForeColor = System.Drawing.Color.Tomato;
            this.bt_AddRobot.Location = new System.Drawing.Point(29, 33);
            this.bt_AddRobot.Name = "bt_AddRobot";
            this.bt_AddRobot.Size = new System.Drawing.Size(128, 35);
            this.bt_AddRobot.TabIndex = 0;
            this.bt_AddRobot.Text = "Add Robot";
            this.bt_AddRobot.UseVisualStyleBackColor = false;
            this.bt_AddRobot.Click += new System.EventHandler(this.bt_AddRobot_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(51, 164);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(511, 271);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "List Of Robots";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(19, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(474, 219);
            this.dataGridView1.TabIndex = 0;
            // 
            // RobotDashbord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "RobotDashbord";
            this.Text = "RobotDashbord";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RobotDashbord_FormClosing);
            this.Load += new System.EventHandler(this.RobotDashbord_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bt_Find;
        private System.Windows.Forms.ComboBox cmb_creteria;
        private System.Windows.Forms.TextBox txt_value;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bt_Cancel;
        private System.Windows.Forms.Button bt_ModifyRobot;
        private System.Windows.Forms.Button bt_DeleteRobot;
        private System.Windows.Forms.Button bt_AddRobot;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}