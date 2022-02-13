namespace IOOP_Assignment
{
    partial class UserControlServiceReport
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblArrow3 = new System.Windows.Forms.Label();
            this.lblArrow1 = new System.Windows.Forms.Label();
            this.lblArrow2 = new System.Windows.Forms.Label();
            this.lblServType = new System.Windows.Forms.Label();
            this.dataGVServiceReport = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVServiceReport)).BeginInit();
            this.SuspendLayout();
            // 
            // lblArrow3
            // 
            this.lblArrow3.AutoSize = true;
            this.lblArrow3.BackColor = System.Drawing.Color.Gray;
            this.lblArrow3.Location = new System.Drawing.Point(672, 50);
            this.lblArrow3.MaximumSize = new System.Drawing.Size(2, 20);
            this.lblArrow3.MinimumSize = new System.Drawing.Size(2, 20);
            this.lblArrow3.Name = "lblArrow3";
            this.lblArrow3.Size = new System.Drawing.Size(2, 20);
            this.lblArrow3.TabIndex = 77;
            this.lblArrow3.Text = "label12";
            // 
            // lblArrow1
            // 
            this.lblArrow1.AutoSize = true;
            this.lblArrow1.BackColor = System.Drawing.Color.Gray;
            this.lblArrow1.Location = new System.Drawing.Point(234, 48);
            this.lblArrow1.MaximumSize = new System.Drawing.Size(2, 20);
            this.lblArrow1.MinimumSize = new System.Drawing.Size(2, 20);
            this.lblArrow1.Name = "lblArrow1";
            this.lblArrow1.Size = new System.Drawing.Size(2, 20);
            this.lblArrow1.TabIndex = 76;
            this.lblArrow1.Text = "label11";
            // 
            // lblArrow2
            // 
            this.lblArrow2.AutoSize = true;
            this.lblArrow2.BackColor = System.Drawing.Color.Gray;
            this.lblArrow2.Location = new System.Drawing.Point(234, 48);
            this.lblArrow2.MaximumSize = new System.Drawing.Size(500, 2);
            this.lblArrow2.MinimumSize = new System.Drawing.Size(440, 2);
            this.lblArrow2.Name = "lblArrow2";
            this.lblArrow2.Size = new System.Drawing.Size(440, 2);
            this.lblArrow2.TabIndex = 75;
            this.lblArrow2.Text = "label10";
            // 
            // lblServType
            // 
            this.lblServType.AutoSize = true;
            this.lblServType.Location = new System.Drawing.Point(406, 28);
            this.lblServType.Name = "lblServType";
            this.lblServType.Size = new System.Drawing.Size(71, 15);
            this.lblServType.TabIndex = 74;
            this.lblServType.Text = "Service Type";
            // 
            // dataGVServiceReport
            // 
            this.dataGVServiceReport.AllowUserToAddRows = false;
            this.dataGVServiceReport.AllowUserToDeleteRows = false;
            this.dataGVServiceReport.AllowUserToResizeColumns = false;
            this.dataGVServiceReport.AllowUserToResizeRows = false;
            this.dataGVServiceReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGVServiceReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVServiceReport.Location = new System.Drawing.Point(15, 73);
            this.dataGVServiceReport.Name = "dataGVServiceReport";
            this.dataGVServiceReport.ReadOnly = true;
            this.dataGVServiceReport.RowHeadersWidth = 51;
            this.dataGVServiceReport.RowTemplate.Height = 25;
            this.dataGVServiceReport.Size = new System.Drawing.Size(795, 326);
            this.dataGVServiceReport.TabIndex = 78;
            this.dataGVServiceReport.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGVServiceReport_CellContentClick);
            // 
            // UserControlServiceReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(229)))), ((int)(((byte)(237)))));
            this.Controls.Add(this.dataGVServiceReport);
            this.Controls.Add(this.lblArrow3);
            this.Controls.Add(this.lblArrow1);
            this.Controls.Add(this.lblArrow2);
            this.Controls.Add(this.lblServType);
            this.Name = "UserControlServiceReport";
            this.Size = new System.Drawing.Size(836, 462);
            this.Load += new System.EventHandler(this.UserControlServiceReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVServiceReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblArrow3;
        private Label lblArrow1;
        private Label lblArrow2;
        private Label lblServType;
        private DataGridView dataGVServiceReport;
    }
}
