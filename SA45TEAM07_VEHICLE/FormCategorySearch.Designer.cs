﻿namespace SA45TEAM07_VEHICLE
{
    partial class FormCategorySearch
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
            this.button1 = new System.Windows.Forms.Button();
            this.lbxCategory = new System.Windows.Forms.ListBox();
            this.btnRetreive = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxCategory = new System.Windows.Forms.GroupBox();
            this.btnRent = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbxCategory.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(471, 589);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 37);
            this.button1.TabIndex = 12;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbxCategory
            // 
            this.lbxCategory.FormattingEnabled = true;
            this.lbxCategory.ItemHeight = 18;
            this.lbxCategory.Location = new System.Drawing.Point(207, 31);
            this.lbxCategory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbxCategory.Name = "lbxCategory";
            this.lbxCategory.Size = new System.Drawing.Size(294, 76);
            this.lbxCategory.TabIndex = 13;
            // 
            // btnRetreive
            // 
            this.btnRetreive.Location = new System.Drawing.Point(566, 48);
            this.btnRetreive.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRetreive.Name = "btnRetreive";
            this.btnRetreive.Size = new System.Drawing.Size(133, 37);
            this.btnRetreive.TabIndex = 14;
            this.btnRetreive.Text = "Retreive";
            this.btnRetreive.UseVisualStyleBackColor = true;
            this.btnRetreive.Click += new System.EventHandler(this.btnRetreive_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(39, 175);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(730, 385);
            this.dataGridView1.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 19);
            this.label1.TabIndex = 17;
            this.label1.Text = "Select category:";
            // 
            // gbxCategory
            // 
            this.gbxCategory.Controls.Add(this.label1);
            this.gbxCategory.Controls.Add(this.btnRetreive);
            this.gbxCategory.Controls.Add(this.lbxCategory);
            this.gbxCategory.Location = new System.Drawing.Point(39, 14);
            this.gbxCategory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxCategory.Name = "gbxCategory";
            this.gbxCategory.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxCategory.Size = new System.Drawing.Size(731, 136);
            this.gbxCategory.TabIndex = 18;
            this.gbxCategory.TabStop = false;
            // 
            // btnRent
            // 
            this.btnRent.Location = new System.Drawing.Point(193, 589);
            this.btnRent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRent.Name = "btnRent";
            this.btnRent.Size = new System.Drawing.Size(133, 37);
            this.btnRent.TabIndex = 19;
            this.btnRent.Text = "Rent";
            this.btnRent.UseVisualStyleBackColor = true;
            this.btnRent.Click += new System.EventHandler(this.btnRent_Click);
            // 
            // FormCategorySearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 642);
            this.Controls.Add(this.btnRent);
            this.Controls.Add(this.gbxCategory);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "FormCategorySearch";
            this.Text = "Find Available Vehicles";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbxCategory.ResumeLayout(false);
            this.gbxCategory.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lbxCategory;
        private System.Windows.Forms.Button btnRetreive;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbxCategory;
        private System.Windows.Forms.Button btnRent;
    }
}