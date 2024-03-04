using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoshCodeFirst.Models
{
    public class Course
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int CourseId { get; set; }
        [Required]
        [MaxLength(50)]
        public string Title { get; set; }
        [MaxLength(2000)]
        public string? Description { get; set; }
        public float Price { get; set; }
        public DateTime PublishDate { get; set; }
        [Required]

        public Author Author { get; set; }
        public ICollection<Tag> Tags { get; set; }
    }
}
