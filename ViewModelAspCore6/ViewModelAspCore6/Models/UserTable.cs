﻿using System;
using System.Collections.Generic;

namespace ViewModelAspCore6.Models
{
    public partial class UserTable
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Gender { get; set; } = null!;
        public int Age { get; set; }
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
    }
}