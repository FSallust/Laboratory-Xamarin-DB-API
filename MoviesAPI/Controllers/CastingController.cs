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
    public class CastingController : ControllerBase
    {
        private ICastingService _service;

        public CastingController(ICastingService castingService)
        {
            _service = castingService;
        }

        //https://localhost:port/api/casting
        [HttpGet]
        public IActionResult GetPersonList()
        {
            return Ok(_service.GetAll().Select(m => m.ToAPI()));
        }

        //https://localhost:port/api/casting/1
        [HttpGet("{Id}")]
        public IActionResult GetPersonByMovieId(int Id)
        {
            return Ok(_service.GetByMovieId(Id).Select(m => m.ToAPI()));
        }
    }
}
