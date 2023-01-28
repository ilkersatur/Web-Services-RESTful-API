using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Baslangic : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "Test 1 2 3";
        }

        [HttpGet("Selam")] // 2 Tane Get olamaz ama isim vererek bu sorunu çözebiliriz.
        public string Merhaba(int id)
        {
            return "Merhaba" + id;
        }

        [HttpGet("Test")] // 2 Tane Get olamaz ama isim vererek bu sorunu çözebiliriz.
        public IActionResult Denemeler(int id)
        {
            string[] sehirler = { "İstanbul", "Ankara", "İzmir" };
            return Ok(sehirler);
            //return Unauthorized();
            //return NotFound();


        }
        [HttpPost]
        public void Post()
        {

        }
    }
}
