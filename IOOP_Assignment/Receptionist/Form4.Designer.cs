namespace Assignment
{
    partial class frmServRequest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmServRequest));
            this.grpBoxRequest = new System.Windows.Forms.GroupBox();
            this.txtAmt = new System.Windows.Forms.TextBox();
            this.lblAmt = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblServType = new System.Windows.Forms.Label();
            this.btnPayment = new System.Windows.Forms.Button();
            this.radBtnUrgent = new System.Windows.Forms.RadioButton();
            this.radBtnNormal = new System.Windows.Forms.RadioButton();
            this.lstBoxService = new System.Windows.Forms.ListBox();
            this.lstBoxCustomer = new System.Windows.Forms.ListBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.linklblLogout = new System.Windows.Forms.LinkLabel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.linklblAccSet = new System.Windows.Forms.LinkLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.linklblServReq = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linklblNewCusReg = new System.Windows.Forms.LinkLabel();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblRcn = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.grpBoxRequest.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBoxRequest
            // 
            this.grpBoxRequest.BackColor = System.Drawing.Color.PeachPuff;
            this.grpBoxRequest.Controls.Add(this.txtAmt);
            this.grpBoxRequest.Controls.Add(this.lblAmt);
            this.grpBoxRequest.Controls.Add(this.btnClear);
            this.grpBoxRequest.Controls.Add(this.lblServType);
            this.grpBoxRequest.Controls.Add(this.btnPayment);
            this.grpBoxRequest.Controls.Add(this.radBtnUrgent);
            this.grpBoxRequest.Controls.Add(this.radBtnNormal);
            this.grpBoxRequest.Controls.Add(this.lstBoxService);
            this.grpBoxRequest.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpBoxRequest.Location = new System.Drawing.Point(211, 232);
            this.grpBoxRequest.Name = "grpBoxRequest";
            this.grpBoxRequest.Size = new System.Drawing.Size(761, 401);
            this.grpBoxRequest.TabIndex = 5;
            this.grpBoxRequest.TabStop = false;
            this.grpBoxRequest.Text = "Requested Service";
            // 
            // txtAmt
            // 
            this.txtAmt.Location = new System.Drawing.Point(399, 304);
            this.txtAmt.Name = "txtAmt";
            this.txtAmt.Size = new System.Drawing.Size(162, 40);
            this.txtAmt.TabIndex = 7;
            // 
            // lblAmt
            // 
            this.lblAmt.AutoSize = true;
            this.lblAmt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAmt.Location = new System.Drawing.Point(186, 312);
            this.lblAmt.Name = "lblAmt";
            this.lblAmt.Size = new System.Drawing.Size(213, 26);
            this.lblAmt.TabIndex = 6;
            this.lblAmt.Text = "Amount Paid:   RM";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.White;
            this.btnClear.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClear.Location = new System.Drawing.Point(189, 362);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(104, 34);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // lblServType
            // 
            this.lblServType.AutoSize = true;
            this.lblServType.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblServType.Location = new System.Drawing.Point(186, 257);
            this.lblServType.Name = "lblServType";
            this.lblServType.Size = new System.Drawing.Size(139, 25);
            this.lblServType.TabIndex = 4;
            this.lblServType.Text = "Service Type:";
            // 
            // btnPayment
            // 
            this.btnPayment.BackColor = System.Drawing.Color.White;
            this.btnPayment.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPayment.Location = new System.Drawing.Point(308, 362);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(256, 34);
            this.btnPayment.TabIndex = 3;
            this.btnPayment.Text = "Confirm Payment";
            this.btnPayment.UseVisualStyleBackColor = false;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // radBtnUrgent
            // 
            this.radBtnUrgent.AutoSize = true;
            this.radBtnUrgent.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radBtnUrgent.Location = new System.Drawing.Point(466, 257);
            this.radBtnUrgent.Name = "radBtnUrgent";
            this.radBtnUrgent.Size = new System.Drawing.Size(95, 29);
            this.radBtnUrgent.TabIndex = 2;
            this.radBtnUrgent.TabStop = true;
            this.radBtnUrgent.Text = "Urgent";
            this.radBtnUrgent.UseVisualStyleBackColor = true;
            // 
            // radBtnNormal
            // 
            this.radBtnNormal.AutoSize = true;
            this.radBtnNormal.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radBtnNormal.Location = new System.Drawing.Point(339, 257);
            this.radBtnNormal.Name = "radBtnNormal";
            this.radBtnNormal.Size = new System.Drawing.Size(103, 29);
            this.radBtnNormal.TabIndex = 1;
            this.radBtnNormal.TabStop = true;
            this.radBtnNormal.Text = "Normal";
            this.radBtnNormal.UseVisualStyleBackColor = true;
            // 
            // lstBoxService
            // 
            this.lstBoxService.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstBoxService.FormattingEnabled = true;
            this.lstBoxService.ItemHeight = 22;
            this.lstBoxService.Items.AddRange(new object[] {
            "\t\t\t\t\t Normal\t                 Urgent",
            "1 Remove virus, malware or spyware\t\t RM 50 \t  \tRM 80",
            "2 Troubleshot and fix computer running slow \t RM 60      \tRM 90",
            "3 Laptop screen replacement \t\t\t RM 380     \tRM 430",
            "4 Laptop keyboard replacement \t\t\t RM 160     \tRM 200",
            "5 Laptop battery replacement\t\t\t RM 180     \tRM 210",
            "6 Operating System Format and Installation\t   \t RM 100     \tRM 150",
            "7 Data backup and recovery \t\t\t RM 80       \tRM 130",
            "8 Internet connectivity issues \t\t\t RM 70       \tRM 100"});
            this.lstBoxService.Location = new System.Drawing.Point(31, 39);
            this.lstBoxService.Name = "lstBoxService";
            this.lstBoxService.Size = new System.Drawing.Size(722, 202);
            this.lstBoxService.TabIndex = 0;
            // 
            // lstBoxCustomer
            // 
            this.lstBoxCustomer.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstBoxCustomer.FormattingEnabled = true;
            this.lstBoxCustomer.ItemHeight = 22;
            this.lstBoxCustomer.Location = new System.Drawing.Point(227, 86);
            this.lstBoxCustomer.Name = "lstBoxCustomer";
            this.lstBoxCustomer.Size = new System.Drawing.Size(722, 136);
            this.lstBoxCustomer.TabIndex = 6;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(491, 6);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(203, 32);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "Service Request";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSearch.Location = new System.Drawing.Point(227, 49);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(77, 25);
            this.lblSearch.TabIndex = 9;
            this.lblSearch.Text = "Search:";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSearch.Location = new System.Drawing.Point(310, 46);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(285, 30);
            this.txtSearch.TabIndex = 10;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.PeachPuff;
            this.groupBox4.Controls.Add(this.linklblLogout);
            this.groupBox4.Location = new System.Drawing.Point(1, 419);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(203, 36);
            this.groupBox4.TabIndex = 30;
            this.groupBox4.TabStop = false;
            // 
            // linklblLogout
            // 
            this.linklblLogout.ActiveLinkColor = System.Drawing.Color.DarkRed;
            this.linklblLogout.AutoSize = true;
            this.linklblLogout.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.linklblLogout.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.linklblLogout.LinkColor = System.Drawing.Color.Blue;
            this.linklblLogout.Location = new System.Drawing.Point(54, 9);
            this.linklblLogout.Name = "linklblLogout";
            this.linklblLogout.Size = new System.Drawing.Size(92, 20);
            this.linklblLogout.TabIndex = 28;
            this.linklblLogout.TabStop = true;
            this.linklblLogout.Text = "LOG OUT";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.PeachPuff;
            this.groupBox3.Controls.Add(this.linklblAccSet);
            this.groupBox3.Location = new System.Drawing.Point(1, 356);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(203, 40);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            // 
            // linklblAccSet
            // 
            this.linklblAccSet.ActiveLinkColor = System.Drawing.Color.DarkRed;
            this.linklblAccSet.AutoSize = true;
            this.linklblAccSet.BackColor = System.Drawing.Color.PeachPuff;
            this.linklblAccSet.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.linklblAccSet.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.linklblAccSet.LinkColor = System.Drawing.Color.Blue;
            this.linklblAccSet.Location = new System.Drawing.Point(11, 12);
            this.linklblAccSet.Name = "linklblAccSet";
            this.linklblAccSet.Size = new System.Drawing.Size(181, 20);
            this.linklblAccSet.TabIndex = 27;
            this.linklblAccSet.TabStop = true;
            this.linklblAccSet.Text = "ACCOUNT SETTING";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.PeachPuff;
            this.groupBox2.Controls.Add(this.linklblServReq);
            this.groupBox2.Location = new System.Drawing.Point(1, 295);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(202, 42);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            // 
            // linklblServReq
            // 
            this.linklblServReq.ActiveLinkColor = System.Drawing.Color.DarkRed;
            this.linklblServReq.AutoSize = true;
            this.linklblServReq.BackColor = System.Drawing.Color.PeachPuff;
            this.linklblServReq.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.linklblServReq.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.linklblServReq.LinkColor = System.Drawing.Color.Blue;
            this.linklblServReq.Location = new System.Drawing.Point(15, 11);
            this.linklblServReq.Name = "linklblServReq";
            this.linklblServReq.Size = new System.Drawing.Size(174, 20);
            this.linklblServReq.TabIndex = 26;
            this.linklblServReq.TabStop = true;
            this.linklblServReq.Text = "SERVICE REQUEST";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PeachPuff;
            this.groupBox1.Controls.Add(this.linklblNewCusReg);
            this.groupBox1.Location = new System.Drawing.Point(1, 218);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(202, 59);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            // 
            // linklblNewCusReg
            // 
            this.linklblNewCusReg.ActiveLinkColor = System.Drawing.Color.DarkRed;
            this.linklblNewCusReg.AutoSize = true;
            this.linklblNewCusReg.BackColor = System.Drawing.Color.PeachPuff;
            this.linklblNewCusReg.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.linklblNewCusReg.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.linklblNewCusReg.LinkColor = System.Drawing.Color.Blue;
            this.linklblNewCusReg.Location = new System.Drawing.Point(22, 10);
            this.linklblNewCusReg.Name = "linklblNewCusReg";
            this.linklblNewCusReg.Size = new System.Drawing.Size(157, 40);
            this.linklblNewCusReg.TabIndex = 25;
            this.linklblNewCusReg.TabStop = true;
            this.linklblNewCusReg.Text = "NEW CUSTOMER\r\nREGISTRATION";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.BackColor = System.Drawing.Color.SeaShell;
            this.lblRole.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRole.Location = new System.Drawing.Point(25, 181);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(158, 22);
            this.lblRole.TabIndex = 29;
            this.lblRole.Text = "Role: Receptionist";
            // 
            // lblRcn
            // 
            this.lblRcn.AutoSize = true;
            this.lblRcn.BackColor = System.Drawing.Color.SeaShell;
            this.lblRcn.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRcn.Location = new System.Drawing.Point(38, 150);
            this.lblRcn.Name = "lblRcn";
            this.lblRcn.Size = new System.Drawing.Size(126, 22);
            this.lblRcn.TabIndex = 28;
            this.lblRcn.Text = "Chew Yong En";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackColor = System.Drawing.Color.SeaShell;
            this.pictureBoxLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.BackgroundImage")));
            this.pictureBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxLogo.Location = new System.Drawing.Point(12, 14);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(180, 120);
            this.pictureBoxLogo.TabIndex = 27;
            this.pictureBoxLogo.TabStop = false;
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.SeaShell;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(203, 644);
            this.splitter1.TabIndex = 26;
            this.splitter1.TabStop = false;
            // 
            // frmServRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(986, 644);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.lblRcn);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.grpBoxRequest);
            this.Controls.Add(this.lstBoxCustomer);
            this.Name = "frmServRequest";
            this.Text = "Service Request ";
            this.grpBoxRequest.ResumeLayout(false);
            this.grpBoxRequest.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox grpBoxRequest;
        private Button btnClear;
        private Label lblServType;
        private Button btnPayment;
        private RadioButton radBtnUrgent;
        private RadioButton radBtnNormal;
        private ListBox lstBoxService;
        private ListBox lstBoxCustomer;
        private Label lblTitle;
        private TextBox txtAmt;
        private Label lblAmt;
        private Label lblSearch;
        private TextBox txtSearch;
        private GroupBox groupBox4;
        private LinkLabel linklblLogout;
        private GroupBox groupBox3;
        private LinkLabel linklblAccSet;
        private GroupBox groupBox2;
        private LinkLabel linklblServReq;
        private GroupBox groupBox1;
        private LinkLabel linklblNewCusReg;
        private Label lblRole;
        private Label lblRcn;
        private PictureBox pictureBoxLogo;
        private Splitter splitter1;
    }
}