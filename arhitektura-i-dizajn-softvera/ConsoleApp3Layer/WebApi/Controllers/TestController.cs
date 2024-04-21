using BusinessLogic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly MyBusiness _myBusiness;

        public TestController()
        {
            _myBusiness = new MyBusiness();
        }

        [HttpGet]
        public IActionResult Get()
        {
            _myBusiness.ProcessData();
            return Ok();
        }
    }
}
