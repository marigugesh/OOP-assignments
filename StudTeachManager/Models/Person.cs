namespace StudTeachManager.Models
{
    public abstract class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }

        protected Person(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}