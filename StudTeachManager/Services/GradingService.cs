using StudTeachManager.Interfaces;
using StudTeachManager.Models;
using StudTeachManager.Exceptions;

namespace StudTeachManager.Services
{
    public class GradingService : IGradingService
    {
        private List<Grade> _allGrades = new List<Grade>();

        public void AddGrade(Student student, Course course, double value)
        {
            if (value < 0 || value > 100)
                throw new InvalidGradeException($"The grade {value} is invalid. It must be between 0 and 100.");

            _allGrades.Add(new Grade { Student = student, Course = course, Value = value });
        }

        public double CalculateAverage(Student student)
        {
            var studentGrades = _allGrades.FindAll(g => g.Student.Id == student.Id);
            if (studentGrades.Count == 0) return 0;

            double sum = 0;
            foreach (var g in studentGrades) sum += g.Value;
            return sum / studentGrades.Count;
        }
    }
}