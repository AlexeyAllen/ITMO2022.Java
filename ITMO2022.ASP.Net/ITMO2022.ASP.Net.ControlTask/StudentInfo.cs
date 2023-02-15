using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Emit;

namespace ITMO2022.ASP.Net.ControlTask
{
    public class StudentInfo
    {
        [Key]
        public int StudentInfoIdId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public GradeInfo GradeInfo { get; set; }

        public StudentInfo() { }
        public StudentInfo(string firstName, string lastName, string email, string phoneNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber;
        }

       
    }
}