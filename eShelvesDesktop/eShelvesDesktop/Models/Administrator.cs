﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShelvesDesktop.Models
{
    public class Administrator
    {
        public int Id { get; set; }
        public string username { get; set; }
        public string PasswordHash { get; set; }
        public string PasswordSalt { get; set; }
        public DateTime created_at { get; set; }
    }
}
