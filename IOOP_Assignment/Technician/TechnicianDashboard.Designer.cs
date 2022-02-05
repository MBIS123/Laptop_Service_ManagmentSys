namespace IOOP_Assignment
{
    partial class TechnicianDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TechnicianDashboard));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnAccess_Profile = new System.Windows.Forms.Button();
            this.btnAccess_Dashboard = new System.Windows.Forms.Button();
            this.picMenuProfile = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.panelWidget_Comp = new System.Windows.Forms.Panel();
            this.lblWidg_TextCompServ = new System.Windows.Forms.Label();
            this.lblWidg_ValueCompServ = new System.Windows.Forms.Label();
            this.panelWidget_Urg = new System.Windows.Forms.Panel();
            this.lblWidg_ValueUrgServ = new System.Windows.Forms.Label();
            this.lblWidg_TextUrgServ = new System.Windows.Forms.Label();
            this.panelWidget_Pend = new System.Windows.Forms.Panel();
            this.lblWidg_ValuePendServ = new System.Windows.Forms.Label();
            this.lblWidg_TextPendServ = new System.Windows.Forms.Label();
            this.btnAccess_AllServ = new System.Windows.Forms.Button();
            this.dataGrid_AllServ = new System.Windows.Forms.DataGridView();
            this.JobID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RequestDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NormalorUrgent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CollectionDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTable_TextAllServ = new System.Windows.Forms.Label();
            this.panelTable_Pend = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMenuProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.panelWidget_Comp.SuspendLayout();
            this.panelWidget_Urg.SuspendLayout();
            this.panelWidget_Pend.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_AllServ)).BeginInit();
            this.panelTable_Pend.SuspendLayout();
            this.SuspendLayout();
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
            this.panelMenu.Location = new System.Drawing.Point(2, 1);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(248, 716);
            this.panelMenu.TabIndex = 6;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogOut.Location = new System.Drawing.Point(41, 587);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(173, 40);
            this.btnLogOut.TabIndex = 5;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.MouseEnter += new System.EventHandler(this.btnLogOut_MouseEnter);
            this.btnLogOut.MouseLeave += new System.EventHandler(this.btnLogOut_MouseLeave);
            // 
            // btnAccess_Profile
            // 
            this.btnAccess_Profile.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAccess_Profile.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAccess_Profile.Location = new System.Drawing.Point(41, 342);
            this.btnAccess_Profile.Name = "btnAccess_Profile";
            this.btnAccess_Profile.Padding = new System.Windows.Forms.Padding(4);
            this.btnAccess_Profile.Size = new System.Drawing.Size(173, 40);
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
            this.btnAccess_Dashboard.Location = new System.Drawing.Point(41, 272);
            this.btnAccess_Dashboard.Name = "btnAccess_Dashboard";
            this.btnAccess_Dashboard.Padding = new System.Windows.Forms.Padding(4);
            this.btnAccess_Dashboard.Size = new System.Drawing.Size(173, 40);
            this.btnAccess_Dashboard.TabIndex = 2;
            this.btnAccess_Dashboard.Text = "Dashboard";
            this.btnAccess_Dashboard.UseVisualStyleBackColor = false;
            this.btnAccess_Dashboard.MouseEnter += new System.EventHandler(this.btnAccess_Dashboard_MouseEnter);
            this.btnAccess_Dashboard.MouseLeave += new System.EventHandler(this.btnAccess_Dashboard_MouseLeave);
            // 
            // picMenuProfile
            // 
            this.picMenuProfile.Image = ((System.Drawing.Image)(resources.GetObject("picMenuProfile.Image")));
            this.picMenuProfile.Location = new System.Drawing.Point(93, 436);
            this.picMenuProfile.Name = "picMenuProfile";
            this.picMenuProfile.Size = new System.Drawing.Size(63, 82);
            this.picMenuProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMenuProfile.TabIndex = 1;
            this.picMenuProfile.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(52, 529);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(142, 25);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Chew Jay Ren";
            // 
            // picLogo
            // 
            this.picLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(52, 30);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(143, 131);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // panelWidget_Comp
            // 
            this.panelWidget_Comp.BackColor = System.Drawing.Color.Khaki;
            this.panelWidget_Comp.Controls.Add(this.lblWidg_TextCompServ);
            this.panelWidget_Comp.Controls.Add(this.lblWidg_ValueCompServ);
            this.panelWidget_Comp.Location = new System.Drawing.Point(1118, 62);
            this.panelWidget_Comp.Name = "panelWidget_Comp";
            this.panelWidget_Comp.Size = new System.Drawing.Size(237, 100);
            this.panelWidget_Comp.TabIndex = 9;
            // 
            // lblWidg_TextCompServ
            // 
            this.lblWidg_TextCompServ.AutoSize = true;
            this.lblWidg_TextCompServ.Font = new System.Drawing.Font("Microsoft JhengHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblWidg_TextCompServ.Location = new System.Drawing.Point(63, 15);
            this.lblWidg_TextCompServ.Name = "lblWidg_TextCompServ";
            this.lblWidg_TextCompServ.Size = new System.Drawing.Size(171, 72);
            this.lblWidg_TextCompServ.TabIndex = 0;
            this.lblWidg_TextCompServ.Text = "Completed\r\nThis Month";
            // 
            // lblWidg_ValueCompServ
            // 
            this.lblWidg_ValueCompServ.AutoSize = true;
            this.lblWidg_ValueCompServ.Font = new System.Drawing.Font("Microsoft JhengHei UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblWidg_ValueCompServ.Location = new System.Drawing.Point(3, 10);
            this.lblWidg_ValueCompServ.Name = "lblWidg_ValueCompServ";
            this.lblWidg_ValueCompServ.Size = new System.Drawing.Size(69, 77);
            this.lblWidg_ValueCompServ.TabIndex = 2;
            this.lblWidg_ValueCompServ.Text = "1";
            this.lblWidg_ValueCompServ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelWidget_Urg
            // 
            this.panelWidget_Urg.BackColor = System.Drawing.Color.Khaki;
            this.panelWidget_Urg.Controls.Add(this.lblWidg_ValueUrgServ);
            this.panelWidget_Urg.Controls.Add(this.lblWidg_TextUrgServ);
            this.panelWidget_Urg.Location = new System.Drawing.Point(783, 62);
            this.panelWidget_Urg.Name = "panelWidget_Urg";
            this.panelWidget_Urg.Size = new System.Drawing.Size(237, 100);
            this.panelWidget_Urg.TabIndex = 8;
            // 
            // lblWidg_ValueUrgServ
            // 
            this.lblWidg_ValueUrgServ.AutoSize = true;
            this.lblWidg_ValueUrgServ.Font = new System.Drawing.Font("Microsoft JhengHei UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblWidg_ValueUrgServ.Location = new System.Drawing.Point(11, 10);
            this.lblWidg_ValueUrgServ.Name = "lblWidg_ValueUrgServ";
            this.lblWidg_ValueUrgServ.Size = new System.Drawing.Size(69, 77);
            this.lblWidg_ValueUrgServ.TabIndex = 2;
            this.lblWidg_ValueUrgServ.Text = "1";
            this.lblWidg_ValueUrgServ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWidg_TextUrgServ
            // 
            this.lblWidg_TextUrgServ.AutoSize = true;
            this.lblWidg_TextUrgServ.Font = new System.Drawing.Font("Microsoft JhengHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblWidg_TextUrgServ.Location = new System.Drawing.Point(86, 31);
            this.lblWidg_TextUrgServ.Name = "lblWidg_TextUrgServ";
            this.lblWidg_TextUrgServ.Size = new System.Drawing.Size(110, 36);
            this.lblWidg_TextUrgServ.TabIndex = 0;
            this.lblWidg_TextUrgServ.Text = "Urgent";
            // 
            // panelWidget_Pend
            // 
            this.panelWidget_Pend.BackColor = System.Drawing.Color.Khaki;
            this.panelWidget_Pend.Controls.Add(this.lblWidg_ValuePendServ);
            this.panelWidget_Pend.Controls.Add(this.lblWidg_TextPendServ);
            this.panelWidget_Pend.Location = new System.Drawing.Point(447, 62);
            this.panelWidget_Pend.Name = "panelWidget_Pend";
            this.panelWidget_Pend.Size = new System.Drawing.Size(237, 100);
            this.panelWidget_Pend.TabIndex = 5;
            // 
            // lblWidg_ValuePendServ
            // 
            this.lblWidg_ValuePendServ.AutoSize = true;
            this.lblWidg_ValuePendServ.Font = new System.Drawing.Font("Microsoft JhengHei UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblWidg_ValuePendServ.Location = new System.Drawing.Point(13, 10);
            this.lblWidg_ValuePendServ.Name = "lblWidg_ValuePendServ";
            this.lblWidg_ValuePendServ.Size = new System.Drawing.Size(69, 77);
            this.lblWidg_ValuePendServ.TabIndex = 1;
            this.lblWidg_ValuePendServ.Text = "2";
            this.lblWidg_ValuePendServ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWidg_TextPendServ
            // 
            this.lblWidg_TextPendServ.AutoSize = true;
            this.lblWidg_TextPendServ.Font = new System.Drawing.Font("Microsoft JhengHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblWidg_TextPendServ.Location = new System.Drawing.Point(88, 31);
            this.lblWidg_TextPendServ.Name = "lblWidg_TextPendServ";
            this.lblWidg_TextPendServ.Size = new System.Drawing.Size(129, 36);
            this.lblWidg_TextPendServ.TabIndex = 0;
            this.lblWidg_TextPendServ.Text = "Pending";
            // 
            // btnAccess_AllServ
            // 
            this.btnAccess_AllServ.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAccess_AllServ.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAccess_AllServ.Location = new System.Drawing.Point(987, 403);
            this.btnAccess_AllServ.Name = "btnAccess_AllServ";
            this.btnAccess_AllServ.Padding = new System.Windows.Forms.Padding(4);
            this.btnAccess_AllServ.Size = new System.Drawing.Size(173, 40);
            this.btnAccess_AllServ.TabIndex = 3;
            this.btnAccess_AllServ.Text = "Edit";
            this.btnAccess_AllServ.UseVisualStyleBackColor = false;
            this.btnAccess_AllServ.MouseEnter += new System.EventHandler(this.btnAccess_PendServ_MouseEnter);
            this.btnAccess_AllServ.MouseLeave += new System.EventHandler(this.btnAccess_PendServ_MouseLeave);
            // 
            // dataGrid_AllServ
            // 
            this.dataGrid_AllServ.BackgroundColor = System.Drawing.Color.Khaki;
            this.dataGrid_AllServ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_AllServ.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.JobID,
            this.RequestDate,
            this.ServType,
            this.NormalorUrgent,
            this.Status,
            this.CollectionDate,
            this.Comments});
            this.dataGrid_AllServ.Location = new System.Drawing.Point(0, 61);
            this.dataGrid_AllServ.Name = "dataGrid_AllServ";
            this.dataGrid_AllServ.RowHeadersWidth = 51;
            this.dataGrid_AllServ.RowTemplate.Height = 29;
            this.dataGrid_AllServ.Size = new System.Drawing.Size(1160, 323);
            this.dataGrid_AllServ.TabIndex = 4;
            // 
            // JobID
            // 
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            this.JobID.DefaultCellStyle = dataGridViewCellStyle8;
            this.JobID.HeaderText = "JobID";
            this.JobID.MinimumWidth = 6;
            this.JobID.Name = "JobID";
            this.JobID.Width = 50;
            // 
            // RequestDate
            // 
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            this.RequestDate.DefaultCellStyle = dataGridViewCellStyle9;
            this.RequestDate.HeaderText = "Request Date";
            this.RequestDate.MinimumWidth = 6;
            this.RequestDate.Name = "RequestDate";
            this.RequestDate.Width = 125;
            // 
            // ServType
            // 
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            this.ServType.DefaultCellStyle = dataGridViewCellStyle10;
            this.ServType.HeaderText = "Service Requested";
            this.ServType.MinimumWidth = 6;
            this.ServType.Name = "ServType";
            this.ServType.Width = 300;
            // 
            // NormalorUrgent
            // 
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            this.NormalorUrgent.DefaultCellStyle = dataGridViewCellStyle11;
            this.NormalorUrgent.HeaderText = "Service Type";
            this.NormalorUrgent.MinimumWidth = 6;
            this.NormalorUrgent.Name = "NormalorUrgent";
            this.NormalorUrgent.Width = 125;
            // 
            // Status
            // 
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            this.Status.DefaultCellStyle = dataGridViewCellStyle12;
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.Width = 200;
            // 
            // CollectionDate
            // 
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            this.CollectionDate.DefaultCellStyle = dataGridViewCellStyle13;
            this.CollectionDate.HeaderText = "Collection Date";
            this.CollectionDate.MinimumWidth = 6;
            this.CollectionDate.Name = "CollectionDate";
            this.CollectionDate.Width = 125;
            // 
            // Comments
            // 
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            this.Comments.DefaultCellStyle = dataGridViewCellStyle14;
            this.Comments.HeaderText = "Comments";
            this.Comments.MinimumWidth = 6;
            this.Comments.Name = "Comments";
            this.Comments.Width = 125;
            // 
            // lblTable_TextAllServ
            // 
            this.lblTable_TextAllServ.AutoSize = true;
            this.lblTable_TextAllServ.Font = new System.Drawing.Font("Microsoft JhengHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTable_TextAllServ.Location = new System.Drawing.Point(3, 0);
            this.lblTable_TextAllServ.Name = "lblTable_TextAllServ";
            this.lblTable_TextAllServ.Size = new System.Drawing.Size(320, 36);
            this.lblTable_TextAllServ.TabIndex = 7;
            this.lblTable_TextAllServ.Text = "Your Service Requests:";
            // 
            // panelTable_Pend
            // 
            this.panelTable_Pend.Controls.Add(this.lblTable_TextAllServ);
            this.panelTable_Pend.Controls.Add(this.dataGrid_AllServ);
            this.panelTable_Pend.Controls.Add(this.btnAccess_AllServ);
            this.panelTable_Pend.Location = new System.Drawing.Point(299, 185);
            this.panelTable_Pend.Name = "panelTable_Pend";
            this.panelTable_Pend.Size = new System.Drawing.Size(1163, 453);
            this.panelTable_Pend.TabIndex = 13;
            // 
            // TechnicianDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(1496, 666);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelWidget_Comp);
            this.Controls.Add(this.panelWidget_Urg);
            this.Controls.Add(this.panelWidget_Pend);
            this.Controls.Add(this.panelTable_Pend);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "TechnicianDashboard";
            this.Text = "Technician Dashboard";
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMenuProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.panelWidget_Comp.ResumeLayout(false);
            this.panelWidget_Comp.PerformLayout();
            this.panelWidget_Urg.ResumeLayout(false);
            this.panelWidget_Urg.PerformLayout();
            this.panelWidget_Pend.ResumeLayout(false);
            this.panelWidget_Pend.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_AllServ)).EndInit();
            this.panelTable_Pend.ResumeLayout(false);
            this.panelTable_Pend.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelMenu;
        private Button btnLogOut;
        private Button btnAccess_Profile;
        private Button btnAccess_Dashboard;
        private PictureBox picMenuProfile;
        private Label lblName;
        private PictureBox picLogo;
        private Panel panelWidget_Comp;
        private Label lblWidg_ValueCompServ;
        private Label lblWidg_TextCompServ;
        private Panel panelWidget_Urg;
        private Label lblWidg_ValueUrgServ;
        private Label lblWidg_TextUrgServ;
        private Panel panelWidget_Pend;
        private Label lblWidg_ValuePendServ;
        private Label lblWidg_TextPendServ;
        private Button btnAccess_AllServ;
        private DataGridView dataGrid_AllServ;
        private DataGridViewTextBoxColumn JobID;
        private DataGridViewTextBoxColumn RequestDate;
        private DataGridViewTextBoxColumn ServType;
        private DataGridViewTextBoxColumn NormalorUrgent;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn CollectionDate;
        private DataGridViewTextBoxColumn Comments;
        private Label lblTable_TextAllServ;
        private Panel panelTable_Pend;
    }
}