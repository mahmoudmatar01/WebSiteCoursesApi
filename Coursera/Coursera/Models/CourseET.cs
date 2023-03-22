using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Coursera.Models
{
    public class CourseET
    {

        [Key]  
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CourseID { get; set; }

        public string?CourseName { get; set; }
        public int CourseCapacity { get; set; }
        public string? CourseDescription { get;set; }

        public string? CourseTeacher { get; set; }

    }
}
