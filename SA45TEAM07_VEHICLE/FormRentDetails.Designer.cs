namespace SA45TEAM07_VEHICLE
{
    partial class FormRentDetails
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.txbPhone = new System.Windows.Forms.TextBox();
            this.txbCusName = new System.Windows.Forms.TextBox();
            this.txbNRIC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePickerDue = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePickerRent = new System.Windows.Forms.DateTimePicker();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.statusStripRentRecordStatus = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelRentalStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelRentInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.statusStripRentRecordStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txbEmail);
            this.groupBox1.Controls.Add(this.txbPhone);
            this.groupBox1.Controls.Add(this.txbCusName);
            this.groupBox1.Controls.Add(this.txbNRIC);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(39, 29);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(504, 222);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Details";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(348, 38);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 16;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txbEmail
            // 
            this.txbEmail.Location = new System.Drawing.Point(197, 169);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.ReadOnly = true;
            this.txbEmail.Size = new System.Drawing.Size(226, 23);
            this.txbEmail.TabIndex = 15;
            // 
            // txbPhone
            // 
            this.txbPhone.Location = new System.Drawing.Point(197, 127);
            this.txbPhone.Name = "txbPhone";
            this.txbPhone.ReadOnly = true;
            this.txbPhone.Size = new System.Drawing.Size(226, 23);
            this.txbPhone.TabIndex = 14;
            // 
            // txbCusName
            // 
            this.txbCusName.Location = new System.Drawing.Point(197, 83);
            this.txbCusName.Name = "txbCusName";
            this.txbCusName.ReadOnly = true;
            this.txbCusName.Size = new System.Drawing.Size(226, 23);
            this.txbCusName.TabIndex = 13;
            // 
            // txbNRIC
            // 
            this.txbNRIC.Location = new System.Drawing.Point(197, 37);
            this.txbNRIC.Name = "txbNRIC";
            this.txbNRIC.Size = new System.Drawing.Size(141, 23);
            this.txbNRIC.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Phone Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Customer Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "NRIC/FIN:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.dateTimePickerDue);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.dateTimePickerRent);
            this.groupBox2.Location = new System.Drawing.Point(39, 258);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(504, 145);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rental Info";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 15);
            this.label6.TabIndex = 19;
            this.label6.Text = "Return Date:";
            // 
            // dateTimePickerDue
            // 
            this.dateTimePickerDue.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDue.Location = new System.Drawing.Point(197, 85);
            this.dateTimePickerDue.MinDate = new System.DateTime(2017, 10, 6, 0, 0, 0, 0);
            this.dateTimePickerDue.Name = "dateTimePickerDue";
            this.dateTimePickerDue.Size = new System.Drawing.Size(226, 23);
            this.dateTimePickerDue.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 15);
            this.label5.TabIndex = 17;
            this.label5.Text = "Rent Date:";
            // 
            // dateTimePickerRent
            // 
            this.dateTimePickerRent.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerRent.Location = new System.Drawing.Point(197, 44);
            this.dateTimePickerRent.MinDate = new System.DateTime(2017, 10, 6, 0, 0, 0, 0);
            this.dateTimePickerRent.Name = "dateTimePickerRent";
            this.dateTimePickerRent.Size = new System.Drawing.Size(226, 23);
            this.dateTimePickerRent.TabIndex = 0;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(144, 430);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(106, 31);
            this.btnConfirm.TabIndex = 1;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(326, 430);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(106, 31);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // statusStripRentRecordStatus
            // 
            this.statusStripRentRecordStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelRentalStatus,
            this.toolStripStatusLabelRentInfo});
            this.statusStripRentRecordStatus.Location = new System.Drawing.Point(0, 488);
            this.statusStripRentRecordStatus.Name = "statusStripRentRecordStatus";
            this.statusStripRentRecordStatus.Size = new System.Drawing.Size(586, 22);
            this.statusStripRentRecordStatus.TabIndex = 11;
            this.statusStripRentRecordStatus.Text = "statusStrip1";
            // 
            // toolStripStatusLabelRentalStatus
            // 
            this.toolStripStatusLabelRentalStatus.Name = "toolStripStatusLabelRentalStatus";
            this.toolStripStatusLabelRentalStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabelRentInfo
            // 
            this.toolStripStatusLabelRentInfo.Name = "toolStripStatusLabelRentInfo";
            this.toolStripStatusLabelRentInfo.Size = new System.Drawing.Size(0, 17);
            // 
            // FormRentDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 510);
            this.Controls.Add(this.statusStripRentRecordStatus);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormRentDetails";
            this.Text = "Rent Details";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.statusStripRentRecordStatus.ResumeLayout(false);
            this.statusStripRentRecordStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.TextBox txbPhone;
        private System.Windows.Forms.TextBox txbCusName;
        private System.Windows.Forms.TextBox txbNRIC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePickerDue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePickerRent;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.StatusStrip statusStripRentRecordStatus;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelRentalStatus;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelRentInfo;
    }
}