using FluentValidation;
using HRMAttendance.DTO.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMAttendance.AggregateRoot.Validation
{
    public class LeaveRequestValidator:AbstractValidator<LeaveRequestDto>
    {
        public LeaveRequestValidator() 
        {
            RuleFor(o => o.Reason == "Medical Leave" && o.Reason== "Personal Leave")
                .NotEmpty().WithMessage("Invalid Reason");
                
        }
    }
}
