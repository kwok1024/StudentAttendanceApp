using System;
using System.Collections.Generic;
using System.Text;

namespace StudentAttendanceApp
{
    public class AttendanceRecord
    {
        public string StudentName { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public DateTime RecordedAt { get; set; }

        public override string ToString()
        {
            return $"{RecordedAt:yyyy-MM-dd HH:mm} - {StudentName} - {Status}";
        }
    }

}
