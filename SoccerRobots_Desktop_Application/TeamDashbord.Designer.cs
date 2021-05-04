
namespace SoccerRobots_Desktop_Application
{
    partial class TeamDashbord
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bt_Cancel = new System.Windows.Forms.Button();
            this.bt_ModifyTeam = new System.Windows.Forms.Button();
            this.bt_DeleteTeam = new System.Windows.Forms.Button();
            this.bt_AddTeam = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(28, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(529, 250);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "List Of Teams";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(40, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(375, 174);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bt_Cancel);
            this.groupBox2.Controls.Add(this.bt_ModifyTeam);
            this.groupBox2.Controls.Add(this.bt_DeleteTeam);
            this.groupBox2.Controls.Add(this.bt_AddTeam);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(590, 89);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(184, 250);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Action";
            // 
            // bt_Cancel
            // 
            this.bt_Cancel.BackColor = System.Drawing.SystemColors.HotTrack;
            this.bt_Cancel.ForeColor = System.Drawing.Color.Tomato;
            this.bt_Cancel.Location = new System.Drawing.Point(29, 193);
            this.bt_Cancel.Name = "bt_Cancel";
            this.bt_Cancel.Size = new System.Drawing.Size(128, 35);
            this.bt_Cancel.TabIndex = 3;
            this.bt_Cancel.Text = "Cancel";
            this.bt_Cancel.UseVisualStyleBackColor = false;
            this.bt_Cancel.Click += new System.EventHandler(this.bt_Cancel_Click);
            // 
            // bt_ModifyTeam
            // 
            this.bt_ModifyTeam.BackColor = System.Drawing.SystemColors.HotTrack;
            this.bt_ModifyTeam.ForeColor = System.Drawing.Color.Tomato;
            this.bt_ModifyTeam.Location = new System.Drawing.Point(29, 138);
            this.bt_ModifyTeam.Name = "bt_ModifyTeam";
            this.bt_ModifyTeam.Size = new System.Drawing.Size(128, 35);
            this.bt_ModifyTeam.TabIndex = 2;
            this.bt_ModifyTeam.Text = "Modify Team";
            this.bt_ModifyTeam.UseVisualStyleBackColor = false;
            this.bt_ModifyTeam.Click += new System.EventHandler(this.bt_ModifyTeam_Click);
            // 
            // bt_DeleteTeam
            // 
            this.bt_DeleteTeam.BackColor = System.Drawing.SystemColors.HotTrack;
            this.bt_DeleteTeam.ForeColor = System.Drawing.Color.Tomato;
            this.bt_DeleteTeam.Location = new System.Drawing.Point(29, 78);
            this.bt_DeleteTeam.Name = "bt_DeleteTeam";
            this.bt_DeleteTeam.Size = new System.Drawing.Size(128, 35);
            this.bt_DeleteTeam.TabIndex = 1;
            this.bt_DeleteTeam.Text = "Delete Team";
            this.bt_DeleteTeam.UseVisualStyleBackColor = false;
            this.bt_DeleteTeam.Click += new System.EventHandler(this.bt_DeleteTeam_Click);
            // 
            // bt_AddTeam
            // 
            this.bt_AddTeam.BackColor = System.Drawing.SystemColors.HotTrack;
            this.bt_AddTeam.ForeColor = System.Drawing.Color.Tomato;
            this.bt_AddTeam.Location = new System.Drawing.Point(29, 23);
            this.bt_AddTeam.Name = "bt_AddTeam";
            this.bt_AddTeam.Size = new System.Drawing.Size(128, 35);
            this.bt_AddTeam.TabIndex = 0;
            this.bt_AddTeam.Text = "Add Team";
            this.bt_AddTeam.UseVisualStyleBackColor = false;
            this.bt_AddTeam.Click += new System.EventHandler(this.bt_AddTeam_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(250, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Teams";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TeamDashbord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "TeamDashbord";
            this.Text = "TeamDashbord";
            this.Load += new System.EventHandler(this.TeamDashbord_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_Cancel;
        private System.Windows.Forms.Button bt_ModifyTeam;
        private System.Windows.Forms.Button bt_DeleteTeam;
        private System.Windows.Forms.Button bt_AddTeam;
    }
}