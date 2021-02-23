using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TreeView.Entities
{
    [Table ("tblCategories")]
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required, StringLength(255)]
        public string Name { get; set; }
        [StringLength(255)]
        public string UrlSlug { get; set; }
        [StringLength(255)]
        public string Image { get; set; }
        [ForeignKey("Parent")]
        public int? ParentId { get; set; }
        public virtual Category Parent { get; set; }
    }
}
