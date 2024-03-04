using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoshCodeFirst.Models
{
    public class Tag
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int TagID { get; set; }
        [Required]
        [MaxLength(20)]

        public string? Name { get; set; }
        public ICollection<Course> Courses { get; set; }
    }
}
