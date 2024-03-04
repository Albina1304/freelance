﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace freelance.Models
{
    public class UserProject
    {
        public int Id { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public int ProjectId { get; set; }
        public Project Project { get; set; }
    }
}
