﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMAttendance.DTO.DTOs
{
    public class HolidayDto
    {
        public int ID { get; set; }
        public DateTime HolidayDate { get; set; }
        public string Description { get; set; }
    }
}
