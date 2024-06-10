using Microsoft.AspNetCore.Mvc;
using MigrationManyToMany.Interfaces;
using MigrationManyToMany.Models;
namespace MigrationManyToMany.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParentController : Controller
    {
        private readonly IParentRepository _parentRepository;
        public ParentController(IParentRepository parentRepository)
        {
            _parentRepository = parentRepository;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Parent>))]

        public IActionResult GetParents()
        {
            var parents = _parentRepository.GetParents();
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok(parents);
        }

    }
}
