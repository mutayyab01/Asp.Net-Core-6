using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DatabaseFirstApproach.Models
{
    public partial class Student
    {
        public int Id { get; set; }
        [Display(Name ="Student Name")]
        public string StudentName { get; set; } = null!;
        [Display(Name = "Student Gender ")]

        public string StudentGender { get; set; } = null!;
        public int Age { get; set; }
        public int Standard { get; set; }
    }
}
