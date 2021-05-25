
namespace SoccerRobots_Desktop_Application
{
    partial class AddModifyMatch
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_IdTeamA = new System.Windows.Forms.ComboBox();
            this.cmb_IdTeamB = new System.Windows.Forms.ComboBox();
            this.cmb_IdPitch = new System.Windows.Forms.ComboBox();
            this.dtp_StartTime = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_AddModify = new System.Windows.Forms.Button();
            this.bt_cancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id Team A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Add Team B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Id Pitch";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Start Time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(256, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Add Match";
            // 
            // cmb_IdTeamA
            // 
            this.cmb_IdTeamA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_IdTeamA.FormattingEnabled = true;
            this.cmb_IdTeamA.Location = new System.Drawing.Point(240, 26);
            this.cmb_IdTeamA.Name = "cmb_IdTeamA";
            this.cmb_IdTeamA.Size = new System.Drawing.Size(200, 26);
            this.cmb_IdTeamA.TabIndex = 5;
            // 
            // cmb_IdTeamB
            // 
            this.cmb_IdTeamB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_IdTeamB.FormattingEnabled = true;
            this.cmb_IdTeamB.Location = new System.Drawing.Point(240, 83);
            this.cmb_IdTeamB.Name = "cmb_IdTeamB";
            this.cmb_IdTeamB.Size = new System.Drawing.Size(200, 26);
            this.cmb_IdTeamB.TabIndex = 6;
            // 
            // cmb_IdPitch
            // 
            this.cmb_IdPitch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_IdPitch.FormattingEnabled = true;
            this.cmb_IdPitch.Location = new System.Drawing.Point(240, 129);
            this.cmb_IdPitch.Name = "cmb_IdPitch";
            this.cmb_IdPitch.Size = new System.Drawing.Size(200, 26);
            this.cmb_IdPitch.TabIndex = 7;
            // 
            // dtp_StartTime
            // 
            this.dtp_StartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_StartTime.Location = new System.Drawing.Point(240, 183);
            this.dtp_StartTime.Name = "dtp_StartTime";
            this.dtp_StartTime.Size = new System.Drawing.Size(200, 24);
            this.dtp_StartTime.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtp_StartTime);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmb_IdPitch);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmb_IdTeamB);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmb_IdTeamA);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(33, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(517, 219);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Match Informations";
            // 
            // bt_AddModify
            // 
            this.bt_AddModify.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_AddModify.Location = new System.Drawing.Point(89, 314);
            this.bt_AddModify.Name = "bt_AddModify";
            this.bt_AddModify.Size = new System.Drawing.Size(84, 32);
            this.bt_AddModify.TabIndex = 9;
            this.bt_AddModify.Text = "Add";
            this.bt_AddModify.UseVisualStyleBackColor = true;
            this.bt_AddModify.Click += new System.EventHandler(this.bt_AddModify_Click);
            // 
            // bt_cancel
            // 
            this.bt_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cancel.Location = new System.Drawing.Point(497, 314);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(84, 32);
            this.bt_cancel.TabIndex = 10;
            this.bt_cancel.Text = "Cancel";
            this.bt_cancel.UseVisualStyleBackColor = true;
            // 
            // AddModifyMatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 358);
            this.Controls.Add(this.bt_AddModify);
            this.Controls.Add(this.bt_cancel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Name = "AddModifyMatch";
            this.Text = "AddModifyMatch";
            this.Load += new System.EventHandler(this.AddModifyMatch_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_IdTeamA;
        private System.Windows.Forms.ComboBox cmb_IdTeamB;
        private System.Windows.Forms.ComboBox cmb_IdPitch;
        private System.Windows.Forms.DateTimePicker dtp_StartTime;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bt_AddModify;
        private System.Windows.Forms.Button bt_cancel;
    }
}