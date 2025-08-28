using StudentTeacherRepo.RepositoryDefination;

namespace StudentTeacherRepo.Repository
{
    public class StudentRepository : IStudentRepository
    {
        private readonly AppDbContext _context;

        public StudentRepository(AppDbContext context)
        {
            _context = context;
        }

        public bool DeleteStudentById(int id)
        {
            var student = _context.Students.Find(id);
            if (student == null)
            {
                return false; // Student not found
            }
            _context.Students.Remove(student);
            _context.SaveChanges();
            return true;
        }

        public List<Student> GetAllStudents()
        {
            return _context.Students.ToList();
        }

        public Student GetStudentById(int id)
        {
            var student = _context.Students.Find(id);
            return student;
        }

        public bool SaveStudentInfo(List<Student> StudentInfo)
        {
            _context.Students.AddRange(StudentInfo);
            _context.SaveChanges();
            return true;
        }

        public bool UpdateStudentInfo(Student student)
        {
            var existingStudent = _context.Students.Find(student.Id);
            if (existingStudent == null)
            {
                return false; // Student not found
            }
            existingStudent.FirstName = student.FirstName;
            existingStudent.LastName = student.LastName;
            existingStudent.Email = student.Email;
            existingStudent.DateOfBirth = student.DateOfBirth;
            _context.SaveChanges();
            return true;
        }
    }
}
