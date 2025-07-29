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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlUCholder = new System.Windows.Forms.Panel();
            this.lblwelcome = new System.Windows.Forms.Label();
            this.btnDashboard = new System.Windows.Forms.PictureBox();
            this.btnLogout = new System.Windows.Forms.PictureBox();
            this.btnReports = new System.Windows.Forms.PictureBox();
            this.btnStudent = new System.Windows.Forms.PictureBox();
            this.btnLogs = new System.Windows.Forms.PictureBox();
            this.btnLogin = new System.Windows.Forms.PictureBox();
            this.btnSubject = new System.Windows.Forms.PictureBox();
            this.btnTeacher = new System.Windows.Forms.PictureBox();
            this.dashboard1 = new StudentInfoSystem.Dashboard();
            this.admin1 = new StudentInfoSystem.Admin();
            this.admin_Teacher1 = new StudentInfoSystem.Admin_Teacher();
            this.pnlUCholder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDashboard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReports)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSubject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTeacher)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlUCholder
            // 
            this.pnlUCholder.Controls.Add(this.dashboard1);
            this.pnlUCholder.Controls.Add(this.admin1);
            this.pnlUCholder.Controls.Add(this.admin_Teacher1);
            this.pnlUCholder.Location = new System.Drawing.Point(260, 12);
            this.pnlUCholder.Name = "pnlUCholder";
            this.pnlUCholder.Size = new System.Drawing.Size(724, 514);
            this.pnlUCholder.TabIndex = 15;
            // 
            // lblwelcome
            // 
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
            this.btnDashboard.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnDashboard.Image = global::StudentInfoSystem.Properties.Resources.btndashboard;
            this.btnDashboard.Location = new System.Drawing.Point(9, 141);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(245, 45);
            this.btnDashboard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnDashboard.TabIndex = 14;
            this.btnDashboard.TabStop = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            this.btnDashboard.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            this.btnDashboard.MouseHover += new System.EventHandler(this.Button_MouseHover);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnLogout.Image = global::StudentInfoSystem.Properties.Resources.btnlogout;
            this.btnLogout.Location = new System.Drawing.Point(9, 478);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(245, 46);
            this.btnLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnLogout.TabIndex = 9;
            this.btnLogout.TabStop = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            this.btnLogout.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            this.btnLogout.MouseHover += new System.EventHandler(this.Button_MouseHover);
            // 
            // btnReports
            // 
            this.btnReports.BackColor = System.Drawing.Color.Transparent;
            this.btnReports.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnReports.Image = global::StudentInfoSystem.Properties.Resources.btnreports;
            this.btnReports.Location = new System.Drawing.Point(9, 421);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(245, 46);
            this.btnReports.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnReports.TabIndex = 13;
            this.btnReports.TabStop = false;
            this.btnReports.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            this.btnReports.MouseHover += new System.EventHandler(this.Button_MouseHover);
            // 
            // btnStudent
            // 
            this.btnStudent.BackColor = System.Drawing.Color.Transparent;
            this.btnStudent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnStudent.Image = global::StudentInfoSystem.Properties.Resources.btnstudent;
            this.btnStudent.Location = new System.Drawing.Point(9, 197);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Size = new System.Drawing.Size(244, 45);
            this.btnStudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnStudent.TabIndex = 12;
            this.btnStudent.TabStop = false;
            this.btnStudent.Click += new System.EventHandler(this.btnStudent_Click);
            this.btnStudent.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            this.btnStudent.MouseHover += new System.EventHandler(this.Button_MouseHover);
            // 
            // btnLogs
            // 
            this.btnLogs.BackColor = System.Drawing.Color.Transparent;
            this.btnLogs.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnLogs.Image = global::StudentInfoSystem.Properties.Resources.btnlogs;
            this.btnLogs.Location = new System.Drawing.Point(9, 365);
            this.btnLogs.Name = "btnLogs";
            this.btnLogs.Size = new System.Drawing.Size(244, 45);
            this.btnLogs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnLogs.TabIndex = 8;
            this.btnLogs.TabStop = false;
            this.btnLogs.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            this.btnLogs.MouseHover += new System.EventHandler(this.Button_MouseHover);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.Image = global::StudentInfoSystem.Properties.Resources.LOGOSIS;
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
            this.btnSubject.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnSubject.Image = global::StudentInfoSystem.Properties.Resources.btnsubject;
            this.btnSubject.Location = new System.Drawing.Point(9, 309);
            this.btnSubject.Name = "btnSubject";
            this.btnSubject.Size = new System.Drawing.Size(244, 45);
            this.btnSubject.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnSubject.TabIndex = 10;
            this.btnSubject.TabStop = false;
            this.btnSubject.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            this.btnSubject.MouseHover += new System.EventHandler(this.Button_MouseHover);
            // 
            // btnTeacher
            // 
            this.btnTeacher.BackColor = System.Drawing.Color.Transparent;
            this.btnTeacher.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnTeacher.Image = global::StudentInfoSystem.Properties.Resources.btnteacher;
            this.btnTeacher.Location = new System.Drawing.Point(9, 253);
            this.btnTeacher.Name = "btnTeacher";
            this.btnTeacher.Size = new System.Drawing.Size(244, 45);
            this.btnTeacher.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnTeacher.TabIndex = 11;
            this.btnTeacher.TabStop = false;
            this.btnTeacher.Click += new System.EventHandler(this.btnTeacher_Click);
            this.btnTeacher.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            this.btnTeacher.MouseHover += new System.EventHandler(this.Button_MouseHover);
            // 
            // dashboard1
            // 
            this.dashboard1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.dashboard1.Location = new System.Drawing.Point(0, 0);
            this.dashboard1.Name = "dashboard1";
            this.dashboard1.Size = new System.Drawing.Size(724, 514);
            this.dashboard1.TabIndex = 1;
            // 
            // admin1
            // 
            this.admin1.BackColor = System.Drawing.Color.Transparent;
            this.admin1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.admin1.Location = new System.Drawing.Point(0, 0);
            this.admin1.Name = "admin1";
            this.admin1.Size = new System.Drawing.Size(724, 514);
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
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(34)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(1009, 541);
            this.Controls.Add(this.lblwelcome);
            this.Controls.Add(this.pnlUCholder);
            this.Controls.Add(this.btnDashboard);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnReports);
            this.Controls.Add(this.btnStudent);
            this.Controls.Add(this.btnLogs);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnSubject);
            this.Controls.Add(this.btnTeacher);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminForm";
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
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}