using Coursera.Dto;
using Coursera.Models;
using Coursera.Repository.TeacherRepo;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Runtime;

namespace Coursera.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {

        //private object
        private readonly iTeacherHelper _iTeacherHelper;

        //Constructor
        public TeacherController(iTeacherHelper iTeacherHelper)
        {
            _iTeacherHelper= iTeacherHelper;
        }

        //implementation EndPoints

        [HttpGet]
        public IActionResult Get()
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok(_iTeacherHelper!.GetAll());
        }


        [HttpGet("{id}")]
        public IActionResult Getid(int id)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if (!_iTeacherHelper!.isExist(id))
            {
                return NotFound();
            }

            return Ok(_iTeacherHelper.GetID(id));
        }

    

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if (!_iTeacherHelper.isExist(id))
            {
                return NotFound();
            }
            _iTeacherHelper.DeleteStrudent(id);
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult update(int id, TeacherDto Teacher)
        {


            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if (!_iTeacherHelper.isExist(id))
            {
                return NotFound();
            }
            TeacherET newTeacher = _iTeacherHelper.UpdateStudent(id, Teacher);
            return Ok(newTeacher);
        }


        [HttpPost]
        public IActionResult Post(TeacherET Teacher)
        {
            if (!_iTeacherHelper!.isExist(Teacher.Teacherid))
            {
                TeacherET newTeacher = _iTeacherHelper.CreateStudent(Teacher);
                return Ok(newTeacher);
            }
            return BadRequest();

        }

    }
}
