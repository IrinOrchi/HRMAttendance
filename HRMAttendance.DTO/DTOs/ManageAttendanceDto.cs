using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMAttendance.DTO.DTOs
{
    public class ManageAttendanceDto
    {

        public int ID { get; set; }
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public string Department { get; set; }
        public DateTime InTime { get; set; }
        public DateTime? OutTime { get; set; }
        public TimeSpan? TotalWorkingHours { get; set; }
        public string Status { get; set; }
        public DateTime AttendanceDate { get; set; }
    }
}

