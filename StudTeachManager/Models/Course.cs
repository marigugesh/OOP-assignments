namespace StudTeachManager.Models
{
    public class Course
    {
        public string Title { get; set; }
        public Teacher Instructor { get; set; }
        public List<Student> EnrolledStudents { get; set; } = new List<Student>();

        public Course(string title, Teacher instructor)
        {
            Title = title;
            Instructor = instructor;
        }
    }
}