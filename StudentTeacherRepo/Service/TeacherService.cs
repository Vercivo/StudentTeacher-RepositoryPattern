using StudentTeacherRepo.RepositoryDefination;
using StudentTeacherRepo.ServiceDefination;

namespace StudentTeacherRepo.Service
{
    public class TeacherService : ITeacherService
    {
        private readonly ITeacherRepository _teacherRepository;

        public TeacherService(ITeacherRepository teacherRepository)
        {
            _teacherRepository = teacherRepository;
        }

        public bool DeleteTeacherById(int id)
        {
            _teacherRepository.DeleteTeacherById(id);
            return true;
        }

        public List<Teacher> GetAllTeachers()
        {
            return _teacherRepository.GetAllTeachers();
        }

        public Teacher GetTeacherById(int id)
        {
            return _teacherRepository.GetTeacherById(id);
        }

        public bool SaveTeacherInfo(List<Teacher> TeacherInfo)
        {
            _teacherRepository.SaveTeacherInfo(TeacherInfo);
            return true;
        }

        public bool UpdateTeacherInfo(Teacher teacher)
        {
            _teacherRepository.UpdateTeacherInfo(teacher);
            return true;
        }
    }
}
