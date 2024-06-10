namespace MigrationManyToMany.Models
{
    public class Parent
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<ParentChild> ParentsChildren { get; set; }
    }
}
