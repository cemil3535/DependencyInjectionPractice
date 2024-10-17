# Dependency_Injection_Practice


Create an example using Dependency Injection among the classes given below.

Classes:

TeacherClass

Properties:

FirstName: string

LastName: string

Methods:

GetInfo(): A method that returns the teacher's first and last name.

ClassRoom Class

Properties:

Teacher: An object of type Teacher

Methods:

GetTeacherInfo(): A method that returns the teacher's information. It is enough to call GetInfo() inside Teacher.

Task:

Write the Teacher and Classroom classes.

Pass an instance of the Teacher class as a parameter to the constructor of the ClassRoom class. (Constructor Injection)

Create a Classroom object using the methods of both classes and print the teacher's information on the screen.

NOTE: Dependency Injection means giving the dependencies that a class needs from outside. This provides a more flexible structure by reducing dependencies between classes.

ADDITION: Don't forget to create a Base Interface for the Ogretmen class. IOgretmen

### Technologies Used and Structures 
- C#
- Dependency Injection
