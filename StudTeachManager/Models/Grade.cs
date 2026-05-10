namespace StudTeachManager.Models
{
    public class Grade
    {
        public Student Student { get; set; }
        public Course Course { get; set; }
        public double Value { get; set; }
    }
}
