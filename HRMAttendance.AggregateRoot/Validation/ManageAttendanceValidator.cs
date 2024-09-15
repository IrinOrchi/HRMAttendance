using FluentValidation;
using HRMAttendance.DTO.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMAttendance.AggregateRoot.Validation
{
    public class ManageAttendanceValidator:AbstractValidator<ManageAttendanceDto>
    {
        public ManageAttendanceValidator()
        {
            RuleFor(o => o.Status == "Present" && o.InTime > o.OutTime)
                .NotEmpty().WithMessage("InTime Can't be less than Out Time");

        }
    }
}
