namespace StudentAttendanceApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtStudentName = new TextBox();
            btnAdd = new Button();
            lstAttendance = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(94, 17);
            label1.TabIndex = 0;
            label1.Text = "Student Name:";
            // 
            // txtStudentName
            // 
            txtStudentName.Location = new Point(127, 12);
            txtStudentName.Name = "txtStudentName";
            txtStudentName.Size = new Size(190, 23);
            txtStudentName.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 55);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(305, 41);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // lstAttendance
            // 
            lstAttendance.FormattingEnabled = true;
            lstAttendance.Items.AddRange(new object[] { "Present", "Late", "Absent", "Sick Leave" });
            lstAttendance.Location = new Point(12, 113);
            lstAttendance.Name = "lstAttendance";
            lstAttendance.Size = new Size(305, 310);
            lstAttendance.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(330, 435);
            Controls.Add(lstAttendance);
            Controls.Add(btnAdd);
            Controls.Add(txtStudentName);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Student Attendance Application";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtStudentName;
        private Button btnAdd;
        private ListBox lstAttendance;
    }
}
