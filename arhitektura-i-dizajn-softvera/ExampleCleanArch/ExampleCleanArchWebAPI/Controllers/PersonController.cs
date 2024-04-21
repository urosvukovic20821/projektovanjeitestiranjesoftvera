using Core.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExampleCleanArchWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IPersonBusiness _personBusiness;

        public PersonController(IPersonBusiness personBusiness)
        {
            _personBusiness = personBusiness;
        }

        [HttpPost]
        public IActionResult Add(string firstName, string lastName)
        {
            _personBusiness.Add(firstName, lastName);
            return Ok();
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_personBusiness.GetAllPersons());
        }

    }
}
