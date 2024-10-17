// See https://aka.ms/new-console-template for more information
using Dependency_Injection_Practice.Modals;
using System.Net.Http.Headers;


// Creating a Teacher object
ITeacher teacher = new Teacher("Cemal","Kaya");

// Create ClassRoom object and pass Teacher object
ClassRoom classroom = new ClassRoom(teacher);

// Printing teacher's information
Console.WriteLine(classroom.GetTeacherInfo());