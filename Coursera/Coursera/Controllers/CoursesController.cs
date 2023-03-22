using Coursera.Dto;
using Coursera.Models;
using Coursera.Repository.CoursesRepo;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Coursera.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {

        //private object 
        private readonly iCourseHelper _iCourseHelper;

        //public constructor 
        public CoursesController(iCourseHelper iCourseHelper)
        {
            _iCourseHelper = iCourseHelper;
        }

        //EndPoints implementation

        [HttpGet]
        public IActionResult Get()
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok(_iCourseHelper!.GetAll());
        }


        [HttpGet("{id}")]
        public IActionResult Getid(int id)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if (!_iCourseHelper!.isExist(id))
            {
                return NotFound();
            }

            return Ok(_iCourseHelper.GetID(id));
        }


        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if (!_iCourseHelper.isExist(id))
            {
                return NotFound();
            }
            _iCourseHelper.DeleteStrudent(id);
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult update(int id, CoursesDto course)
        {


            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if (!_iCourseHelper.isExist(id))
            {
                return NotFound();
            }
            CourseET newCourse = _iCourseHelper.UpdateStudent(id, course);
            return Ok(newCourse);
        }


        [HttpPost]
        public IActionResult Post(CourseET course)
        {
            if (!_iCourseHelper!.isExist(course.CourseID))
            {
                CourseET newCourse = _iCourseHelper.CreateStudent(course);
                return Ok(newCourse);
            }
            return BadRequest();

        }



    }
}
