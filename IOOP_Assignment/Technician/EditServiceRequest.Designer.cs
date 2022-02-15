﻿namespace IOOP_Assignment
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
            this.comboOrderID = new System.Windows.Forms.ComboBox();
            this.lblChange = new System.Windows.Forms.Label();
            this.radioCompleted = new System.Windows.Forms.RadioButton();
            this.lblCollectDate = new System.Windows.Forms.Label();
            this.CollectionDatePicker = new System.Windows.Forms.DateTimePicker();
            this.lblServDescription = new System.Windows.Forms.Label();
            this.richServDescription = new System.Windows.Forms.RichTextBox();
            this.radioChangesRequired = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnReset.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnReset.Location = new System.Drawing.Point(242, 278);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnReset.Size = new System.Drawing.Size(151, 30);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            this.btnReset.MouseEnter += new System.EventHandler(this.btnReset_MouseEnter);
            this.btnReset.MouseLeave += new System.EventHandler(this.btnReset_MouseLeave);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnSave.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSave.Location = new System.Drawing.Point(416, 279);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSave.Size = new System.Drawing.Size(151, 30);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.MouseEnter += new System.EventHandler(this.btnSave_MouseEnter);
            this.btnSave.MouseLeave += new System.EventHandler(this.btnSave_MouseLeave);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnClose.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClose.Location = new System.Drawing.Point(592, 279);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnClose.Size = new System.Drawing.Size(151, 30);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseEnter += new System.EventHandler(this.btnClose_MouseEnter);
            this.btnClose.MouseLeave += new System.EventHandler(this.btnClose_MouseLeave);
            // 
            // lblEditServ
            // 
            this.lblEditServ.AutoSize = true;
            this.lblEditServ.Font = new System.Drawing.Font("Microsoft JhengHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEditServ.Location = new System.Drawing.Point(10, 17);
            this.lblEditServ.Name = "lblEditServ";
            this.lblEditServ.Size = new System.Drawing.Size(234, 28);
            this.lblEditServ.TabIndex = 8;
            this.lblEditServ.Text = "Edit Service Request:";
            // 
            // lblOrderID
            // 
            this.lblOrderID.AutoSize = true;
            this.lblOrderID.Font = new System.Drawing.Font("Microsoft JhengHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOrderID.Location = new System.Drawing.Point(10, 77);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(86, 24);
            this.lblOrderID.TabIndex = 9;
            this.lblOrderID.Text = "OrderID";
            // 
            // comboOrderID
            // 
            this.comboOrderID.FormattingEnabled = true;
            this.comboOrderID.Location = new System.Drawing.Point(242, 77);
            this.comboOrderID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboOrderID.Name = "comboOrderID";
            this.comboOrderID.Size = new System.Drawing.Size(123, 23);
            this.comboOrderID.TabIndex = 10;
            this.comboOrderID.SelectionChangeCommitted += new System.EventHandler(this.comboOrderID_SelectionChangeCommitted);
            // 
            // lblChange
            // 
            this.lblChange.AutoSize = true;
            this.lblChange.Font = new System.Drawing.Font("Microsoft JhengHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblChange.Location = new System.Drawing.Point(10, 121);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(143, 24);
            this.lblChange.TabIndex = 11;
            this.lblChange.Text = "Change Status";
            // 
            // radioCompleted
            // 
            this.radioCompleted.AutoSize = true;
            this.radioCompleted.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.radioCompleted.Location = new System.Drawing.Point(455, 121);
            this.radioCompleted.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioCompleted.Name = "radioCompleted";
            this.radioCompleted.Size = new System.Drawing.Size(111, 24);
            this.radioCompleted.TabIndex = 12;
            this.radioCompleted.TabStop = true;
            this.radioCompleted.Text = "Completed";
            this.radioCompleted.UseVisualStyleBackColor = true;
            this.radioCompleted.CheckedChanged += new System.EventHandler(this.radioCompleted_CheckedChanged);
            // 
            // lblCollectDate
            // 
            this.lblCollectDate.AutoSize = true;
            this.lblCollectDate.Font = new System.Drawing.Font("Microsoft JhengHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCollectDate.Location = new System.Drawing.Point(10, 230);
            this.lblCollectDate.Name = "lblCollectDate";
            this.lblCollectDate.Size = new System.Drawing.Size(151, 24);
            this.lblCollectDate.TabIndex = 13;
            this.lblCollectDate.Text = "Collection Date";
            // 
            // CollectionDatePicker
            // 
            this.CollectionDatePicker.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CollectionDatePicker.Location = new System.Drawing.Point(242, 230);
            this.CollectionDatePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CollectionDatePicker.Name = "CollectionDatePicker";
            this.CollectionDatePicker.Size = new System.Drawing.Size(438, 25);
            this.CollectionDatePicker.TabIndex = 14;
            this.CollectionDatePicker.ValueChanged += new System.EventHandler(this.CollectionDatePicker_ValueChanged);
            // 
            // lblServDescription
            // 
            this.lblServDescription.AutoSize = true;
            this.lblServDescription.Font = new System.Drawing.Font("Microsoft JhengHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblServDescription.Location = new System.Drawing.Point(10, 156);
            this.lblServDescription.Name = "lblServDescription";
            this.lblServDescription.Size = new System.Drawing.Size(195, 48);
            this.lblServDescription.TabIndex = 15;
            this.lblServDescription.Text = "Service Description/\r\nSuggestions";
            // 
            // richServDescription
            // 
            this.richServDescription.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richServDescription.Location = new System.Drawing.Point(242, 156);
            this.richServDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richServDescription.Name = "richServDescription";
            this.richServDescription.Size = new System.Drawing.Size(438, 44);
            this.richServDescription.TabIndex = 16;
            this.richServDescription.Text = "";
            // 
            // radioChangesRequired
            // 
            this.radioChangesRequired.AutoSize = true;
            this.radioChangesRequired.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.radioChangesRequired.Location = new System.Drawing.Point(242, 121);
            this.radioChangesRequired.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioChangesRequired.Name = "radioChangesRequired";
            this.radioChangesRequired.Size = new System.Drawing.Size(167, 24);
            this.radioChangesRequired.TabIndex = 18;
            this.radioChangesRequired.TabStop = true;
            this.radioChangesRequired.Text = "Changes Required";
            this.radioChangesRequired.UseVisualStyleBackColor = true;
            this.radioChangesRequired.CheckedChanged += new System.EventHandler(this.radioChangesRequired_CheckedChanged);
            // 
            // EditServiceRequest
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(748, 316);
            this.ControlBox = false;
            this.Controls.Add(this.radioChangesRequired);
            this.Controls.Add(this.richServDescription);
            this.Controls.Add(this.lblServDescription);
            this.Controls.Add(this.CollectionDatePicker);
            this.Controls.Add(this.lblCollectDate);
            this.Controls.Add(this.radioCompleted);
            this.Controls.Add(this.lblChange);
            this.Controls.Add(this.comboOrderID);
            this.Controls.Add(this.lblOrderID);
            this.Controls.Add(this.lblEditServ);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnReset);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "EditServiceRequest";
            this.RightToLeftLayout = true;
            this.Text = "Edit Service Request";
            this.Load += new System.EventHandler(this.EditServiceRequest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnReset;
        private Button btnSave;
        private Button btnClose;
        private Label lblEditServ;
        private Label lblOrderID;
        private ComboBox comboOrderID;
        private Label lblChange;
        private RadioButton radioCompleted;
        private Label lblCollectDate;
        private DateTimePicker CollectionDatePicker;
        private Label lblServDescription;
        private RichTextBox richServDescription;
        private RadioButton radioChangesRequired;
    }
}