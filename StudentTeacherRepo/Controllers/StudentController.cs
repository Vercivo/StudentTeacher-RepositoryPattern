using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentTeacherRepo.ServiceDefination;

namespace StudentTeacherRepo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;
        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

    [HttpGet("GetAllStudents")]
    public IActionResult GetAllStudents()
        {
            var students = _studentService.GetAllStudents();
            return Ok(students);
        }

    [HttpGet("GetStudentById")]
    public IActionResult GetStudentById(int id)
        {
            var student = _studentService.GetStudentById(id);
            return Ok(student);
        }

    [HttpPost("AddStudent")]
    public IActionResult SaveStudentInfo(List<Student> studentinfo)
        {
            var isSaved = _studentService.SaveStudentInfo(studentinfo);
            if (isSaved)
            {
                return Ok("Student information saved successfully.");
            }
            return BadRequest("Failed to save student information.");
        }

    [HttpPut("UpdateStudent")]
    public IActionResult UpdateStudentInfo(Student student)
        {
            var isUpdated = _studentService.UpdateStudentInfo(student);
            if (isUpdated)
            {
                return Ok("Student information updated successfully.");
            }
            return BadRequest("Failed to update student information.");
        }

    [HttpDelete("DeleteStudentById")]
    public IActionResult DeleteStudent(int id) 
        {
            var isDeleted = _studentService.DeleteStudentById(id);
            if (isDeleted)
            {
                return Ok("Student deleted successfully.");
            }
            return NotFound("Student not found.");
        }
    }
}
