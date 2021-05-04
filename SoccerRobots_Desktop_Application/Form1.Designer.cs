
namespace SoccerRobots_Desktop_Application
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.robotsManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addRobotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matchsManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teamManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addTeamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showTeamsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.robotsManagementToolStripMenuItem,
            this.matchsManagementToolStripMenuItem,
            this.teamManagementToolStripMenuItem,
            this.exitApplicationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // robotsManagementToolStripMenuItem
            // 
            this.robotsManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addRobotToolStripMenuItem});
            this.robotsManagementToolStripMenuItem.Name = "robotsManagementToolStripMenuItem";
            this.robotsManagementToolStripMenuItem.Size = new System.Drawing.Size(130, 20);
            this.robotsManagementToolStripMenuItem.Text = "Robots Management";
            // 
            // addRobotToolStripMenuItem
            // 
            this.addRobotToolStripMenuItem.Name = "addRobotToolStripMenuItem";
            this.addRobotToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addRobotToolStripMenuItem.Text = "Robot Dashbord";
            // 
            // matchsManagementToolStripMenuItem
            // 
            this.matchsManagementToolStripMenuItem.Name = "matchsManagementToolStripMenuItem";
            this.matchsManagementToolStripMenuItem.Size = new System.Drawing.Size(132, 20);
            this.matchsManagementToolStripMenuItem.Text = "Matchs Management";
            // 
            // teamManagementToolStripMenuItem
            // 
            this.teamManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addTeamToolStripMenuItem,
            this.showTeamsToolStripMenuItem});
            this.teamManagementToolStripMenuItem.Name = "teamManagementToolStripMenuItem";
            this.teamManagementToolStripMenuItem.Size = new System.Drawing.Size(126, 20);
            this.teamManagementToolStripMenuItem.Text = "Teams Management";
            // 
            // addTeamToolStripMenuItem
            // 
            this.addTeamToolStripMenuItem.Name = "addTeamToolStripMenuItem";
            this.addTeamToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addTeamToolStripMenuItem.Text = "Add Team";
            this.addTeamToolStripMenuItem.Click += new System.EventHandler(this.addTeamToolStripMenuItem_Click);
            // 
            // showTeamsToolStripMenuItem
            // 
            this.showTeamsToolStripMenuItem.Name = "showTeamsToolStripMenuItem";
            this.showTeamsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.showTeamsToolStripMenuItem.Text = "Team Dashbord";
            this.showTeamsToolStripMenuItem.Click += new System.EventHandler(this.showTeamsToolStripMenuItem_Click);
            // 
            // exitApplicationToolStripMenuItem
            // 
            this.exitApplicationToolStripMenuItem.Name = "exitApplicationToolStripMenuItem";
            this.exitApplicationToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.exitApplicationToolStripMenuItem.Text = "Exit Application";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem robotsManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addRobotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matchsManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teamManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addTeamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showTeamsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitApplicationToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

