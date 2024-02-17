using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace pdf_converter_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class DocumentController : ControllerBase
    {
        [HttpPost]
        public ActionResult Post()
        {
            return Ok("Hello");
        }

        [HttpGet]
        public ActionResult Get()
        {
            return Ok("Hello");
        }
    }
}