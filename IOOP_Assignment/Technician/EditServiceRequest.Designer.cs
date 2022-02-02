namespace Technician
{
    partial class EditServiceRequest
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
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblEditServ = new System.Windows.Forms.Label();
            this.lblOrderID = new System.Windows.Forms.Label();
            this.comboJobID = new System.Windows.Forms.ComboBox();
            this.lblChange = new System.Windows.Forms.Label();
            this.radioCompleted = new System.Windows.Forms.RadioButton();
            this.lblCollectDate = new System.Windows.Forms.Label();
            this.CollectDatePicker = new System.Windows.Forms.DateTimePicker();
            this.lblServDescription = new System.Windows.Forms.Label();
            this.richServDescription = new System.Windows.Forms.RichTextBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnReset.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnReset.Location = new System.Drawing.Point(231, 411);
            this.btnReset.Name = "btnReset";
            this.btnReset.Padding = new System.Windows.Forms.Padding(4);
            this.btnReset.Size = new System.Drawing.Size(173, 40);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnSave.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSave.Location = new System.Drawing.Point(425, 411);
            this.btnSave.Name = "btnSave";
            this.btnSave.Padding = new System.Windows.Forms.Padding(4);
            this.btnSave.Size = new System.Drawing.Size(173, 40);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnClose.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClose.Location = new System.Drawing.Point(604, 412);
            this.btnClose.Name = "btnClose";
            this.btnClose.Padding = new System.Windows.Forms.Padding(4);
            this.btnClose.Size = new System.Drawing.Size(173, 40);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // lblEditServ
            // 
            this.lblEditServ.AutoSize = true;
            this.lblEditServ.Font = new System.Drawing.Font("Microsoft JhengHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEditServ.Location = new System.Drawing.Point(12, 23);
            this.lblEditServ.Name = "lblEditServ";
            this.lblEditServ.Size = new System.Drawing.Size(296, 36);
            this.lblEditServ.TabIndex = 8;
            this.lblEditServ.Text = "Edit Service Request:";
            // 
            // lblOrderID
            // 
            this.lblOrderID.AutoSize = true;
            this.lblOrderID.Font = new System.Drawing.Font("Microsoft JhengHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOrderID.Location = new System.Drawing.Point(12, 103);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(103, 29);
            this.lblOrderID.TabIndex = 9;
            this.lblOrderID.Text = "OrderID";
            // 
            // comboJobID
            // 
            this.comboJobID.FormattingEnabled = true;
            this.comboJobID.Items.AddRange(new object[] {
            "J0002",
            "J0003"});
            this.comboJobID.Location = new System.Drawing.Point(277, 103);
            this.comboJobID.Name = "comboJobID";
            this.comboJobID.Size = new System.Drawing.Size(140, 28);
            this.comboJobID.TabIndex = 10;
            // 
            // lblChange
            // 
            this.lblChange.AutoSize = true;
            this.lblChange.Font = new System.Drawing.Font("Microsoft JhengHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblChange.Location = new System.Drawing.Point(12, 161);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(172, 29);
            this.lblChange.TabIndex = 11;
            this.lblChange.Text = "Change Status";
            // 
            // radioCompleted
            // 
            this.radioCompleted.AutoSize = true;
            this.radioCompleted.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.radioCompleted.Location = new System.Drawing.Point(277, 196);
            this.radioCompleted.Name = "radioCompleted";
            this.radioCompleted.Size = new System.Drawing.Size(140, 29);
            this.radioCompleted.TabIndex = 12;
            this.radioCompleted.TabStop = true;
            this.radioCompleted.Text = "Completed";
            this.radioCompleted.UseVisualStyleBackColor = true;
            // 
            // lblCollectDate
            // 
            this.lblCollectDate.AutoSize = true;
            this.lblCollectDate.Font = new System.Drawing.Font("Microsoft JhengHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCollectDate.Location = new System.Drawing.Point(12, 345);
            this.lblCollectDate.Name = "lblCollectDate";
            this.lblCollectDate.Size = new System.Drawing.Size(183, 29);
            this.lblCollectDate.TabIndex = 13;
            this.lblCollectDate.Text = "Collection Date";
            // 
            // CollectDatePicker
            // 
            this.CollectDatePicker.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CollectDatePicker.Location = new System.Drawing.Point(277, 345);
            this.CollectDatePicker.Name = "CollectDatePicker";
            this.CollectDatePicker.Size = new System.Drawing.Size(345, 29);
            this.CollectDatePicker.TabIndex = 14;
            // 
            // lblServDescription
            // 
            this.lblServDescription.AutoSize = true;
            this.lblServDescription.Font = new System.Drawing.Font("Microsoft JhengHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblServDescription.Location = new System.Drawing.Point(12, 247);
            this.lblServDescription.Name = "lblServDescription";
            this.lblServDescription.Size = new System.Drawing.Size(235, 58);
            this.lblServDescription.TabIndex = 15;
            this.lblServDescription.Text = "Service Description/\r\nSuggestions";
            // 
            // richServDescription
            // 
            this.richServDescription.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richServDescription.Location = new System.Drawing.Point(277, 247);
            this.richServDescription.Name = "richServDescription";
            this.richServDescription.Size = new System.Drawing.Size(345, 58);
            this.richServDescription.TabIndex = 16;
            this.richServDescription.Text = "";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.radioButton2.Location = new System.Drawing.Point(277, 161);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(209, 29);
            this.radioButton2.TabIndex = 18;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Changes Required";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // EditServiceRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(800, 463);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.richServDescription);
            this.Controls.Add(this.lblServDescription);
            this.Controls.Add(this.CollectDatePicker);
            this.Controls.Add(this.lblCollectDate);
            this.Controls.Add(this.radioCompleted);
            this.Controls.Add(this.lblChange);
            this.Controls.Add(this.comboJobID);
            this.Controls.Add(this.lblOrderID);
            this.Controls.Add(this.lblEditServ);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnReset);
            this.Name = "EditServiceRequest";
            this.RightToLeftLayout = true;
            this.Text = "Edit Service Request";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnReset;
        private Button btnSave;
        private Button btnClose;
        private Label lblEditServ;
        private Label lblOrderID;
        private ComboBox comboJobID;
        private Label lblChange;
        private RadioButton radioCompleted;
        private Label lblCollectDate;
        private DateTimePicker CollectDatePicker;
        private Label lblServDescription;
        private RichTextBox richServDescription;
        private RadioButton radioButton2;
    }
}