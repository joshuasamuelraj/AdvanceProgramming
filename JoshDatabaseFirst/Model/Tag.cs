using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace JoshDatabaseFirst.Model
{
    public partial class Tag
    {
        public Tag()
        {
            Courses = new HashSet<Course>();
        }

        [Key]
        [Column("TagID")]
        public int TagId { get; set; }
        [StringLength(20)]
        public string Name { get; set; } = null!;

        [ForeignKey("TagId")]
        [InverseProperty("Tags")]
        public virtual ICollection<Course> Courses { get; set; }
    }
}
