using StudentTeacherRepo.RepositoryDefination;

namespace StudentTeacherRepo.Repository
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly AppDbContext _context;

        public DepartmentRepository(AppDbContext context)
        {
            _context = context;
        }

        public bool DeleteDepartmentById(int id)
        {
            var department = _context.Departments.Find(id);
            if (department == null)
            {
                return false; // Department not found
            }
            _context.Departments.Remove(department);
            _context.SaveChanges();
            return true;
        }

        public List<Department> GetAllDepartments()
        {
            return _context.Departments.ToList();
        }

        public Department GetDepartmentById(int id)
        {
            var department = _context.Departments.Find(id);
            return department;
        }

        public bool SaveDepartmentInfo(List<Department> departmentInfo)
        {
            _context.Departments.AddRange(departmentInfo);
            _context.SaveChanges();
            return true;
        }

        public bool UpdateDepartmentInfo(Department department)
        {
            var existingDepartment = _context.Departments.Find(department.Id);
            if (existingDepartment == null)
            {
                return false; // Department not found
            }
            existingDepartment.Name = department.Name;
            existingDepartment.DepCode = department.DepCode;
            _context.SaveChanges();
            return true;
        }
    }
}
