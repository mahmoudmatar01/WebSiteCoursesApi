namespace Coursera.Dto
{
    public class TeacherDto
    {


        public string? TeacherEmail { get; set; }
        public string? TeacherPassword { get; set; }
        public string? TeacherGender { get; set; }
        public IFormFile? TeacherPhoto { get; set; }
        public string? Teacherphone { get; set; }
        public int TeacherAge { get; set; }

    }
}
