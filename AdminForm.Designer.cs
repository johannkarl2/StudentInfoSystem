namespace StudentInfoSystem
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlUCholder = new System.Windows.Forms.Panel();
            this.dashboard1 = new StudentInfoSystem.Dashboard();
            this.admin1 = new StudentInfoSystem.Admin();
            this.admin_Teacher1 = new StudentInfoSystem.Admin_Teacher();
            this.lblwelcome = new System.Windows.Forms.Label();
            this.btnDashboard = new System.Windows.Forms.PictureBox();
            this.btnLogout = new System.Windows.Forms.PictureBox();
            this.btnReports = new System.Windows.Forms.PictureBox();
            this.btnStudent = new System.Windows.Forms.PictureBox();
            this.btnLogs = new System.Windows.Forms.PictureBox();
            this.btnLogin = new System.Windows.Forms.PictureBox();
            this.btnSubject = new System.Windows.Forms.PictureBox();
            this.btnTeacher = new System.Windows.Forms.PictureBox();
            this.pnlBTNS = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlUCholder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDashboard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReports)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSubject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTeacher)).BeginInit();
            this.pnlBTNS.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlUCholder
            // 
            this.pnlUCholder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(39)))));
            this.pnlUCholder.Controls.Add(this.dashboard1);
            this.pnlUCholder.Controls.Add(this.admin1);
            this.pnlUCholder.Controls.Add(this.admin_Teacher1);
            this.pnlUCholder.Location = new System.Drawing.Point(259, -2);
            this.pnlUCholder.Name = "pnlUCholder";
            this.pnlUCholder.Size = new System.Drawing.Size(749, 548);
            this.pnlUCholder.TabIndex = 15;
            // 
            // dashboard1
            // 
            this.dashboard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(26)))), ((int)(((byte)(40)))));
            this.dashboard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashboard1.Location = new System.Drawing.Point(0, 0);
            this.dashboard1.Name = "dashboard1";
            this.dashboard1.Size = new System.Drawing.Size(749, 548);
            this.dashboard1.TabIndex = 1;
            // 
            // admin1
            // 
            this.admin1.BackColor = System.Drawing.Color.Transparent;
            this.admin1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.admin1.Location = new System.Drawing.Point(0, 0);
            this.admin1.Name = "admin1";
            this.admin1.Size = new System.Drawing.Size(749, 548);
            this.admin1.TabIndex = 0;
            // 
            // admin_Teacher1
            // 
            this.admin_Teacher1.BackColor = System.Drawing.Color.Transparent;
            this.admin_Teacher1.Location = new System.Drawing.Point(0, 0);
            this.admin_Teacher1.Name = "admin_Teacher1";
            this.admin_Teacher1.Size = new System.Drawing.Size(724, 514);
            this.admin_Teacher1.TabIndex = 2;
            // 
            // lblwelcome
            // 
            this.lblwelcome.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblwelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwelcome.ForeColor = System.Drawing.Color.White;
            this.lblwelcome.Location = new System.Drawing.Point(6, 92);
            this.lblwelcome.Name = "lblwelcome";
            this.lblwelcome.Size = new System.Drawing.Size(247, 46);
            this.lblwelcome.TabIndex = 16;
            this.lblwelcome.Text = "label1";
            this.lblwelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.Transparent;
            this.btnDashboard.Image = global::StudentInfoSystem.Properties.Resources._0dashboard;
            this.btnDashboard.Location = new System.Drawing.Point(3, 19);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(241, 41);
            this.btnDashboard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnDashboard.TabIndex = 14;
            this.btnDashboard.TabStop = false;
            this.btnDashboard.Tag = "I";
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.Image = global::StudentInfoSystem.Properties.Resources._0logout;
            this.btnLogout.Location = new System.Drawing.Point(3, 343);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(241, 41);
            this.btnLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnLogout.TabIndex = 9;
            this.btnLogout.TabStop = false;
            this.btnLogout.Tag = "logout";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnReports
            // 
            this.btnReports.BackColor = System.Drawing.Color.Transparent;
            this.btnReports.Image = global::StudentInfoSystem.Properties.Resources._0reports;
            this.btnReports.Location = new System.Drawing.Point(3, 289);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(241, 41);
            this.btnReports.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnReports.TabIndex = 13;
            this.btnReports.TabStop = false;
            this.btnReports.Tag = "I";
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnStudent
            // 
            this.btnStudent.BackColor = System.Drawing.Color.Transparent;
            this.btnStudent.Image = global::StudentInfoSystem.Properties.Resources._00students;
            this.btnStudent.Location = new System.Drawing.Point(3, 73);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Size = new System.Drawing.Size(241, 41);
            this.btnStudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnStudent.TabIndex = 12;
            this.btnStudent.TabStop = false;
            this.btnStudent.Tag = "I";
            this.btnStudent.Click += new System.EventHandler(this.btnStudent_Click);
            // 
            // btnLogs
            // 
            this.btnLogs.BackColor = System.Drawing.Color.Transparent;
            this.btnLogs.Image = global::StudentInfoSystem.Properties.Resources._0logs;
            this.btnLogs.Location = new System.Drawing.Point(3, 235);
            this.btnLogs.Name = "btnLogs";
            this.btnLogs.Size = new System.Drawing.Size(241, 41);
            this.btnLogs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnLogs.TabIndex = 8;
            this.btnLogs.TabStop = false;
            this.btnLogs.Tag = "I";
            this.btnLogs.Click += new System.EventHandler(this.btnLogs_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.Image = ((System.Drawing.Image)(resources.GetObject("btnLogin.Image")));
            this.btnLogin.Location = new System.Drawing.Point(-8, 5);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(262, 84);
            this.btnLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnLogin.TabIndex = 4;
            this.btnLogin.TabStop = false;
            // 
            // btnSubject
            // 
            this.btnSubject.BackColor = System.Drawing.Color.Transparent;
            this.btnSubject.Image = global::StudentInfoSystem.Properties.Resources._0subjects;
            this.btnSubject.Location = new System.Drawing.Point(3, 181);
            this.btnSubject.Name = "btnSubject";
            this.btnSubject.Size = new System.Drawing.Size(241, 41);
            this.btnSubject.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnSubject.TabIndex = 10;
            this.btnSubject.TabStop = false;
            this.btnSubject.Tag = "I";
            this.btnSubject.Click += new System.EventHandler(this.btnSubject_Click);
            // 
            // btnTeacher
            // 
            this.btnTeacher.BackColor = System.Drawing.Color.Transparent;
            this.btnTeacher.Image = global::StudentInfoSystem.Properties.Resources._0teachers;
            this.btnTeacher.Location = new System.Drawing.Point(3, 127);
            this.btnTeacher.Name = "btnTeacher";
            this.btnTeacher.Size = new System.Drawing.Size(241, 41);
            this.btnTeacher.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnTeacher.TabIndex = 11;
            this.btnTeacher.TabStop = false;
            this.btnTeacher.Tag = "I";
            this.btnTeacher.Click += new System.EventHandler(this.btnTeacher_Click);
            // 
            // pnlBTNS
            // 
            this.pnlBTNS.Controls.Add(this.btnDashboard);
            this.pnlBTNS.Controls.Add(this.btnSubject);
            this.pnlBTNS.Controls.Add(this.btnLogs);
            this.pnlBTNS.Controls.Add(this.btnReports);
            this.pnlBTNS.Controls.Add(this.btnStudent);
            this.pnlBTNS.Controls.Add(this.btnTeacher);
            this.pnlBTNS.Controls.Add(this.btnLogout);
            this.pnlBTNS.Location = new System.Drawing.Point(6, 142);
            this.pnlBTNS.Name = "pnlBTNS";
            this.pnlBTNS.Size = new System.Drawing.Size(247, 404);
            this.pnlBTNS.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(237, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(38, 100);
            this.panel1.TabIndex = 18;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(39)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(1009, 541);
            this.Controls.Add(this.lblwelcome);
            this.Controls.Add(this.pnlUCholder);
            this.Controls.Add(this.pnlBTNS);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.pnlUCholder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnDashboard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReports)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSubject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTeacher)).EndInit();
            this.pnlBTNS.ResumeLayout(false);
            this.pnlBTNS.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox btnLogin;
        private System.Windows.Forms.PictureBox btnLogs;
        private System.Windows.Forms.PictureBox btnLogout;
        private System.Windows.Forms.PictureBox btnSubject;
        private System.Windows.Forms.PictureBox btnTeacher;
        private System.Windows.Forms.PictureBox btnStudent;
        private System.Windows.Forms.PictureBox btnReports;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox btnDashboard;
        private System.Windows.Forms.Panel pnlUCholder;
        private System.Windows.Forms.Label lblwelcome;
        private Admin admin1;
        private Dashboard dashboard1;
        private Admin_Teacher admin_Teacher1;
        private System.Windows.Forms.Panel pnlBTNS;
        private System.Windows.Forms.Panel panel1;
    }
}