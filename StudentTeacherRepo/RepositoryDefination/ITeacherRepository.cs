namespace StudentTeacherRepo.RepositoryDefination
{
    public interface ITeacherRepository
    {
        public bool SaveTeacherInfo(List<Teacher> TeacherInfo);
        public Teacher GetTeacherById(int id);
        public List<Teacher> GetAllTeachers();
        public bool UpdateTeacherInfo(Teacher teacher);
        public bool DeleteTeacherById(int id);

    }
}
