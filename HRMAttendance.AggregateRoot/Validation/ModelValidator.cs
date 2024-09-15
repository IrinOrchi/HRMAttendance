using HRMAttendance.DTO.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMAttendance.AggregateRoot.Validation
{
    public static class ModelValidator
    {
        public static bool EmployeeValidator(EmployeeDto employeeDto)
        {
            EmployeeValidator Employeevalidator = new EmployeeValidator();
            var result = Employeevalidator.Validate(employeeDto);
            return result.IsValid;
        }

        public static bool LeaveRequestValidator(LeaveRequestDto leaveRequestDto)
        {
            LeaveRequestValidator LeaveRequestValidator = new LeaveRequestValidator();
            var result=LeaveRequestValidator.Validate(leaveRequestDto);
            return result.IsValid;
        }

        public static bool ManageAttendanceValidator(ManageAttendanceDto manageAttendanceDto)
        {
            ManageAttendanceValidator ManageAttendanceValidator = new ManageAttendanceValidator();
            var result = ManageAttendanceValidator.Validate(manageAttendanceDto);
            return result.IsValid;
        }

        //public static bool HolidayValidator(HolidayDto holidayDto)
        //{
        //    HolidayValidator HolidayValidator = new HolidayValidator();
        //    var result= HolidayValidator.Validate(holidayDto);
        //    return result.IsValid;
        //}
    }
}
