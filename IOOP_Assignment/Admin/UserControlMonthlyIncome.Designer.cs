﻿namespace IOOP_Assignment
{
    partial class UserControlMonthlyIncome
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
            this.dtGVIncome = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtGVIncome)).BeginInit();
            this.SuspendLayout();
            // 
            // dtGVIncome
            // 
            this.dtGVIncome.AllowUserToAddRows = false;
            this.dtGVIncome.AllowUserToDeleteRows = false;
            this.dtGVIncome.AllowUserToResizeColumns = false;
            this.dtGVIncome.AllowUserToResizeRows = false;
            this.dtGVIncome.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGVIncome.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGVIncome.Location = new System.Drawing.Point(22, 62);
            this.dtGVIncome.Name = "dtGVIncome";
            this.dtGVIncome.ReadOnly = true;
            this.dtGVIncome.RowHeadersVisible = false;
            this.dtGVIncome.RowHeadersWidth = 51;
            this.dtGVIncome.RowTemplate.Height = 25;
            this.dtGVIncome.Size = new System.Drawing.Size(775, 269);
            this.dtGVIncome.TabIndex = 171;
            this.dtGVIncome.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGVIncome_CellContentClick);
            // 
            // UserControlMonthlyIncome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(229)))), ((int)(((byte)(237)))));
            this.Controls.Add(this.dtGVIncome);
            this.Name = "UserControlMonthlyIncome";
            this.Size = new System.Drawing.Size(836, 462);
            this.Load += new System.EventHandler(this.UserControlMonthlyIncome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGVIncome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dtGVIncome;
    }
}
