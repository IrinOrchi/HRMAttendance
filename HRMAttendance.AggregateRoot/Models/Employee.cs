using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRMAttendance.AggregateRoot.Validation;
using HRMAttendance.DTO;
using HRMAttendance.DTO.DTOs;

namespace HRMAttendance.AggregateRoot.Models
{
    public class Employee
    {
        [Key]
        public int ID { get; set; }
        public required string Name { get; set; }
        public required string Designation { get; set; }
        public required string Department { get; set; }
        public required string NID { get; set; }
        public string? FathersName { get; set; }
        public string? MothersName { get; set; }
        public DateTime DateOfJoining { get; set; }
        public string? Address { get; set; }
        public required string Phone { get; set; }
        public DateTime DateOfBirth { get; set; }
        public virtual ICollection<LeaveRequest> LeaveRequests { get; set; }

        public static bool IsEmployeeValid(EmployeeDto dto)
        {
            return ModelValidator.EmployeeValidator(dto);
        }

        // Mapping method to DTO
        public EmployeeDto  ToDto()
        {
            return new EmployeeDto
            {
                ID = this.ID,
                Name = this.Name,
                Department = this.Department,
                NID = this.NID,
                Phone = this.Phone,
                Designation = this.Designation
            };
        }
        public static EmployeeDto FromDto(EmployeeDto dto)
        {
            return new EmployeeDto
            {
                ID = dto.ID,
                Name = dto.Name,
                Department = dto.Department,
                NID = dto.NID,
                Phone = dto.Phone,
                Designation = dto.Designation
            };
        }
    }
}