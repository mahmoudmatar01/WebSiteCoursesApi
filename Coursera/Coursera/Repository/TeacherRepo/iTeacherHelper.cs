using Coursera.Dto;
using Coursera.Models;

namespace Coursera.Repository.TeacherRepo
{
    public interface iTeacherHelper
    {


        public ICollection<TeacherET> GetAll();

        public TeacherET GetID(int ID);

        public bool isExist(int id);

        public void DeleteStrudent(int id);

        public TeacherET UpdateStudent(int id, TeacherDto Teacher);

        public TeacherET CreateStudent(TeacherET Teacher);




    }
}
