using StudTeachManager.Exceptions;
using StudTeachManager.Models;
using StudTeachManager.Services;

class Program
{
    static void Main()
    {
  
        StudentService studentService = new StudentService();
        CourseService courseService = new CourseService();
        GradingService gradingService = new GradingService();

        try
        {
            // 2. Setup Data using Services
            Teacher prof = new Teacher(1, "Dr. Guga", "C# Development");
            Course cs211 = new Course("CS211-OOP", prof);
            courseService.AddCourse(cs211);

            Student luka = new Student(101, "Luka");
            studentService.AddStudent(luka);

            // 3. Perform Operations
            courseService.EnrollStudentInCourse(luka, "CS211-OOP");

            gradingService.AddGrade(luka, cs211, 98.5);
            gradingService.AddGrade(luka, cs211, 92.0);

            // 4. Print Results
            Console.WriteLine("\n--- Final Report ---");
            luka.PrintDetails();
            Console.WriteLine($"Average in {cs211.Title}: {gradingService.CalculateAverage(luka)}%");

            // 5. Test Exception (Searching for a non-existent student)
            studentService.GetStudentById(999);

        }
        catch (StudentNotFoundException ex)
        {
            Console.WriteLine($"[Error]: {ex.Message}");
        }
        catch (CourseNotFoundException ex)
        {
            Console.WriteLine($"[Error]: {ex.Message}");
        }
        catch (InvalidGradeException ex)
        {
            Console.WriteLine($"[Error]: {ex.Message}");
        }
    }
}