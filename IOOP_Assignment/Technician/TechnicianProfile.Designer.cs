namespace IOOP_Assignment
{
    partial class TechnicianProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TechnicianProfile));
            this.btnAccess_Profile = new System.Windows.Forms.Button();
            this.btnAccess_Dashboard = new System.Windows.Forms.Button();
            this.picMenuProfile = new System.Windows.Forms.PictureBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.picProfile = new System.Windows.Forms.PictureBox();
            this.lblText_Technician = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.lblDOB = new System.Windows.Forms.Label();
            this.txtDOB = new System.Windows.Forms.TextBox();
            this.lblEthnicity = new System.Windows.Forms.Label();
            this.txtEthnicity = new System.Windows.Forms.TextBox();
            this.lblIC = new System.Windows.Forms.Label();
            this.txtIC = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.lblContact = new System.Windows.Forms.Label();
            this.btnAccess_EditProfile = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picMenuProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAccess_Profile
            // 
            this.btnAccess_Profile.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAccess_Profile.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAccess_Profile.Location = new System.Drawing.Point(36, 256);
            this.btnAccess_Profile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAccess_Profile.Name = "btnAccess_Profile";
            this.btnAccess_Profile.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAccess_Profile.Size = new System.Drawing.Size(151, 30);
            this.btnAccess_Profile.TabIndex = 4;
            this.btnAccess_Profile.Text = "Profile";
            this.btnAccess_Profile.UseVisualStyleBackColor = false;
            this.btnAccess_Profile.MouseEnter += new System.EventHandler(this.btnAccess_Profile_MouseEnter);
            this.btnAccess_Profile.MouseLeave += new System.EventHandler(this.btnAccess_Profile_MouseLeave);
            // 
            // btnAccess_Dashboard
            // 
            this.btnAccess_Dashboard.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAccess_Dashboard.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAccess_Dashboard.Location = new System.Drawing.Point(36, 204);
            this.btnAccess_Dashboard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAccess_Dashboard.Name = "btnAccess_Dashboard";
            this.btnAccess_Dashboard.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAccess_Dashboard.Size = new System.Drawing.Size(151, 30);
            this.btnAccess_Dashboard.TabIndex = 2;
            this.btnAccess_Dashboard.Text = "Dashboard";
            this.btnAccess_Dashboard.UseVisualStyleBackColor = false;
            this.btnAccess_Dashboard.Click += new System.EventHandler(this.btnAccess_Dashboard_Click);
            this.btnAccess_Dashboard.MouseEnter += new System.EventHandler(this.btnAccess_Dashboard_MouseEnter);
            this.btnAccess_Dashboard.MouseLeave += new System.EventHandler(this.btnAccess_Dashboard_MouseLeave);
            // 
            // picMenuProfile
            // 
            this.picMenuProfile.Image = ((System.Drawing.Image)(resources.GetObject("picMenuProfile.Image")));
            this.picMenuProfile.Location = new System.Drawing.Point(81, 327);
            this.picMenuProfile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picMenuProfile.Name = "picMenuProfile";
            this.picMenuProfile.Size = new System.Drawing.Size(55, 62);
            this.picMenuProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMenuProfile.TabIndex = 1;
            this.picMenuProfile.TabStop = false;
            // 
            // picLogo
            // 
            this.picLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(46, 22);
            this.picLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(125, 98);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.PeachPuff;
            this.panelMenu.Controls.Add(this.btnLogOut);
            this.panelMenu.Controls.Add(this.btnAccess_Profile);
            this.panelMenu.Controls.Add(this.btnAccess_Dashboard);
            this.panelMenu.Controls.Add(this.picMenuProfile);
            this.panelMenu.Controls.Add(this.lblName);
            this.panelMenu.Controls.Add(this.picLogo);
            this.panelMenu.Location = new System.Drawing.Point(3, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(217, 537);
            this.panelMenu.TabIndex = 7;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogOut.Location = new System.Drawing.Point(36, 440);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(151, 30);
            this.btnLogOut.TabIndex = 5;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            this.btnLogOut.MouseEnter += new System.EventHandler(this.btnLogOut_MouseEnter);
            this.btnLogOut.MouseLeave += new System.EventHandler(this.btnLogOut_MouseLeave);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(46, 397);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 20);
            this.lblName.TabIndex = 0;
            // 
            // picProfile
            // 
            this.picProfile.Image = ((System.Drawing.Image)(resources.GetObject("picProfile.Image")));
            this.picProfile.Location = new System.Drawing.Point(493, 47);
            this.picProfile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picProfile.Name = "picProfile";
            this.picProfile.Size = new System.Drawing.Size(200, 152);
            this.picProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picProfile.TabIndex = 6;
            this.picProfile.TabStop = false;
            // 
            // lblText_Technician
            // 
            this.lblText_Technician.AutoSize = true;
            this.lblText_Technician.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblText_Technician.Location = new System.Drawing.Point(540, 247);
            this.lblText_Technician.Name = "lblText_Technician";
            this.lblText_Technician.Size = new System.Drawing.Size(98, 24);
            this.lblText_Technician.TabIndex = 9;
            this.lblText_Technician.Text = "Technician";
            this.lblText_Technician.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(251, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 28);
            this.label2.TabIndex = 10;
            this.label2.Text = "Profile";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Microsoft JhengHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGender.Location = new System.Drawing.Point(248, 284);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(77, 24);
            this.lblGender.TabIndex = 11;
            this.lblGender.Text = "Gender";
            this.lblGender.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtGender
            // 
            this.txtGender.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtGender.Location = new System.Drawing.Point(388, 280);
            this.txtGender.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGender.Name = "txtGender";
            this.txtGender.ReadOnly = true;
            this.txtGender.Size = new System.Drawing.Size(174, 32);
            this.txtGender.TabIndex = 12;
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Font = new System.Drawing.Font("Microsoft JhengHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDOB.Location = new System.Drawing.Point(248, 332);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(123, 24);
            this.lblDOB.TabIndex = 13;
            this.lblDOB.Text = "Date of Birth";
            this.lblDOB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDOB
            // 
            this.txtDOB.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDOB.Location = new System.Drawing.Point(388, 326);
            this.txtDOB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDOB.Name = "txtDOB";
            this.txtDOB.ReadOnly = true;
            this.txtDOB.Size = new System.Drawing.Size(174, 32);
            this.txtDOB.TabIndex = 14;
            // 
            // lblEthnicity
            // 
            this.lblEthnicity.AutoSize = true;
            this.lblEthnicity.Font = new System.Drawing.Font("Microsoft JhengHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEthnicity.Location = new System.Drawing.Point(248, 380);
            this.lblEthnicity.Name = "lblEthnicity";
            this.lblEthnicity.Size = new System.Drawing.Size(87, 24);
            this.lblEthnicity.TabIndex = 15;
            this.lblEthnicity.Text = "Ethnicity";
            this.lblEthnicity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtEthnicity
            // 
            this.txtEthnicity.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEthnicity.Location = new System.Drawing.Point(388, 375);
            this.txtEthnicity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEthnicity.Name = "txtEthnicity";
            this.txtEthnicity.ReadOnly = true;
            this.txtEthnicity.Size = new System.Drawing.Size(174, 32);
            this.txtEthnicity.TabIndex = 16;
            // 
            // lblIC
            // 
            this.lblIC.AutoSize = true;
            this.lblIC.Font = new System.Drawing.Font("Microsoft JhengHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblIC.Location = new System.Drawing.Point(248, 425);
            this.lblIC.Name = "lblIC";
            this.lblIC.Size = new System.Drawing.Size(64, 24);
            this.lblIC.TabIndex = 17;
            this.lblIC.Text = "IC No.";
            this.lblIC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtIC
            // 
            this.txtIC.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtIC.Location = new System.Drawing.Point(388, 420);
            this.txtIC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIC.Name = "txtIC";
            this.txtIC.ReadOnly = true;
            this.txtIC.Size = new System.Drawing.Size(174, 32);
            this.txtIC.TabIndex = 18;
            this.txtIC.TextChanged += new System.EventHandler(this.txtIC_TextChanged);
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAddress.Location = new System.Drawing.Point(762, 375);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.Size = new System.Drawing.Size(174, 74);
            this.txtAddress.TabIndex = 24;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft JhengHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAddress.Location = new System.Drawing.Point(612, 380);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(83, 24);
            this.lblAddress.TabIndex = 23;
            this.lblAddress.Text = "Address";
            this.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmail.Location = new System.Drawing.Point(762, 326);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(174, 32);
            this.txtEmail.TabIndex = 22;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft JhengHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEmail.Location = new System.Drawing.Point(612, 332);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(136, 24);
            this.lblEmail.TabIndex = 21;
            this.lblEmail.Text = "Email Address";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtContact
            // 
            this.txtContact.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtContact.Location = new System.Drawing.Point(762, 280);
            this.txtContact.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtContact.Name = "txtContact";
            this.txtContact.ReadOnly = true;
            this.txtContact.Size = new System.Drawing.Size(174, 32);
            this.txtContact.TabIndex = 20;
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Font = new System.Drawing.Font("Microsoft JhengHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblContact.Location = new System.Drawing.Point(612, 284);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(116, 24);
            this.lblContact.TabIndex = 19;
            this.lblContact.Text = "Contact No.";
            this.lblContact.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAccess_EditProfile
            // 
            this.btnAccess_EditProfile.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAccess_EditProfile.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAccess_EditProfile.Location = new System.Drawing.Point(784, 458);
            this.btnAccess_EditProfile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAccess_EditProfile.Name = "btnAccess_EditProfile";
            this.btnAccess_EditProfile.Size = new System.Drawing.Size(151, 30);
            this.btnAccess_EditProfile.TabIndex = 6;
            this.btnAccess_EditProfile.Text = "Edit";
            this.btnAccess_EditProfile.UseVisualStyleBackColor = false;
            this.btnAccess_EditProfile.Click += new System.EventHandler(this.btnAccess_EditProfile_Click);
            this.btnAccess_EditProfile.MouseEnter += new System.EventHandler(this.btnAccess_EditProfile_MouseEnter);
            this.btnAccess_EditProfile.MouseLeave += new System.EventHandler(this.btnAccess_EditProfile_MouseLeave);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft JhengHei UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.txtName.Location = new System.Drawing.Point(513, 213);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(166, 35);
            this.txtName.TabIndex = 25;
            // 
            // TechnicianProfile
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(976, 500);
            this.ControlBox = false;
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnAccess_EditProfile);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.txtIC);
            this.Controls.Add(this.lblIC);
            this.Controls.Add(this.txtEthnicity);
            this.Controls.Add(this.lblEthnicity);
            this.Controls.Add(this.txtDOB);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.txtGender);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblText_Technician);
            this.Controls.Add(this.picProfile);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "TechnicianProfile";
            this.Text = "Profile";
            this.Load += new System.EventHandler(this.TechnicianProfile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picMenuProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnAccess_Profile;
        private Button btnAccess_Dashboard;
        private PictureBox picMenuProfile;
        private PictureBox picLogo;
        private Panel panelMenu;
        private Button btnLogOut;
        private Label lblName;
        private PictureBox picProfile;
        private Label lblText_Technician;
        private Label label2;
        private Label lblGender;
        private TextBox txtGender;
        private Label lblDOB;
        private TextBox txtDOB;
        private Label lblEthnicity;
        private TextBox txtEthnicity;
        private Label lblIC;
        private TextBox txtIC;
        private TextBox txtAddress;
        private Label lblAddress;
        private TextBox txtEmail;
        private Label lblEmail;
        private TextBox txtContact;
        private Label lblContact;
        private Button btnAccess_EditProfile;
        private TextBox txtName;
    }
}