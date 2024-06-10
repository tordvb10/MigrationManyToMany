using MigrationManyToMany.Data;
using MigrationManyToMany.Interfaces;
using MigrationManyToMany.Models;

namespace MigrationManyToMany.Repository
{
    public class ParentRepository : IParentRepository
    {
        private readonly MyDbContext _context;
        public ParentRepository(MyDbContext context)
        {
            _context = context;
        }
        public ICollection<Parent> GetParents()
        {
            return _context.Parents.OrderBy(p => p.Id).ToList();
        }
    }
}
