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
            cbbStatus = new ComboBox();
            btnClear = new Button();
            btnSave = new Button();
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
            btnAdd.Location = new Point(12, 85);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(305, 41);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // lstAttendance
            // 
            lstAttendance.FormattingEnabled = true;
            lstAttendance.Location = new Point(12, 179);
            lstAttendance.Name = "lstAttendance";
            lstAttendance.Size = new Size(305, 310);
            lstAttendance.TabIndex = 3;
            // 
            // cbbStatus
            // 
            cbbStatus.FormattingEnabled = true;
            cbbStatus.Items.AddRange(new object[] { "Present", "Late", "Absent", "Sick Leave" });
            cbbStatus.Location = new Point(14, 50);
            cbbStatus.Name = "cbbStatus";
            cbbStatus.Size = new Size(303, 25);
            cbbStatus.TabIndex = 4;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(12, 132);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(305, 41);
            btnClear.TabIndex = 5;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(12, 495);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(305, 41);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(330, 544);
            Controls.Add(btnSave);
            Controls.Add(btnClear);
            Controls.Add(cbbStatus);
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
        private ComboBox cbbStatus;
        private Button btnClear;
        private Button btnSave;
    }
}
