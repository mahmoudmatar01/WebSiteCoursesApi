using Coursera.DBContext;
using Coursera.Dto;
using Coursera.Models;

namespace Coursera.Repository.StudentRepo
{
    public class StdHelper : IStdHelper
    {

        //private readonly instance from DataContext Class
        private readonly DataContext _context;

        //public Constructor
        public StdHelper(DataContext context)
        {
            _context = context;
        }


        //Methods implementation
        public StudentsET CreateStudent(StudentsET student)
        {
            try
            {
                StudentsET newStudent = new StudentsET();
                newStudent.StudentPhone = student.StudentPhone;
                newStudent.StudentLastname = student.StudentLastname;
                newStudent.StudentEmail = student.StudentEmail;
                newStudent.StudentAge = student.StudentAge;
                newStudent.StudentFirstname = student.StudentFirstname;
                newStudent.Password = student.Password;
                newStudent.Gender = student.Gender;

                _context.Add(newStudent);
                _context.SaveChanges();


                return newStudent;


            }
            catch (Exception ex)
            {
                return null!;
            }
        }

        public void DeleteStrudent(int id)
        {
            StudentsET student = _context.StudentsET.
                Where(p => p.Studentid == id).FirstOrDefault();

            _context.StudentsET.Remove(student!);
            _context.SaveChanges();
        }

        public ICollection<StudentsET> GetAll()
        {
            try
            {
                List<StudentsET> ListStudent = (from obj in _context.StudentsET
                                                select obj).ToList();

                return ListStudent;
            }
            catch (Exception ex)
            {
                return null!;
            }
        }

        //Get by id Method
        public StudentsET GetID(int ID)
        {
            StudentsET student = (from obj in _context.StudentsET
                                  where obj.Studentid == ID
                                  select obj).FirstOrDefault();

            return student!;
        }


        //Get by firstName Mthod
        public StudentsET GetNamed(string Name)
        {
            StudentsET student = (from obj in _context.StudentsET
                                  where obj.StudentFirstname.ToLower().Trim() == Name.ToLower().Trim()
                                  select obj).FirstOrDefault();

            return student!;
        }

        //Check if Student Exist or Not
        public bool isExist(int id)
        {
            return _context.StudentsET.Any(p => p.Studentid == id);
        }

        public StudentsET UpdateStudent(int id, StudentDto newstudent)
        {
            StudentsET student = (from obj in _context.StudentsET
                                  where obj.Studentid == id
                                  select obj).FirstOrDefault();

            student.StudentPhone = newstudent.StudentPhone;
            student.StudentLastname = newstudent.StudentLastname;
            student.StudentEmail = newstudent.StudentEmail;
            student.StudentAge = newstudent.StudentAge;
            student.StudentFirstname = newstudent.StudentFirstname;
            student.Gender = newstudent.Gender;
            _context.SaveChanges();

            return student;


        }
    }
}
