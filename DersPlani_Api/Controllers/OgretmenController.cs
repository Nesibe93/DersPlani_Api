using DersPlani_Api.Models;
using DersPlani_Api.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DersPlani_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OgretmenController : ControllerBase
    {

        private readonly OgretmenRepository _context;

        public OgretmenController(OgretmenRepository ogretmenRepository)
        {
            _context = ogretmenRepository;
        }

        // Listeleme
        [HttpGet]
        public IActionResult GetAll()
        {
            var ogretmenler = _context.GetAll();
            return Ok(ogretmenler);
        }
        // Id'ye göre listele
        [HttpGet("{id}")]
        public IActionResult GetOgretmen(int id)
        {
            var ogretmen = _context.GetById(id);
            if (ogretmen == null)
            {
                return NotFound();
            }
            return Ok(ogretmen);
        }
        // Ekle
        [HttpPost]
        public IActionResult AddOgretmen([FromBody] Ogretmen ogretmen)
        {
            _context.Add(ogretmen);
            return CreatedAtAction(nameof(GetOgretmen), new { id = ogretmen.OgretmenId }, ogretmen);

        }
        // Id'ye göre güncelle
        [HttpPut("{id}")]
        public IActionResult UpdateOgretmen(int id, [FromBody] Ogretmen ogretmen)
        {
            if (id != ogretmen.OgretmenId)
            {
                return BadRequest();
            }

            _context.Update(ogretmen);
            return NoContent();
        }
        // Sil
        [HttpDelete("{id}")]
        public IActionResult DeleteOgretmen(int id)
        {
            _context.Delete(id);
            return NoContent();
        }
    }
}
