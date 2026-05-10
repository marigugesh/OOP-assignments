using StudTeachManager.Models;
using StudTeachManager.Exceptions;

namespace StudTeachManager.Services
{
    public class CourseService
    {
        private readonly List<Course> _courses = new List<Course>();

        public void AddCourse(Course course)
        {
            _courses.Add(course);
            Console.WriteLine($"[System] Course '{course.Title}' created with instructor {course.Instructor.Name}.");
        }

        public Course GetCourseByTitle(string title)
        {
            var course = _courses.FirstOrDefault(c => c.Title.Equals(title, StringComparison.OrdinalIgnoreCase));

            if (course == null)
            {
                throw new CourseNotFoundException($"The course '{title}' does not exist.");
            }

            return course;
        }

        // This method links a student to a course
        public void EnrollStudentInCourse(Student student, string courseTitle)
        {
            var course = GetCourseByTitle(courseTitle); // This might throw CourseNotFoundException

            if (!course.EnrolledStudents.Contains(student))
            {
                course.EnrolledStudents.Add(student);
                Console.WriteLine($"[System] {student.Name} enrolled in {courseTitle}.");
            }
        }
    }
}