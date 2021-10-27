using DAL.interfaces;
using DemoAPI.Tools;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private IPersonService _service;

        public PersonController(IPersonService personService)
        {
            _service = personService;
        }

        //https://localhost:port/api/person
        [HttpGet]
        public IActionResult GetPersonList()
        {
            return Ok(_service.GetAll().Select(m => m.ToAPI()));
        }

        //https://localhost:port/api/person
        [HttpGet("{Id}")]
        public IActionResult GetPersonById(int Id)
        {
            return Ok(_service.GetById(Id).ToAPI());
        }
    }
}
