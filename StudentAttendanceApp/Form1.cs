namespace StudentAttendanceApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string studentName = txtStudentName.Text.Trim();
            string status = cmbStatus.Text;

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
            cmbStatus.SelectedIndex = -1;
            txtStudentName.Focus();

        }
    }
}
