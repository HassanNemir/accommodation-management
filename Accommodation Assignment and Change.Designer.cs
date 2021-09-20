﻿
namespace accommodation_management
{
    partial class Accommodation_Assignment_and_Change
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Accommodation_Assignment_and_Change));
            this.studentIDList = new System.Windows.Forms.ComboBox();
            this.studentName = new System.Windows.Forms.Label();
            this.prevRoomNumber = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.roomNumber = new System.Windows.Forms.TextBox();
            this.requestedBlock = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // studentIDList
            // 
            this.studentIDList.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentIDList.FormattingEnabled = true;
            this.studentIDList.Location = new System.Drawing.Point(12, 163);
            this.studentIDList.Name = "studentIDList";
            this.studentIDList.Size = new System.Drawing.Size(425, 29);
            this.studentIDList.TabIndex = 0;
            this.studentIDList.Text = "LIST OF STUDENT ID";
            this.studentIDList.SelectedIndexChanged += new System.EventHandler(this.studentIDList_SelectedIndexChanged);
            // 
            // studentName
            // 
            this.studentName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.studentName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentName.Location = new System.Drawing.Point(12, 202);
            this.studentName.Name = "studentName";
            this.studentName.Size = new System.Drawing.Size(425, 23);
            this.studentName.TabIndex = 1;
            this.studentName.Text = "STUDENT NAME";
            // 
            // prevRoomNumber
            // 
            this.prevRoomNumber.AutoSize = true;
            this.prevRoomNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.prevRoomNumber.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prevRoomNumber.Location = new System.Drawing.Point(221, 244);
            this.prevRoomNumber.Name = "prevRoomNumber";
            this.prevRoomNumber.Size = new System.Drawing.Size(216, 23);
            this.prevRoomNumber.TabIndex = 2;
            this.prevRoomNumber.Text = "PREVIOUS ROOM NUMBER";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(260, 410);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 35);
            this.button1.TabIndex = 4;
            this.button1.Text = "SUBMIT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(12, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "BACK";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // roomNumber
            // 
            this.roomNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.roomNumber.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomNumber.Location = new System.Drawing.Point(221, 289);
            this.roomNumber.Name = "roomNumber";
            this.roomNumber.Size = new System.Drawing.Size(216, 27);
            this.roomNumber.TabIndex = 3;
            this.roomNumber.Text = "NEW ROOM NUMBER";
            // 
            // requestedBlock
            // 
            this.requestedBlock.AutoSize = true;
            this.requestedBlock.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.requestedBlock.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requestedBlock.Location = new System.Drawing.Point(12, 241);
            this.requestedBlock.Name = "requestedBlock";
            this.requestedBlock.Size = new System.Drawing.Size(158, 23);
            this.requestedBlock.TabIndex = 6;
            this.requestedBlock.Text = "REQUESTED BLOCK";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-187, 113);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(672, 517);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(450, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 530);
            this.panel1.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(235, 506);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Y U R I K A";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(212, 490);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Developed By";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(5, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 23);
            this.label2.TabIndex = 24;
            this.label2.Text = "ACCOMMODATION";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(5, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 23);
            this.label1.TabIndex = 25;
            this.label1.Text = "ASSIGNMENT  AND CHANGE";
            // 
            // Accommodation_Assignment_and_Change
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 530);
            this.ControlBox = false;
            this.Controls.Add(this.requestedBlock);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.roomNumber);
            this.Controls.Add(this.prevRoomNumber);
            this.Controls.Add(this.studentName);
            this.Controls.Add(this.studentIDList);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Accommodation_Assignment_and_Change";
            this.Text = "Warden | Change and assign accommodation";
            this.Load += new System.EventHandler(this.Accommodation_Assignment_and_Change_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox studentIDList;
        private System.Windows.Forms.Label studentName;
        private System.Windows.Forms.Label prevRoomNumber;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox roomNumber;
        private System.Windows.Forms.Label requestedBlock;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}