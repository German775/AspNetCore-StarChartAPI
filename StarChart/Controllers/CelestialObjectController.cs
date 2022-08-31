using System.Linq;
using Microsoft.AspNetCore.Mvc;
using StarChart.Data;

namespace StarChart.Controllers
{
    [Route("")]
    [ApiController]
    public class CelestialObjectController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public CelestialObjectController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet("{id:int}",Name="GetById")]
        public IActionResult GetById(int id)
        {
            var CelestialObject = _context.CelestialObjects.FirstOrDefault(i => i.Id == id);

            if (CelestialObject == null)
                return NotFound();

            return Ok(CelestialObject);
        }

        public IActionResult Index()
        {
            return null;// View();
        }
    }
}
