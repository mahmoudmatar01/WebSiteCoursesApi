using Coursera.DBContext;
using Coursera.Dto;
using Coursera.Models;

namespace Coursera.Repository.CoursesRepo
{
    public class CourseHelper:iCourseHelper
    {

        //private readonly instance from DataContext Class
        private readonly DataContext _context;

        //public Constructor
        public CourseHelper(DataContext context)
        {
            _context = context;
        }

        CourseET iCourseHelper.CreateStudent(CourseET Course)
        {
            try
            {
                CourseET newCourse=new CourseET();
                newCourse.CourseDescription = Course.CourseDescription;
                newCourse.CourseName = Course.CourseName;
                newCourse.CourseCapacity = Course.CourseCapacity;
                newCourse.CourseTeacher = Course.CourseTeacher;
                 _context.CourseET.Add(newCourse);
                _context.SaveChanges();
                return newCourse;

            }
            catch (Exception ex)
            {
                return null!;
            }
        }

        void iCourseHelper.DeleteStrudent(int id)
        {
            CourseET course=_context.CourseET.Where(p=>p.CourseID==id).FirstOrDefault();

            if (course != null)
            {
                _context.CourseET.Remove(course);
                _context.SaveChanges();
            }
        }

        ICollection<CourseET> iCourseHelper.GetAll()
        {
            try
            {
                List<CourseET> list = (from obj in _context.CourseET select obj).ToList();
                return list;

            }
            catch(Exception ex)
            {
                return null!;
            }
        }

        CourseET iCourseHelper.GetID(int ID)
        {
            CourseET course = _context.CourseET.Where(p => p.CourseID == ID).FirstOrDefault();

            return course!;

        }

        bool iCourseHelper.isExist(int id)
        {
            return _context.CourseET.Any(p=> p.CourseID == id);
        }

        CourseET iCourseHelper.UpdateStudent(int id, CoursesDto Course)
        {
            CourseET newCourse = _context.CourseET.Where(p => p.CourseID == id).FirstOrDefault();
            newCourse!.CourseDescription = Course.CourseDescription;
            newCourse.CourseName = Course.CourseName;
            newCourse.CourseCapacity = Course.CourseCapacity;
            newCourse.CourseTeacher = Course.CourseTeacher;
            _context.SaveChanges();

            return newCourse;

        }
    }
}
