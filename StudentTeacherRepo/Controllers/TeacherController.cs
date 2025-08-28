using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentTeacherRepo.ServiceDefination;

namespace StudentTeacherRepo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        private readonly ITeacherService _teacherService;

        public TeacherController(ITeacherService teacherService)
        {
            _teacherService = teacherService;
        }

    [HttpGet("GetAllTeachers")]
    public IActionResult GetAllTeachers()
        {
            var teachers = _teacherService.GetAllTeachers();
            return Ok(teachers);
        }

    [HttpGet("GetTeacherById")]
    public IActionResult GetTeacherById(int id)
        {
            var teacher = _teacherService.GetTeacherById(id);
            return Ok(teacher);
        }

    [HttpPost("AddTeacher")]
    public IActionResult SaveTeacherInfo(List<Teacher> teacherinfo)
        {
            var isSaved = _teacherService.SaveTeacherInfo(teacherinfo);
            if (isSaved)
            {
                return Ok("Teacher information saved successfully.");
            }
            return BadRequest("Failed to save teacher information.");
        }

    [HttpPut("UpdateTeacher")]
    public IActionResult UpdateTeacherInfo(Teacher teacher)
        {
            var isUpdated = _teacherService.UpdateTeacherInfo(teacher);
            if (isUpdated)
            {
                return Ok("Teacher information updated successfully.");
            }
            return BadRequest("Failed to update teacher information.");
        }

    [HttpDelete("DeleteTeacherById")]
    public IActionResult DeleteTeacher(int id) 
        {
            var isDeleted = _teacherService.DeleteTeacherById(id);
            if (isDeleted)
            {
                return Ok("Teacher deleted successfully.");
            }
            return BadRequest("Failed to delete teacher.");
        }
    }
}
