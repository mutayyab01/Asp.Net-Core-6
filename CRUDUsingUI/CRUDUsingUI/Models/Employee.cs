using System;
using System.Collections.Generic;

namespace CRUDUsingUI.Models
{
    public partial class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Profession { get; set; } = null!;
        public int Age { get; set; }
    }
}
