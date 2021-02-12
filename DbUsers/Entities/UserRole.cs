﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DbUsers.Entities
{
    [Table ("tblUserRoles")]
    public class UserRole
    {
        public int RoleId { get; set; }
        public int UserId { get; set; }
        public virtual Role Role { get; set;  }
        public virtual User User { get; set; }

    }
}
