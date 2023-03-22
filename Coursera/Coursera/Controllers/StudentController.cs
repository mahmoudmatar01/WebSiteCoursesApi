using Coursera.Dto;
using Coursera.Models;
using Coursera.Repository.StudentRepo;
using Microsoft.AspNetCore.Mvc;

namespace Coursera.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {

        //private reasonly instance from IHelper interface
        private readonly IStdHelper ?_stdHelper;

        //public constructor
        public StudentController(IStdHelper stdHelper)
        {
            _stdHelper = stdHelper;
        }


        //implementation EndPoint

        [HttpGet]
        public IActionResult Get()
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok(_stdHelper!.GetAll());
        }


        [HttpGet("{id}")]
        public IActionResult Getid(int id) {
            
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if (!_stdHelper!.isExist(id))
            {
                return NotFound();
            }

            return Ok(_stdHelper.GetID(id));
        }

        [HttpGet("{Name}")]
        public IActionResult Get(string Name) {
        
            if(!ModelState.IsValid) {
                return BadRequest(ModelState);
            }
            if (Name != null)
            {
                StudentsET student = _stdHelper!.GetNamed(Name);
                return Ok(student);
            }
            return NotFound();
        }


        [HttpDelete("{id}")]
        public  IActionResult Delete(int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if (!_stdHelper.isExist(id))
            {
                return NotFound();
            }
            _stdHelper.DeleteStrudent(id);
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult update(int id ,StudentDto student) {


            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if (!_stdHelper.isExist(id))
            {
                return NotFound();
            }
            StudentsET newstudent= _stdHelper.UpdateStudent(id, student);
            return Ok(newstudent);
        }


        [HttpPost]
        public IActionResult Post(StudentsET student)
        {
            if (!_stdHelper!.isExist(student.Studentid))
            {
                StudentsET newStd= _stdHelper.CreateStudent(student);
                return Ok(newStd);
            }
            return BadRequest();
            
        }

    }
}
