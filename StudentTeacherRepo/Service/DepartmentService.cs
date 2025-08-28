using StudentTeacherRepo.RepositoryDefination;
using StudentTeacherRepo.ServiceDefination;

namespace StudentTeacherRepo.Service
{
    public class DepartmentService : IDepartmentService
    {
        private readonly IDepartmentRepository _departmentRepository;

        public DepartmentService(IDepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }

        public bool DeleteDepartmentById(int id)
        {
            _departmentRepository.DeleteDepartmentById(id);
            return true;
        }

        public List<Department> GetAllDepartments()
        {
            return _departmentRepository.GetAllDepartments();
        }

        public Department GetDepartmentById(int id)
        {
            return _departmentRepository.GetDepartmentById(id);
        }

        public bool SaveDepartmentInfo(List<Department> departmentInfo)
        {
            _departmentRepository.SaveDepartmentInfo(departmentInfo);
            return true;
        }

        public bool UpdateDepartmentInfo(Department department)
        {
            _departmentRepository.UpdateDepartmentInfo(department);
            return true;
        }
    }
}
