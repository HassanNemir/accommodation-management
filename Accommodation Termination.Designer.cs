
namespace accommodation_management
{
    partial class Accommodation_Termination
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // studentIDList
            // 
            this.studentIDList.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentIDList.FormattingEnabled = true;
            this.studentIDList.Location = new System.Drawing.Point(68, 49);
            this.studentIDList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.studentIDList.Name = "studentIDList";
            this.studentIDList.Size = new System.Drawing.Size(1020, 45);
            this.studentIDList.TabIndex = 1;
            this.studentIDList.Text = "List of Student ID";
            this.studentIDList.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // studentName
            // 
            this.studentName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.studentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentName.Location = new System.Drawing.Point(68, 140);
            this.studentName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.studentName.Name = "studentName";
            this.studentName.Size = new System.Drawing.Size(1028, 35);
            this.studentName.TabIndex = 2;
            this.studentName.Text = "Student Name";
            // 
            // roomNumber
            // 
            this.roomNumber.AutoSize = true;
            this.roomNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.roomNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomNumber.Location = new System.Drawing.Point(68, 212);
            this.roomNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.roomNumber.Name = "roomNumber";
            this.roomNumber.Size = new System.Drawing.Size(207, 35);
            this.roomNumber.TabIndex = 6;
            this.roomNumber.Text = "Room Number";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(846, 212);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(249, 58);
            this.button1.TabIndex = 7;
            this.button1.Text = "Relinquish Room";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(934, 598);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 58);
            this.button2.TabIndex = 8;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Accommodation_Termination
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.roomNumber);
            this.Controls.Add(this.studentName);
            this.Controls.Add(this.studentIDList);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Accommodation_Termination";
            this.Text = "Warden | Accommodation termination";
            this.Load += new System.EventHandler(this.Accommodation_Termination_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox studentIDList;
        private System.Windows.Forms.Label studentName;
        private System.Windows.Forms.Label roomNumber;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}