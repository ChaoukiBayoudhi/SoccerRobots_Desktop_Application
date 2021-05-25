
namespace SoccerRobots_Desktop_Application
{
    partial class MatchDashBord
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
            this.bt_statistics = new System.Windows.Forms.Button();
            this.bt_modifyMatch = new System.Windows.Forms.Button();
            this.bt_deleteMatch = new System.Windows.Forms.Button();
            this.bt_AddMatch = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bt_cancel = new System.Windows.Forms.Button();
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
            this.groupBox1.Location = new System.Drawing.Point(80, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(641, 100);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Find Match";
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
            this.groupBox2.Controls.Add(this.bt_cancel);
            this.groupBox2.Controls.Add(this.bt_statistics);
            this.groupBox2.Controls.Add(this.bt_modifyMatch);
            this.groupBox2.Controls.Add(this.bt_deleteMatch);
            this.groupBox2.Controls.Add(this.bt_AddMatch);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(593, 138);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(184, 310);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Action";
            // 
            // bt_statistics
            // 
            this.bt_statistics.BackColor = System.Drawing.SystemColors.HotTrack;
            this.bt_statistics.ForeColor = System.Drawing.Color.Tomato;
            this.bt_statistics.Location = new System.Drawing.Point(29, 195);
            this.bt_statistics.Name = "bt_statistics";
            this.bt_statistics.Size = new System.Drawing.Size(128, 38);
            this.bt_statistics.TabIndex = 3;
            this.bt_statistics.Text = "Statistics";
            this.bt_statistics.UseVisualStyleBackColor = false;
            this.bt_statistics.Click += new System.EventHandler(this.bt_statistics_Click);
            // 
            // bt_modifyMatch
            // 
            this.bt_modifyMatch.BackColor = System.Drawing.SystemColors.HotTrack;
            this.bt_modifyMatch.ForeColor = System.Drawing.Color.Tomato;
            this.bt_modifyMatch.Location = new System.Drawing.Point(29, 140);
            this.bt_modifyMatch.Name = "bt_modifyMatch";
            this.bt_modifyMatch.Size = new System.Drawing.Size(128, 39);
            this.bt_modifyMatch.TabIndex = 2;
            this.bt_modifyMatch.Text = "Modify Match";
            this.bt_modifyMatch.UseVisualStyleBackColor = false;
            this.bt_modifyMatch.Click += new System.EventHandler(this.bt_modifyMatch_Click);
            // 
            // bt_deleteMatch
            // 
            this.bt_deleteMatch.BackColor = System.Drawing.SystemColors.HotTrack;
            this.bt_deleteMatch.ForeColor = System.Drawing.Color.Tomato;
            this.bt_deleteMatch.Location = new System.Drawing.Point(29, 88);
            this.bt_deleteMatch.Name = "bt_deleteMatch";
            this.bt_deleteMatch.Size = new System.Drawing.Size(128, 38);
            this.bt_deleteMatch.TabIndex = 1;
            this.bt_deleteMatch.Text = "Delete Match";
            this.bt_deleteMatch.UseVisualStyleBackColor = false;
            // 
            // bt_AddMatch
            // 
            this.bt_AddMatch.BackColor = System.Drawing.SystemColors.HotTrack;
            this.bt_AddMatch.ForeColor = System.Drawing.Color.Tomato;
            this.bt_AddMatch.Location = new System.Drawing.Point(29, 33);
            this.bt_AddMatch.Name = "bt_AddMatch";
            this.bt_AddMatch.Size = new System.Drawing.Size(128, 38);
            this.bt_AddMatch.TabIndex = 0;
            this.bt_AddMatch.Text = "Add Match";
            this.bt_AddMatch.UseVisualStyleBackColor = false;
            this.bt_AddMatch.Click += new System.EventHandler(this.bt_AddMatch_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(23, 158);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(553, 271);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "List of Matchs";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(525, 219);
            this.dataGridView1.TabIndex = 0;
            // 
            // bt_cancel
            // 
            this.bt_cancel.BackColor = System.Drawing.SystemColors.HotTrack;
            this.bt_cancel.ForeColor = System.Drawing.Color.Tomato;
            this.bt_cancel.Location = new System.Drawing.Point(29, 253);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(128, 38);
            this.bt_cancel.TabIndex = 4;
            this.bt_cancel.Text = "Cancel";
            this.bt_cancel.UseVisualStyleBackColor = false;
            // 
            // MatchDashBord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 476);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Name = "MatchDashBord";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.MatchDashBord_Load);
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
        private System.Windows.Forms.Button bt_statistics;
        private System.Windows.Forms.Button bt_modifyMatch;
        private System.Windows.Forms.Button bt_deleteMatch;
        private System.Windows.Forms.Button bt_AddMatch;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bt_cancel;
    }
}