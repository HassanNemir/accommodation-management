﻿
namespace accommodation_management
{
    partial class wardenFeedback
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
            this.studentIDList = new System.Windows.Forms.ComboBox();
            this.studentName = new System.Windows.Forms.Label();
            this.roomNumber = new System.Windows.Forms.Label();
            this.subject = new System.Windows.Forms.Label();
            this.feedbacktxt = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.fbComment = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // studentIDList
            // 
            this.studentIDList.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentIDList.FormattingEnabled = true;
            this.studentIDList.Location = new System.Drawing.Point(56, 33);
            this.studentIDList.Name = "studentIDList";
            this.studentIDList.Size = new System.Drawing.Size(607, 33);
            this.studentIDList.TabIndex = 2;
            this.studentIDList.Text = "List of Student ID";
            this.studentIDList.SelectedIndexChanged += new System.EventHandler(this.studentIDList_SelectedIndexChanged);
            // 
            // studentName
            // 
            this.studentName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.studentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentName.Location = new System.Drawing.Point(21, 79);
            this.studentName.Name = "studentName";
            this.studentName.Size = new System.Drawing.Size(281, 23);
            this.studentName.TabIndex = 3;
            this.studentName.Text = "Student Name";
            // 
            // roomNumber
            // 
            this.roomNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.roomNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomNumber.Location = new System.Drawing.Point(320, 79);
            this.roomNumber.Name = "roomNumber";
            this.roomNumber.Size = new System.Drawing.Size(366, 23);
            this.roomNumber.TabIndex = 4;
            this.roomNumber.Text = "Room Number";
            // 
            // subject
            // 
            this.subject.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.subject.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subject.Location = new System.Drawing.Point(21, 124);
            this.subject.Name = "subject";
            this.subject.Size = new System.Drawing.Size(281, 23);
            this.subject.TabIndex = 5;
            this.subject.Text = "Subject";
            // 
            // feedbacktxt
            // 
            this.feedbacktxt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.feedbacktxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feedbacktxt.Location = new System.Drawing.Point(21, 164);
            this.feedbacktxt.Name = "feedbacktxt";
            this.feedbacktxt.Size = new System.Drawing.Size(281, 126);
            this.feedbacktxt.TabIndex = 6;
            this.feedbacktxt.Text = "Feedback";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(475, 354);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 38);
            this.button1.TabIndex = 7;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(583, 354);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 38);
            this.button2.TabIndex = 8;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // fbComment
            // 
            this.fbComment.Location = new System.Drawing.Point(337, 170);
            this.fbComment.Name = "fbComment";
            this.fbComment.Size = new System.Drawing.Size(255, 122);
            this.fbComment.TabIndex = 9;
            this.fbComment.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(335, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Comment";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // wardenFeedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 426);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.fbComment);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.feedbacktxt);
            this.Controls.Add(this.subject);
            this.Controls.Add(this.roomNumber);
            this.Controls.Add(this.studentName);
            this.Controls.Add(this.studentIDList);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "wardenFeedback";
            this.Text = "Warden | Review Feedback";
            this.Load += new System.EventHandler(this.wardenFeedback_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox studentIDList;
        private System.Windows.Forms.Label studentName;
        private System.Windows.Forms.Label roomNumber;
        private System.Windows.Forms.Label subject;
        private System.Windows.Forms.Label feedbacktxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox fbComment;
        private System.Windows.Forms.Label label4;
    }
}