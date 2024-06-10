namespace MigrationManyToMany.Models
{
    public class ParentChild
    {
        public int ChildId { get; set; }
        public Child Child { get; set; }
        public int ParentId { get; set; }
        public Parent Parent { get; set; }

    }
}
