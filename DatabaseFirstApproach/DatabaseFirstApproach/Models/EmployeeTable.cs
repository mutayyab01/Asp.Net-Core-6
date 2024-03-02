using System;
using System.Collections.Generic;

namespace DatabaseFirstApproach.Models
{
    public partial class EmployeeTable
    {
        public int Id { get; set; }
        public string EmpName { get; set; } = null!;
        public string Designation { get; set; } = null!;
        public int Salary { get; set; }
    }
}
