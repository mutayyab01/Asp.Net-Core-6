using System;
using System.Collections.Generic;

namespace AspCoreWebAPICRUD.Models
{
    public partial class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Qualification { get; set; } = null!;
        public int Salary { get; set; }
    }
}
