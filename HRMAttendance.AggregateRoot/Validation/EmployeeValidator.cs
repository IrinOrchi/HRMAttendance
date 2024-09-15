using FluentValidation;
using HRMAttendance.DTO.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMAttendance.AggregateRoot.Validation
{
    public class EmployeeValidator:AbstractValidator<EmployeeDto>
    {
        public EmployeeValidator()
        {
            RuleFor(o => o.DateOfBirth<o.DateOfJoining)
                .NotEmpty().WithMessage("Date Of Birth Should Be Less Than Date Of Joining" );

        }
    }
}
