using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoshCodeFirst.Models
{
    public class Author
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int AuthorId { get; set; }
        [Required]
        [MaxLength(50)]

        public string? FirstName { get; set; }
        [Required]
        [MaxLength(50)]

        public string? LastName { get; set; }
        public ICollection<Course> Courses { get; set; }

    }
}
