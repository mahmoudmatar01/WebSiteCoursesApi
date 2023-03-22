using Coursera.Dto;
using Coursera.Models;

namespace Coursera.Repository.StudentRepo
{
    public interface IStdHelper
    {


        public ICollection<StudentsET> GetAll();

        public StudentsET GetID(int ID);

        public StudentsET GetNamed(string Name);

        public bool isExist(int id);

        public void DeleteStrudent(int id);

        public StudentsET UpdateStudent(int id, StudentDto student);

        public StudentsET CreateStudent(StudentsET student);



    }
}
