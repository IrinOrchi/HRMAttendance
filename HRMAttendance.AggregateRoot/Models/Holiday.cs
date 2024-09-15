using HRMAttendance.AggregateRoot.Validation;
using HRMAttendance.DTO.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMAttendance.AggregateRoot.Models
{
    public class Holiday
    {
        public int ID { get; set; }
        public DateTime HolidayDate { get; set; }
        public string Description { get; set; }

        //public static bool IsHolidayValid(HolidayDto dto)
        //{
        //    return ModelValidator.HolidayValidator(dto);
        //}
    }
}
