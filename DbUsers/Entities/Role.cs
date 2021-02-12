using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DbUsers.Entities
{
    [Table ("tblRoles")]
    public class Role
    {
        [Key]
        public int Id { get; set; }
        [Required, StringLength(100)]
        public string Name { get; set; }
        [Required, StringLength(100)]
        public string NormalizedName { get; set; }
        [Required, StringLength(250)]
        public string ConcurrencyStamp { get; set; }
        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}
