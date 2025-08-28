namespace StudentTeacherRepo.RepositoryDefination
{
    public interface IStudentRepository
    {
        public bool SaveStudentInfo(List<Student> StudentInfo);
        public Student GetStudentById(int id);
        public List<Student> GetAllStudents();
        public bool UpdateStudentInfo(Student student);
        public bool DeleteStudentById(int id);

    }
}
