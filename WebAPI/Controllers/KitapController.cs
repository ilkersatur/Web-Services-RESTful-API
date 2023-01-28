using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [Route("servis/[controller]")]
    [ApiController]
    public class KitapController : ControllerBase
    {
        [HttpGet]
        public IActionResult ListeGet()
        {
            return Ok(KitapDB.Kitaplar());
        }
        [HttpPost]
        public IActionResult Post(Kitap kitap)
        {
            KitapDB.KitapEkle(kitap);
            return Ok();
        }
    }
}
