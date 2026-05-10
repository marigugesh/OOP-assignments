namespace StudTeachManager.Models
{
    public class Student : Person, Interfaces.IPrintable
    {
        public Student(int id, string name) : base(id, name) { }

        public void PrintDetails() => Console.WriteLine($"[Student] ID: {Id} | Name: {Name}");
    }
}