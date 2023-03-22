using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Coursera.Models
{
    public class TeacherET
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Teacherid { get; set; }
        public string ?TeacherEmail { get; set; }
        public string? TeacherPassword { get; set; }
        public string? TeacherGender { get; set; }
        //public IFormFile?TeacherPhoto { get; set; }
        public string? Teacherphone { get; set; }
        public int TeacherAge { get; set; }


    }
}
