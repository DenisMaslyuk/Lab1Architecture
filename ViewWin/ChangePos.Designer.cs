﻿namespace ViewWin
{
    partial class ChangePos
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
            this.NameBox = new System.Windows.Forms.TextBox();
            this.SalaryBox = new System.Windows.Forms.TextBox();
            this.AgeBox = new System.Windows.Forms.TextBox();
            this.PositionBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ChangeBtn = new System.Windows.Forms.Button();
            this.CencelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(178, 72);
            this.NameBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(76, 20);
            this.NameBox.TabIndex = 0;
            // 
            // SalaryBox
            // 
            this.SalaryBox.Location = new System.Drawing.Point(178, 155);
            this.SalaryBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SalaryBox.Name = "SalaryBox";
            this.SalaryBox.Size = new System.Drawing.Size(76, 20);
            this.SalaryBox.TabIndex = 1;
            // 
            // AgeBox
            // 
            this.AgeBox.Location = new System.Drawing.Point(178, 111);
            this.AgeBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AgeBox.Name = "AgeBox";
            this.AgeBox.Size = new System.Drawing.Size(76, 20);
            this.AgeBox.TabIndex = 2;
            // 
            // PositionBox
            // 
            this.PositionBox.Location = new System.Drawing.Point(178, 197);
            this.PositionBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PositionBox.Name = "PositionBox";
            this.PositionBox.Size = new System.Drawing.Size(76, 20);
            this.PositionBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 72);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 111);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Возраст";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 159);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Зарплата";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 197);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Должность";
            // 
            // ChangeBtn
            // 
            this.ChangeBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ChangeBtn.Location = new System.Drawing.Point(61, 248);
            this.ChangeBtn.Name = "ChangeBtn";
            this.ChangeBtn.Size = new System.Drawing.Size(75, 23);
            this.ChangeBtn.TabIndex = 8;
            this.ChangeBtn.Text = "Изменить";
            this.ChangeBtn.UseVisualStyleBackColor = true;
            // 
            // CencelBtn
            // 
            this.CencelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CencelBtn.Location = new System.Drawing.Point(179, 248);
            this.CencelBtn.Name = "CencelBtn";
            this.CencelBtn.Size = new System.Drawing.Size(75, 23);
            this.CencelBtn.TabIndex = 9;
            this.CencelBtn.Text = "Отменить";
            this.CencelBtn.UseMnemonic = false;
            this.CencelBtn.UseVisualStyleBackColor = true;
            // 
            // ChangePos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 320);
            this.Controls.Add(this.CencelBtn);
            this.Controls.Add(this.ChangeBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PositionBox);
            this.Controls.Add(this.AgeBox);
            this.Controls.Add(this.SalaryBox);
            this.Controls.Add(this.NameBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ChangePos";
            this.Text = "ChangePos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox NameBox;
        public System.Windows.Forms.TextBox SalaryBox;
        public System.Windows.Forms.TextBox AgeBox;
        public System.Windows.Forms.TextBox PositionBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Button ChangeBtn;
        public System.Windows.Forms.Button CencelBtn;
    }
}