using DependencyInjectionPractice.Services;

namespace DependencyInjectionPractice.Managers
{
    public class Teacher : ITeacher
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        

        public void GetInfo()
        {
            Console.WriteLine($"Ogretmenin Adi ve Soyadi: {FirstName} {LastName}"); 
        }
    }
}
