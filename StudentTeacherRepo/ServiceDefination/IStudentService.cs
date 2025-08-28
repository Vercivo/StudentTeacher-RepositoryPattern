namespace StudentTeacherRepo.ServiceDefination
{
    public interface IStudentService
    {
        public bool SaveStudentInfo(List<Student> studentInfo);
        public Student GetStudentById(int id);
        public List<Student> GetAllStudents();
        public bool UpdateStudentInfo(Student student);
        public bool DeleteStudentById(int id);
    }
}
