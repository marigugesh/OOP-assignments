namespace StudTeachManager.Models
{
    public class Teacher : Person, Interfaces.IPrintable
    {
        public string Subject { get; set; }
        public Teacher(int id, string name, string subject) : base(id, name)
        {
            Subject = subject;
        }

        public void PrintDetails() => Console.WriteLine($"[Teacher] ID: {Id} | Name: {Name} | Subject: {Subject}");
    }
}