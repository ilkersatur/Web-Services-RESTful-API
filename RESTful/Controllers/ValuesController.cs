using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RESTful.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        //public string Get()
        //{
        //    return "value";
        //}

        [HttpGet]
        public string[] VerileriGetir()
        {
            return new string[] { "Istanbul", "Ankara", "İzmir" };
        }
    }
}
