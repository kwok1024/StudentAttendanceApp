namespace StudentAttendanceApp
{
    public partial class Form1 : Form
    {
        public string GetSystemStatus()
        {
            return "Status: Active and Running";
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string studentName = txtStudentName.Text.Trim();
            string status = cbbStatus.Text;

            if (string.IsNullOrWhiteSpace(studentName))
            {
                MessageBox.Show("Please enter a student name.");
                txtStudentName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(status))
            {
                MessageBox.Show("Please select an attendance status.");
                cbbStatus.Focus();
                return;
            }

            AttendanceRecord record = new AttendanceRecord
            {
                StudentName = studentName,
                Status = status,
                RecordedAt = DateTime.Now
            };

            lstAttendance.Items.Add(record);
            txtStudentName.Clear();
            cbbStatus.SelectedIndex = -1;
            txtStudentName.Focus();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (lstAttendance.Items.Count == 0)
            {
                MessageBox.Show("There are no attendance records to clear.");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to clear all attendance records?",
                "Confirm Clear",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
                lstAttendance.Items.Clear();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (lstAttendance.Items.Count == 0)
            {
                MessageBox.Show("There are no attendance records to save.");
                return;
            }

            using SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Text files (*.txt)|*.txt";
            dialog.FileName = "AttendanceRecords.txt";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                using StreamWriter writer = new StreamWriter(dialog.FileName);
                foreach (object item in lstAttendance.Items)
                    writer.WriteLine(item.ToString());

                MessageBox.Show("Attendance records were saved successfully.");
            }

        }
    }
}
