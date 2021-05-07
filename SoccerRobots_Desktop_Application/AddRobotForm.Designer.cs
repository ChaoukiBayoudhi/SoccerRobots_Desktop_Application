
namespace SoccerRobots_Desktop_Application
{
    partial class AddRobotForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Code = new System.Windows.Forms.TextBox();
            this.txt_XPosition = new System.Windows.Forms.TextBox();
            this.txt_YPosition = new System.Windows.Forms.TextBox();
            this.chk_HaveBall = new System.Windows.Forms.CheckBox();
            this.cmb_State = new System.Windows.Forms.ComboBox();
            this.bt_AddRobot = new System.Windows.Forms.Button();
            this.bt_Cancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Tomato;
            this.label2.Location = new System.Drawing.Point(40, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Code";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Tomato;
            this.label3.Location = new System.Drawing.Point(40, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "X Position";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Tomato;
            this.label4.Location = new System.Drawing.Point(40, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Y Position";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Tomato;
            this.label5.Location = new System.Drawing.Point(40, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "State";
            // 
            // txt_Code
            // 
            this.txt_Code.Location = new System.Drawing.Point(222, 33);
            this.txt_Code.Name = "txt_Code";
            this.txt_Code.Size = new System.Drawing.Size(200, 24);
            this.txt_Code.TabIndex = 5;
            // 
            // txt_XPosition
            // 
            this.txt_XPosition.Location = new System.Drawing.Point(222, 73);
            this.txt_XPosition.Name = "txt_XPosition";
            this.txt_XPosition.Size = new System.Drawing.Size(200, 24);
            this.txt_XPosition.TabIndex = 6;
            // 
            // txt_YPosition
            // 
            this.txt_YPosition.Location = new System.Drawing.Point(222, 117);
            this.txt_YPosition.Name = "txt_YPosition";
            this.txt_YPosition.Size = new System.Drawing.Size(200, 24);
            this.txt_YPosition.TabIndex = 7;
            // 
            // chk_HaveBall
            // 
            this.chk_HaveBall.AutoSize = true;
            this.chk_HaveBall.Checked = true;
            this.chk_HaveBall.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_HaveBall.ForeColor = System.Drawing.Color.Tomato;
            this.chk_HaveBall.Location = new System.Drawing.Point(43, 214);
            this.chk_HaveBall.Name = "chk_HaveBall";
            this.chk_HaveBall.Size = new System.Drawing.Size(98, 22);
            this.chk_HaveBall.TabIndex = 8;
            this.chk_HaveBall.Text = "Have Ball";
            this.chk_HaveBall.UseVisualStyleBackColor = true;
            // 
            // cmb_State
            // 
            this.cmb_State.FormattingEnabled = true;
            this.cmb_State.Location = new System.Drawing.Point(222, 166);
            this.cmb_State.Name = "cmb_State";
            this.cmb_State.Size = new System.Drawing.Size(200, 26);
            this.cmb_State.TabIndex = 9;
            // 
            // bt_AddRobot
            // 
            this.bt_AddRobot.BackColor = System.Drawing.SystemColors.HotTrack;
            this.bt_AddRobot.Location = new System.Drawing.Point(32, 27);
            this.bt_AddRobot.Name = "bt_AddRobot";
            this.bt_AddRobot.Size = new System.Drawing.Size(121, 45);
            this.bt_AddRobot.TabIndex = 10;
            this.bt_AddRobot.Text = "Add Robot";
            this.bt_AddRobot.UseVisualStyleBackColor = false;
            this.bt_AddRobot.Click += new System.EventHandler(this.bt_AddRobot_Click);
            // 
            // bt_Cancel
            // 
            this.bt_Cancel.BackColor = System.Drawing.SystemColors.HotTrack;
            this.bt_Cancel.Location = new System.Drawing.Point(431, 27);
            this.bt_Cancel.Name = "bt_Cancel";
            this.bt_Cancel.Size = new System.Drawing.Size(121, 45);
            this.bt_Cancel.TabIndex = 11;
            this.bt_Cancel.Text = "Cancel";
            this.bt_Cancel.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmb_State);
            this.groupBox1.Controls.Add(this.chk_HaveBall);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_Code);
            this.groupBox1.Controls.Add(this.txt_XPosition);
            this.groupBox1.Controls.Add(this.txt_YPosition);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(71, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(576, 266);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Robot Informations";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bt_AddRobot);
            this.groupBox2.Controls.Add(this.bt_Cancel);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(54, 356);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(608, 82);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Action";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkRed;
            this.label6.Location = new System.Drawing.Point(288, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 29);
            this.label6.TabIndex = 10;
            this.label6.Text = "Add Robot";
            // 
            // AddRobotForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddRobotForm";
            this.Text = "AddRobotForm";
            this.Load += new System.EventHandler(this.AddRobotForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Code;
        private System.Windows.Forms.TextBox txt_XPosition;
        private System.Windows.Forms.TextBox txt_YPosition;
        private System.Windows.Forms.CheckBox chk_HaveBall;
        private System.Windows.Forms.ComboBox cmb_State;
        private System.Windows.Forms.Button bt_AddRobot;
        private System.Windows.Forms.Button bt_Cancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
    }
}