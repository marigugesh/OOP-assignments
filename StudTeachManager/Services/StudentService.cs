using StudTeachManager.Models;
using StudTeachManager.Exceptions;

namespace StudTeachManager.Services
{
    public class StudentService
    {
        private readonly List<Student> _students = new List<Student>();

        // Adds a student to the system
        public void AddStudent(Student student)
        {
            _students.Add(student);
            Console.WriteLine($"[System] Student {student.Name} added successfully.");
        }

        // Finds a student by their ID
        public Student GetStudentById(int id)
        {
            var student = _students.FirstOrDefault(s => s.Id == id);

            if (student == null)
            {
                throw new StudentNotFoundException($"Student with ID {id} was not found in the system.");
            }

            return student;
        }

        public List<Student> GetAllStudents() => _students;
    }
}