namespace MigrationManyToMany.Models
{
    public class Child
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<ParentChild> ParentsChildren { get; set; }
    }
}
