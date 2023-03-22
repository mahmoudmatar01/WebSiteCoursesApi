using Coursera.DBContext;
using Coursera.Dto;
using Coursera.Models;

namespace Coursera.Repository.TeacherRepo
{
    public class TeacherHelper:iTeacherHelper
    {


        //private readonly instance from DataContext Class
        private readonly DataContext _context;

        //public Constructor
        public TeacherHelper(DataContext context)
        {
            _context = context;
        }


        //Methods Implementation
        public TeacherET CreateStudent(TeacherET Teacher)
        {
            try
            {
                TeacherET newTeacher= new TeacherET();
                newTeacher.TeacherEmail = Teacher.TeacherEmail;
                newTeacher.TeacherGender = Teacher.TeacherGender;
                newTeacher.Teacherphone=Teacher.Teacherphone; 
                newTeacher.TeacherPassword = Teacher.TeacherPassword;
               

                _context.TeacherET.Add(newTeacher);
                _context.SaveChanges();


                return newTeacher;


            }
            catch (Exception ex)
            {
                return null!;
            }
        }

        public void DeleteStrudent(int id)
        {
            TeacherET Teacher=(from obj in _context.TeacherET
                               where obj.Teacherid==id
                               select obj).FirstOrDefault();
            if (Teacher!=null)
            {
                _context.Remove(Teacher);
                _context.SaveChanges();
            }
        }

        public ICollection<TeacherET> GetAll()
        {
            try
            {
                List<TeacherET> ListTeacher = (from obj in _context.TeacherET
                                               select obj).ToList();

                return ListTeacher;

            }
            catch(Exception ex)
            {
                return null!;
            }
            
        }

        public TeacherET GetID(int ID)
        {
            TeacherET Teacher = (from obj in _context.TeacherET
                                 where obj.Teacherid == ID
                                 select obj).FirstOrDefault();
            return Teacher!;
        }

        public bool isExist(int id)
        {
            return _context.TeacherET.Any(p=>p.Teacherid.Equals(id));
        }

        public TeacherET UpdateStudent(int id, TeacherDto Teacher)
        {
            TeacherET newTeacher = (from obj in _context.TeacherET
                                 where obj.Teacherid == id
                                 select obj).FirstOrDefault();

            newTeacher.TeacherEmail = Teacher.TeacherEmail;
            newTeacher.TeacherGender = Teacher.TeacherGender;
            newTeacher.Teacherphone = Teacher.Teacherphone;
            newTeacher.TeacherPassword = Teacher.TeacherPassword;

            _context.SaveChanges();

            return newTeacher;
        }
    }
}
