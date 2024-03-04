using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace JoshDatabaseFirst.Model
{
    public partial class Course
    {
        public Course()
        {
            Tags = new HashSet<Tag>();
        }

        [Key]
        [Column("CourseID")]
        public int CourseId { get; set; }
        [StringLength(50)]
        public string Title { get; set; } = null!;
        [StringLength(2000)]
        public string? Description { get; set; }
        public double? Price { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? PublishDate { get; set; }
        [Column("AuthorID")]
        public int AuthorId { get; set; }

        [ForeignKey("AuthorId")]
        [InverseProperty("Courses")]
        public virtual Author Author { get; set; } = null!;

        [ForeignKey("CourseId")]
        [InverseProperty("Courses")]
        public virtual ICollection<Tag> Tags { get; set; }
    }
}
