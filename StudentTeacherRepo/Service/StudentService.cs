using StudentTeacherRepo.RepositoryDefination;
using StudentTeacherRepo.ServiceDefination;

namespace StudentTeacherRepo.Service
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;

        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public bool DeleteStudentById(int id)
        {
            _studentRepository.DeleteStudentById(id);
            return true;
        }

        public List<Student> GetAllStudents()
        {
            return _studentRepository.GetAllStudents();
        }

        public Student GetStudentById(int id)
        {
            return _studentRepository.GetStudentById(id);
        }

        public bool SaveStudentInfo(List<Student> studentInfo)
        {
            _studentRepository.SaveStudentInfo(studentInfo);
            return true;
        }

        public bool UpdateStudentInfo(Student student)
        {
            _studentRepository.UpdateStudentInfo(student);
            return true;
        }
    }
}
