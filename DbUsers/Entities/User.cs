using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DbUsers.Entities
{
    [Table("tblUsers")]
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required, StringLength(100)]
        public string UserName { get; set; }

        [Required, StringLength(100)]
        public string NormalizedUserName { get; set; }

        [Required, StringLength(150)]
        public string Email { get; set; }

        [Required, StringLength(250)]
        public string PasswordHash { get; set; }
        public virtual ICollection<UserRole> UserRoles { get; set; }
        
    }
}
