using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace JoshDatabaseFirst.Model
{
    public partial class Author
    {
        public Author()
        {
            Courses = new HashSet<Course>();
        }

        [Key]
        [Column("AuthorID")]
        public int AuthorId { get; set; }
        [StringLength(50)]
        public string FirstName { get; set; } = null!;
        [StringLength(50)]
        public string LastName { get; set; } = null!;
        [Column(TypeName = "date")]
        public DateTime? DateOfBirth { get; set; }

        [InverseProperty("Author")]
        public virtual ICollection<Course> Courses { get; set; }
    }
}
