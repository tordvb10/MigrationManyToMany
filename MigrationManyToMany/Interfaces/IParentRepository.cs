using MigrationManyToMany.Models;

namespace MigrationManyToMany.Interfaces
{
    public interface IParentRepository
    {
        ICollection<Parent> GetParents();
    }
}
