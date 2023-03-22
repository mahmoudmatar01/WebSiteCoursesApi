using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Coursera.Models
{
    public class StudentsET
    {


        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Studentid { get; set; }
        public String? StudentFirstname { get; set; }
        public String? StudentLastname { get; set; }
        public String? StudentEmail { get; set; }
        public String? Password { get; set; }
        public String? Gender { get; set; }
       // public IFormFile ?StudentPhoto { get; set; }
        public int StudentAge { get; set; }
        public String ?StudentPhone { get; set; }

    }
}
