using DependencyInjectionPractice.Services;

namespace DependencyInjectionPractice.Managers
{
    public class ClassRoom
    {
        private readonly ITeacher _teacher;

        public ClassRoom(ITeacher teacher)
        {
            _teacher = teacher;
        }

        public void GetTeacherInfo()
        {
             _teacher.GetInfo();
        }
    }
}
