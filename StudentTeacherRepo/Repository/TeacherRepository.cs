using StudentTeacherRepo.RepositoryDefination;

namespace StudentTeacherRepo.Repository
{
    public class TeacherRepository : ITeacherRepository
    {
        private readonly AppDbContext _context;
        public TeacherRepository(AppDbContext context)
        {
            _context = context;
        }

        public bool DeleteTeacherById(int id)
        {
            var teacher = _context.Teachers.Find(id);
            if (teacher == null)
            {
                return false; // Teacher not found
            }
            _context.Teachers.Remove(teacher);
            _context.SaveChanges();
            return true;
        }

        public List<Teacher> GetAllTeachers()
        {
            return _context.Teachers.ToList();
        }

        public Teacher GetTeacherById(int id)
        {
            var teacher = _context.Teachers.Find(id);
            return teacher;
        }

        public bool SaveTeacherInfo(List<Teacher> TeacherInfo)
        {
            _context.Teachers.AddRange(TeacherInfo);
            _context.SaveChanges();
            return true;
        }

        public bool UpdateTeacherInfo(Teacher teacher)
        {
            var existingTeacher = _context.Teachers.Find(teacher.Id);
            if (existingTeacher == null)
            {
                return false; // Teacher not found
            }
            existingTeacher.FirstName = teacher.FirstName;
            existingTeacher.LastName = teacher.LastName;
            existingTeacher.Email = teacher.Email;
            existingTeacher.Designation = teacher.Designation;
            _context.SaveChanges();
            return true;
        }
    }
}
