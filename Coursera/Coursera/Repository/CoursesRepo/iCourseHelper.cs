using Coursera.Dto;
using Coursera.Models;

namespace Coursera.Repository.CoursesRepo
{
    public interface iCourseHelper
    {


        public ICollection<CourseET> GetAll();

        public CourseET GetID(int ID);

        public bool isExist(int id);

        public void DeleteStrudent(int id);

        public CourseET UpdateStudent(int id, CoursesDto Course);

        public CourseET CreateStudent(CourseET Course);


    }
}
