using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentTeacherRepo.ServiceDefination;

namespace StudentTeacherRepo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IDepartmentService _departmentService;
        public DepartmentController(IDepartmentService departmentService)
        {
            _departmentService = departmentService;
        }

    [HttpGet("GetAllDepartments")]
    public IActionResult GetAllDepartments()
        {
            var departments = _departmentService.GetAllDepartments();
            return Ok(departments);
        }

    [HttpGet("GetDepartmentById")]
    public IActionResult GetDepartmentById(int id)
        {
            var department = _departmentService.GetDepartmentById(id);
            return Ok(department);
        }

    [HttpPost("AddDepartment")]
    public IActionResult SaveDepartmentInfo(List<Department> departmentinfo)
        {
            var isSaved = _departmentService.SaveDepartmentInfo(departmentinfo);
            if (isSaved)
            {
                return Ok("Department information saved successfully.");
            }
            return BadRequest("Failed to save department information.");
        }

    [HttpPut("UpdateDepartment")]
    public IActionResult UpdateDepartmentInfo(Department department)
        {
            var isUpdated = _departmentService.UpdateDepartmentInfo(department);
            if (isUpdated)
            {
                return Ok("Department information updated successfully.");
            }
            return BadRequest("Failed to update department information.");
        }

    [HttpDelete("DeleteDepartmentById")]
    public IActionResult DeleteDepartment(int id) 
        {
            var isDeleted = _departmentService.DeleteDepartmentById(id);
            if (isDeleted)
            {
                return Ok("Department deleted successfully.");
            }
            return BadRequest("Failed to delete department.");
        }
    }
}
