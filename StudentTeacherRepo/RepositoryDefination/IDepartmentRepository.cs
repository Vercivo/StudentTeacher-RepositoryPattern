namespace StudentTeacherRepo.RepositoryDefination
{
    public interface IDepartmentRepository
    {
        public bool SaveDepartmentInfo(List<Department> departmentInfo);
        public Department GetDepartmentById(int id);
        public List<Department> GetAllDepartments();
        public bool UpdateDepartmentInfo(Department department);
        public bool DeleteDepartmentById(int id);
    }
}
