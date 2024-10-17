using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Injection_Practice.Modals
{
    public class Teacher : ITeacher
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Teacher(string firstName, string lastName) 
        {
            FirstName = firstName;
            LastName = lastName;
        }
        

        public string GetInfo()
        {
            return $"{FirstName} {LastName}";
        }

       
    }
}
