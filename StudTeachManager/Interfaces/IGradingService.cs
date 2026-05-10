using StudTeachManager.Models;

namespace StudTeachManager.Interfaces
{
    public interface IGradingService
    {
        void AddGrade(Student student, Course course, double value);
        double CalculateAverage(Student student);
    }
}